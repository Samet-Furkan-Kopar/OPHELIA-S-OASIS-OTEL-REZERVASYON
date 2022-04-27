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
    class Musteriİslemeri
    {
        Sql bgl = new Sql();

        public string KullaniciAdi { get; set; }
        public string AdSoyadi { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }
 
        FrmMusteriGiris musteriGiris = new FrmMusteriGiris();
        

        public void Giris()
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Musteriler where Kullanici_Adi=@adi AND Sifre=@sifresi", bgl.baglanti());
            SqlParameter prm1 = new SqlParameter("adi", KullaniciAdi.Trim());
            SqlParameter prm2 = new SqlParameter("sifresi", Sifre.Trim());
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm2);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                FrmRezervasyon frmRezervasyon = new FrmRezervasyon();
                frmRezervasyon.KullaniciAd = KullaniciAdi;
                frmRezervasyon.Show();
            }
            else if (KullaniciAdi == "" && Sifre == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adını ve Şifre Alanını Boş Bırakmayınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FrmMusteriGiris frmMusteriGiris = new FrmMusteriGiris();
                frmMusteriGiris.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FrmMusteriGiris frmMusteriGiris = new FrmMusteriGiris();
                frmMusteriGiris.Show();
            }
        }

        public void KayıtOl()
        {
            if (KullaniciAdi == "" || Sifre == ""  || AdSoyadi == "" || Eposta == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Eksiksiz Doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FrmMusteriKayitOl frmMusteriKayitOl = new FrmMusteriKayitOl();
                frmMusteriKayitOl.Show();
            }
            else
            {
                SqlCommand komut = new SqlCommand("Insert into Tbl_Musteriler (AdiSoyadi,Kullanici_Adi,Sifre,Eposta) Values ('" + AdSoyadi + "','" + KullaniciAdi + "','" + Sifre + "','" + Eposta + "')", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı\nKullanıcı Adınız: " + KullaniciAdi.ToUpper() + "\nŞifreniz: " + Sifre.ToUpper(), "KAYIT TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                musteriGiris.Show();
                FrmMusteriKayitOl frmMusteriKayitOl = new FrmMusteriKayitOl();
                frmMusteriKayitOl.Hide();
            }
        }
    }
}
