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
        Sql bgl = new Sql();
        public string KullaniciAd { get; set; }
        public string AdSoyad { get; set; }


        public FrmRezervasyon()
        {
            InitializeComponent();
        }

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

        private void FrmRezervasyon_Load(object sender, EventArgs e)
        {
            AdSoyadGetir();
            lbl_adSoyad.Text = AdSoyad;
        }

        private void btn_RezervasyonYap_MouseHover(object sender, EventArgs e)
        {
            btn_RezervasyonYap.ForeColor = Color.Green;
        }

        private void btn_RezervasyonYap_MouseLeave(object sender, EventArgs e)
        {
            btn_RezervasyonYap.ForeColor = Color.White;
        }

        private void pcrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcrBack_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris frmMusteriGiris = new FrmMusteriGiris();
            frmMusteriGiris.Show();
            this.Hide();
        }

        private void btn_Rezervasyonlarım_MouseHover(object sender, EventArgs e)
        {
            btn_Rezervasyonlarım.ForeColor = Color.Goldenrod;
        }

        private void btn_Rezervasyonlarım_MouseLeave(object sender, EventArgs e)
        {
            btn_Rezervasyonlarım.ForeColor = Color.White;
        }

        private void btn_Rezervasyonlarım_Click(object sender, EventArgs e)
        {
            //TimeSpan farkgun = new TimeSpan();
            //DateTime dt_Baslama_Tarih = Convert.ToDateTime(dateTimeGiris.Value);
            //DateTime dt_Bitis_Tarih = Convert.ToDateTime(dateTimeCikis.Value);
            //DateTime dateNow = DateTime.Now;
            //TimeSpan Simdi = TimeSpan.FromDays(dateNow.Day);
            //TimeSpan time1 = TimeSpan.FromDays(dt_Baslama_Tarih.Month());
            //TimeSpan time2 = TimeSpan.FromDays(dt_Bitis_Tarih.Day);
            //farkgun = time1-Simdi;
            //MessageBox.Show(farkgun.ToString());

            TimeSpan RezervasyonAraligi,Aralik;
            RezervasyonAraligi = DateTime.Parse(dateTimeCikis.Text) - DateTime.Parse(dateTimeGiris.Text);
            Aralik = DateTime.Parse(dateTimeGiris.Text) -DateTime.Parse(DateTime.Now.ToString());
            lblKalinanGun.Text = RezervasyonAraligi.TotalDays.ToString();
            lblAralik.Text = Aralik.TotalDays.ToString();

        }

        private void btn_RezervasyonYap_Click(object sender, EventArgs e)
        {

          

        }
    }
}
