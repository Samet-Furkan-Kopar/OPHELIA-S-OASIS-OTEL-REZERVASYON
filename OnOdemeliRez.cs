using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelOasis
{
    //.Bu rezervasyon iptal edildiğinde geri ödeme yoktur.Fakat ek bir
    // ücretle rezervasyon günü değiştirilebilir.Bu ek ücret de o anki taban fiyatın %110 udur.

    public class OnOdemeliRez : IRezervasyonTipi
    {
        public int aralik { get; set; }
        double odenecekTutar;
        int tabanFiyat = 100;
        public DateTimePicker dateTimeGiris;
        public DateTimePicker dateTimeCikis;
        public string MusteriId;
        public OnOdemeliRez(int aralik, DateTimePicker dateTimeGiris, DateTimePicker dateTimeCikis,string lblMusteriID)
        {
            this.aralik = aralik;
            this.dateTimeGiris = dateTimeGiris;
            this.dateTimeCikis = dateTimeCikis;
            this.MusteriId = lblMusteriID;
        }

        public int RezervasyonIslemYap()
        {         
            odenecekTutar = tabanFiyat * 0.75 * aralik  ;
            RezervasyonIslemleri rezervasyonIslemleri = new RezervasyonIslemleri();
            rezervasyonIslemleri.GirisTarihi = dateTimeGiris.Value;
            rezervasyonIslemleri.CikisTarihi= dateTimeCikis.Value;
            rezervasyonIslemleri.Ucret = odenecekTutar;
            rezervasyonIslemleri.RezervasyonTipID = 1;
            rezervasyonIslemleri.MusteriID = int.Parse(MusteriId);
            rezervasyonIslemleri.RezervasyonKayit();

            MessageBox.Show("Giriş Tarihi: '" + dateTimeGiris.Value.ToShortDateString() + "'\nÇıkış Trihi: '" + dateTimeCikis.Value.ToShortDateString() + "'\nOdenecek Tutar: " + odenecekTutar , "REZERVASYON YAPILMIŞTIR", MessageBoxButtons.OK);

            return 0;
        }

        public int RezervasyonUcretGoster()
        {
            odenecekTutar = tabanFiyat * 0.75 * aralik;
            MessageBox.Show("Kampanyalı Tutar: '" + odenecekTutar + "'\nRezervasyon Yapmak İçin REZERVASYON YAP Butonuna Tıklayınız.","ÖDENCEK TUTAR",MessageBoxButtons.OK,MessageBoxIcon.Information);
            return 0;
        }
    }
}
