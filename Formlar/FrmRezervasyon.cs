using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotelOasis
{
    public partial class FrmRezervasyon : Form
    {

        public FrmRezervasyon()
        {
            InitializeComponent();
        }

        Sql bgl = new Sql();
        public string KullaniciAd { get; set; }
        public string AdSoyad { get; set; }
        public int aralik { get; set; }
        public double Ucret { get; set; }
        public int MusteriID { get; set; }
        public string Giris { get; set; }
        public string Cikis { get; set; }

        public void AdSoyadGetir()
        {
            SqlCommand Com1 = new SqlCommand("select ID,AdiSoyadi from Tbl_Musteriler where Kullanici_Adi ='" + KullaniciAd + "'", bgl.baglanti());
            SqlDataReader Dr1 = Com1.ExecuteReader();
            while (Dr1.Read())
            {
                lblMusteriID.Text = Dr1[0].ToString();
                AdSoyad = Dr1[1].ToString();
            }
        }
        public void TarihIslemleri()
        {
            TimeSpan RezervasyonAraligi, RezervasyonKacGunKaldi;
            RezervasyonAraligi = DateTime.Parse(dateTimeCikis.Text) - DateTime.Parse(dateTimeGiris.Text);
            RezervasyonKacGunKaldi = DateTime.Parse(dateTimeGiris.Text) - DateTime.Parse(DateTime.Now.ToString());
            lblKalinanGun.Text = RezervasyonAraligi.TotalDays.ToString();
            lblRezervasyonKacGunKaldi.Text = RezervasyonKacGunKaldi.TotalDays.ToString();
            Giris = dateTimeGiris.Value.ToString("yyyy-MM-dd");
            Cikis = dateTimeCikis.Value.ToString("yyyy-MM-dd");
        }
        public void Odeme_Yaptir()
        {
            FrmOdeme frmOdeme = new FrmOdeme();
            frmOdeme.Show();
            this.Hide();
        }


        private void btn_Rezervasyonlarım_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRezervasyonlarım frmRezervasyonlarım = new FrmRezervasyonlarım();
                frmRezervasyonlarım.MusteriID = int.Parse(lblMusteriID.Text);
                frmRezervasyonlarım.Show();
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Tekrar Giriş Yapınız.!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                FrmMusteriGiris frmMusteriGiris = new FrmMusteriGiris();
                frmMusteriGiris.Show();
                this.Hide();
            }
        }

        private void btn_RezervasyonYap_Click(object sender, EventArgs e)
        {
            TarihIslemleri();
            aralik = int.Parse(lblKalinanGun.Text);
            double RezervasyonaKalanGun = double.Parse(lblRezervasyonKacGunKaldi.Text);

            if (RezervasyonaKalanGun >= 90)
            {
                OdemeSistemi odemeSistemi = new OdemeSistemi(new KrediKartiOdeme(aralik, Giris, Cikis,lblMusteriID.Text,lblRezervasyonKacGunKaldi.Text));
                odemeSistemi.OnOdemeliOdemeYap();
            }
            else if ((RezervasyonaKalanGun >= 60) && (RezervasyonaKalanGun <= 90))
            {
                OdemeSistemi odemeSistemi = new OdemeSistemi(new KrediKartiOdeme(aralik, Giris, Cikis, lblMusteriID.Text, lblRezervasyonKacGunKaldi.Text));
                odemeSistemi._60GunOnceKartKaydet();
            }
            else if (RezervasyonaKalanGun <= 60)
            {
                OdemeSistemi odemeSistemi = new OdemeSistemi(new KrediKartiOdeme(aralik, Giris, Cikis, lblMusteriID.Text, lblRezervasyonKacGunKaldi.Text));
                odemeSistemi.StandarOdemeYap();
            }

        }

        private void btn_UcretHesapla_Click(object sender, EventArgs e)
        {
            TarihIslemleri();
            aralik = int.Parse(lblKalinanGun.Text);
            double RezervasyonaKalanGun = double.Parse(lblRezervasyonKacGunKaldi.Text);
            if (RezervasyonaKalanGun >= 90)
            {
                RezervasyonSistemi rezervasyonSistemi = new RezervasyonSistemi(new OnOdemeliRez(aralik, Giris, Cikis, lblMusteriID.Text));
                rezervasyonSistemi.RezervasyonUcretGoster();

            }
            else if ((RezervasyonaKalanGun >= 60) && (RezervasyonaKalanGun <= 90))
            {
                RezervasyonSistemi rezervasyonSistemi = new RezervasyonSistemi(new _60GunOnceRez(aralik, Giris, Cikis, lblMusteriID.Text));
                rezervasyonSistemi.RezervasyonUcretGoster();
            }
            else if (RezervasyonaKalanGun <= 60)
            {
                RezervasyonSistemi rezervasyonSistemi = new RezervasyonSistemi(new StandartRez(aralik, Giris, Cikis, lblMusteriID.Text));
                rezervasyonSistemi.RezervasyonUcretGoster();
            }
        }

        private void FrmRezervasyon_Load(object sender, EventArgs e)
        {
            AdSoyadGetir();
            lbl_adSoyad.Text = AdSoyad;
            lbl_MusteriID2.Text = MusteriID.ToString();
        }



        private void btn_RezervasyonYap_MouseHover(object sender, EventArgs e)
        {
            btn_RezervasyonYap.ForeColor = Color.Green;
        }

        private void btn_RezervasyonYap_MouseLeave(object sender, EventArgs e)
        {
            btn_RezervasyonYap.ForeColor = Color.White;
        }

        private void btn_Rezervasyonlarım_MouseHover(object sender, EventArgs e)
        {
            btn_Rezervasyonlarım.ForeColor = Color.Goldenrod;
        }

        private void btn_Rezervasyonlarım_MouseLeave(object sender, EventArgs e)
        {
            btn_Rezervasyonlarım.ForeColor = Color.White;
        }

        private void btn_UcretHesapla_MouseHover(object sender, EventArgs e)
        {
            btn_UcretHesapla.ForeColor = Color.Salmon;
        }

        private void btn_UcretHesapla_MouseLeave(object sender, EventArgs e)
        {
            btn_UcretHesapla.ForeColor = Color.White;
        }



        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcr_Back_Click(object sender, EventArgs e)
        {
            FrmGirisler frmGirisler = new FrmGirisler();
            frmGirisler.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
