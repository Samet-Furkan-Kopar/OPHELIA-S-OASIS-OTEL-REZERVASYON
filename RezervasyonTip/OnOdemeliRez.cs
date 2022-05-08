using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotelOasis
{
    //.Bu rezervasyon iptal edildiğinde geri ödeme yoktur.Fakat ek bir
    // ücretle rezervasyon günü değiştirilebilir.Bu ek ücret de o anki taban fiyatın %110 udur.

    public class OnOdemeliRez : IRezervasyonTipi
    {
        public int aralik { get; set; }
        double tesvikliTutar;
        double odenecekTutar;
        string giris;
        string cikis;
        public int MusteriId;

        public int tabanFiyat { get; set; }

        Sql bgl = new Sql();

        public void TabanFiyatGetir()
        {
            SqlCommand Com2 = new SqlCommand("select TabanFiyat from Tbl_Fiyat", bgl.baglanti());
            SqlDataReader Dr1 = Com2.ExecuteReader();
            while (Dr1.Read())
            {
                tabanFiyat = (int)Dr1[0];
            }
        }

        public OnOdemeliRez(int aralik, string Giris, string Cikis, string lblMusteriID)
        {
            this.aralik = aralik;
            this.giris = Giris;
            this.cikis = Cikis;
            this.MusteriId = int.Parse(lblMusteriID);
        }
        public int RezervasyonIslemYap()
        {
            RezervasyonIslemleri rezervasyonIslemleri1 = new RezervasyonIslemleri();
            TabanFiyatGetir();
            odenecekTutar = tabanFiyat * 0.75 * aralik;
            if (rezervasyonIslemleri1.Hesaplanan <= 60 && aralik < 30)
            {
                tesvikliTutar = odenecekTutar * 0.8;
                rezervasyonIslemleri1.GirisTarihi = giris;
                rezervasyonIslemleri1.CikisTarihi = cikis;
                rezervasyonIslemleri1.Ucret = tesvikliTutar;
                rezervasyonIslemleri1.RezervasyonTipID = 4;
                rezervasyonIslemleri1.MusteriID = MusteriId;
                rezervasyonIslemleri1.RezervasyonKayit();
                MessageBox.Show("Giriş Tarihi: '" + giris + "'\nÇıkış Trihi: '" + cikis + "'\nOdenecek Tutar: " + tesvikliTutar, "REZERVASYON YAPILMIŞTIR", MessageBoxButtons.OK);
            }
            else
            {
                RezervasyonIslemleri rezervasyonIslemleri = new RezervasyonIslemleri();
                rezervasyonIslemleri.GirisTarihi = giris;
                rezervasyonIslemleri.CikisTarihi = cikis;
                rezervasyonIslemleri.Ucret = odenecekTutar;
                rezervasyonIslemleri.RezervasyonTipID = 1;
                rezervasyonIslemleri.MusteriID = MusteriId;
                rezervasyonIslemleri.RezervasyonKayit();
                MessageBox.Show("Giriş Tarihi: '" + giris + "'\nÇıkış Trihi: '" + cikis + "'\nOdenecek Tutar: " + odenecekTutar, "REZERVASYON YAPILMIŞTIR", MessageBoxButtons.OK);
            }
            return 0;
        }
        public int RezervasyonUcretGoster()
        {
            TabanFiyatGetir();

            odenecekTutar = tabanFiyat * 0.75 * aralik;

            RezervasyonIslemleri rezervasyonIslemleri1 = new RezervasyonIslemleri();
            if (rezervasyonIslemleri1.Hesaplanan <= 60 && aralik < 30)
            {
                tesvikliTutar = odenecekTutar * 0.8;
                MessageBox.Show("Kampanyalı Tutar: '" + tesvikliTutar + "'\nRezervasyon Yapmak İçin REZERVASYON YAP Butonuna Tıklayınız.", "ÖDENCEK TUTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kampanyalı Tutar: '" + odenecekTutar + "'\nRezervasyon Yapmak İçin REZERVASYON YAP Butonuna Tıklayınız.", "ÖDENCEK TUTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return 0;
        }
        
    }
}
