using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace hotelOasis
{
    public class RezervasyonIslemleri
    {
        Sql bgl = new Sql();

        public string GirisTarihi { get; set; }
        public string CikisTarihi { get; set; }
        public int MusteriID { get; set; }
        public int RezervasyonTipID { get; set; }
        public double Ucret { get; set; }
        public int OdaNO { get; set; }
        public int RezervasyonID { get; set; }
        public double Hesaplanan { get; set; }
        public int  Aralik { get; set; }
        public int TabanFiyat { get; set; }


        public void RezervasyonOnayla()
        {
            SqlCommand Com = new SqlCommand("update Tbl_Odalar set Doluluk=1, MusteriID=@MusteriID where OdaID=@OdaNo", bgl.baglanti());
            Com.Parameters.AddWithValue("@MusteriID", MusteriID);
            Com.Parameters.AddWithValue("@OdaNo", OdaNO);
            Com.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Check-In İşlemi Tamamlandı.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void OdaDoldur()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_DoluOdalar (GirisTarihi,CikisTarihi,MusteriID,RezervasyonTipID,OdaNo) Values ('" + GirisTarihi + "','" + CikisTarihi + "','" + MusteriID + "','" + RezervasyonTipID + "','" + OdaNO + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void OdaBosalt()
        {
            SqlCommand Com = new SqlCommand("update Tbl_Odalar set Doluluk=0, MusteriID=NULL where  OdaID=@OdaNo", bgl.baglanti());
            Com.Parameters.AddWithValue("@OdaNo", OdaNO);
            Com.ExecuteNonQuery();

            SqlCommand Com2 = new SqlCommand("delete from Tbl_DoluOdalar where OdaNo=@OdaNo", bgl.baglanti());
            Com2.Parameters.AddWithValue("@OdaNo", OdaNO);
            Com2.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Oda Boşaltılmıştır.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void RezervasyonBitir()
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Rezervasyonlar where RezerveID=@RezerveID", bgl.baglanti());
            komut.Parameters.AddWithValue("@RezerveID",RezervasyonID);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void TabanFiyatGetirme()
        {
            SqlCommand Com2 = new SqlCommand("select TabanFiyat from Tbl_Fiyat", bgl.baglanti());
            SqlDataReader Dr1 = Com2.ExecuteReader();
            while (Dr1.Read())
            {
                TabanFiyat = (int)Dr1[0];
            }
        }

        public void RezervasyonGuncelleme()
        {
            TabanFiyatGetirme();
            Ucret = Aralik * TabanFiyat * 1.1;
            SqlCommand Com = new SqlCommand("update Tbl_Rezervasyonlar set GirisTarihi=@GirisTarihi, CikisTarihi=@CikisTarihi,Ucret=@Ucret where RezerveID=@RezerveID", bgl.baglanti());
            Com.Parameters.AddWithValue("@RezerveID", RezervasyonID);
            Com.Parameters.AddWithValue("@GirisTarihi", GirisTarihi);
            Com.Parameters.AddWithValue("@CikisTarihi", CikisTarihi);
            Com.Parameters.AddWithValue("@Ucret", Ucret);
            Com.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void RezervasyonKayit()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Rezervasyonlar (GirisTarihi,CikisTarihi,MusteriID,RezervasyonTipID,Ucret) Values ('" + GirisTarihi+ "','" + CikisTarihi + "','" + MusteriID + "','" + RezervasyonTipID + "','" + Ucret + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void DolulukOranı()
        {
            double Dolu, Sonuc;
            SqlCommand Com2 = new SqlCommand("select count(MusteriID) from Tbl_Odalar where Doluluk = 1", bgl.baglanti());
            SqlDataReader Dr1 = Com2.ExecuteReader();
            while (Dr1.Read())
            {
                Dolu = int.Parse(Dr1[0].ToString());
                Sonuc = (Dolu / 45) * 100;
                Hesaplanan = Sonuc;
            }
        }
    }
}
