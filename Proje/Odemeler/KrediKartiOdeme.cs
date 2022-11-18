using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelOasis
{
    class KrediKartiOdeme : IOdemeYontem
    {
        public int aralik { get; set; }
        public string musteriId { get; set; }
        public string giris { get; set; }
        public string cikis { get; set; }

        public string rezervasyonakackaldi { get; set; }
        public KrediKartiOdeme(int aralik, string Giris, string Cikis, string MusteriID,string RezervasyonaKacKaldi)
        {
            this.aralik = aralik;
            this.giris = Giris;
            this.cikis = Cikis;
            this.musteriId = MusteriID;
            this.rezervasyonakackaldi = RezervasyonaKacKaldi;
        }

        public void OdemeEkranGetir()
        {
            FrmOdeme frmOdeme = new FrmOdeme();
            frmOdeme.MusteriID = musteriId;
            frmOdeme.aralik = aralik;
            frmOdeme.Giris = giris;
            frmOdeme.Cikis = cikis;
            frmOdeme.RezervasyonaKacKaldi = double.Parse(rezervasyonakackaldi.ToString());
            frmOdeme.Show();
            
        }
        public int OnOdemeliOdemeYap()
        {
            OdemeEkranGetir();
            return 0;
        }

        public int _60GunOnceOdemeYap()
        {
            Frm60GunOnceOdeme frm60GunOnceOdeme = new Frm60GunOnceOdeme();
            frm60GunOnceOdeme.MusteriID = musteriId;
            frm60GunOnceOdeme.aralik = aralik;
            frm60GunOnceOdeme.Giris = giris;
            frm60GunOnceOdeme.Cikis = cikis;
            frm60GunOnceOdeme.RezervasyonaKacKaldi = double.Parse(rezervasyonakackaldi.ToString());
            frm60GunOnceOdeme.Show();
            return 0;
        }

        public int StandarOdemeYap()
        {
            OdemeEkranGetir();
            return 0;
        }
        public int _60GunOnceKartKaydet()
        {
            OdemeEkranGetir();
            return 0;
        }
    }
}
