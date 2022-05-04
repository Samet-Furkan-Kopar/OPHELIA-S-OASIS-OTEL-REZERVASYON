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
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int MusteriID { get; set; }
        public int RezervasyonTipID { get; set; }
        public double Ucret { get; set; }
        public int OdaNO { get; set; }
        public double Hesaplanan { get; set; }

        public void RezervasyonKayit()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Rezervasyonlar (GirisTarihi,CikisTarihi,MusteriID,RezervasyonTipID,Ucret) Values ('" + GirisTarihi+ "','" + CikisTarihi + "','" + MusteriID + "','" + RezervasyonTipID + "','" + Ucret + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void RezervasyonOnayla()
        {
            SqlCommand Com = new SqlCommand("update Tbl_Odalar set Doluluk=1, MusteriID=@MusteriID where OdaID=@OdaNo", bgl.baglanti());
            Com.Parameters.AddWithValue("@MusteriID", MusteriID);
            Com.Parameters.AddWithValue("@OdaNo", OdaNO);
            Com.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Check-In İşlemi Tamamlandı.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
