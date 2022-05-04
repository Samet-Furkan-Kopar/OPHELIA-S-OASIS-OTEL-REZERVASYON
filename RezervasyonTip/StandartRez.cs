using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelOasis
{
    public class StandartRez : IRezervasyonTipi
    {
        public int aralik;
        public DateTimePicker dateTimeGiris;
        public DateTimePicker dateTimeCikis;
        public string MusteriId;
        double odenecekTutar;
        double tesvikliTutar;
        int tabanFiyat = 100;

        public StandartRez(int aralik, DateTimePicker dateTimeGiris, DateTimePicker dateTimeCikis, string lblMusteriID)
        {
            this.aralik = aralik;
            this.dateTimeGiris = dateTimeGiris;
            this.dateTimeCikis = dateTimeCikis;
            this.MusteriId = lblMusteriID;
        }

        public int RezervasyonIslemYap()
        {
            RezervasyonIslemleri rezervasyonIslemleri1 = new RezervasyonIslemleri();
            odenecekTutar = tabanFiyat * aralik;
            if (rezervasyonIslemleri1.Hesaplanan <= 60 && aralik < 30)
            {
                tesvikliTutar = odenecekTutar * 0.8;
                rezervasyonIslemleri1.GirisTarihi = dateTimeGiris.Value;
                rezervasyonIslemleri1.CikisTarihi = dateTimeCikis.Value;
                rezervasyonIslemleri1.Ucret = tesvikliTutar;
                rezervasyonIslemleri1.RezervasyonTipID = 3;
                rezervasyonIslemleri1.MusteriID = int.Parse(MusteriId);
                rezervasyonIslemleri1.RezervasyonKayit();
                MessageBox.Show("Giriş Tarihi: '" + dateTimeGiris.Value.ToShortDateString() + "'\nÇıkış Trihi: '" + dateTimeCikis.Value.ToShortDateString() + "'\nOdenecek Tutar: " + tesvikliTutar, "REZERVASYON YAPILMIŞTIR", MessageBoxButtons.OK);
            }
            else
            {
                RezervasyonIslemleri rezervasyonIslemleri = new RezervasyonIslemleri();
                rezervasyonIslemleri.GirisTarihi = dateTimeGiris.Value;
                rezervasyonIslemleri.CikisTarihi = dateTimeCikis.Value;
                rezervasyonIslemleri.Ucret = odenecekTutar;
                rezervasyonIslemleri.RezervasyonTipID = 3;
                rezervasyonIslemleri.MusteriID = int.Parse(MusteriId);
                rezervasyonIslemleri.RezervasyonKayit();
                MessageBox.Show("Giriş Tarihi: '" + dateTimeGiris.Value.ToShortDateString() + "'\nÇıkış Trihi: '" + dateTimeCikis.Value.ToShortDateString() + "'\nOdenecek Tutar: " + odenecekTutar, "REZERVASYON YAPILMIŞTIR", MessageBoxButtons.OK);
            }

            MessageBox.Show("Giriş Tarihi: '" + dateTimeGiris.Value.ToShortDateString() + "'\nÇıkış Trihi: '" + dateTimeCikis.Value.ToShortDateString() + "'\nOdenecek Tutar: " + odenecekTutar, "REZERVASYON YAPILMIŞTIR", MessageBoxButtons.OK);
            return 0;
        }

        public int RezervasyonUcretGoster()
        {
            odenecekTutar = tabanFiyat *  aralik;

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
