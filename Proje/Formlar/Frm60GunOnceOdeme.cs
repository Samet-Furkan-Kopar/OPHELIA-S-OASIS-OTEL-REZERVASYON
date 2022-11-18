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
    public partial class Frm60GunOnceOdeme : Form
    {
        public Frm60GunOnceOdeme()
        {
            InitializeComponent();
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int aralik { get; set; }
        public string MusteriID { get; set; }
        public string Giris { get; set; }
        public string Cikis { get; set; }
        public double RezervasyonaKacKaldi { get; set; }
        public string OdemeTarih { get; set; }

        Sql bgl = new Sql();

        public void KartBilgileriGetir()
        {
            SqlCommand Com2 = new SqlCommand("select M.AdiSoyadi,KB.KartNo,KB.CVV,KB.SonKullanımTarihi from Tbl_Musteriler M inner join Tbl_KartBilgileri KB on KB.MusteriID = M.ID where KB.MusteriID = @MusteriID", bgl.baglanti());
            Com2.Parameters.AddWithValue("@MusteriID", int.Parse(MusteriID));
            SqlDataReader Dr1 = Com2.ExecuteReader();
            while (Dr1.Read())
            {
                txt_AdSoyad.Text = Dr1[0].ToString();
                msktxt_KartNo.Text = Dr1[1].ToString();
                msktxt_Cvv.Text = Dr1[2].ToString();
                msktxt_SonKullanim.Text = Dr1[3].ToString();
            }
        }
        private void btn_Odeme_Click(object sender, EventArgs e)
        {
            OdemeTarih = DateTime.Today.ToString("yyyy-MM-dd");
            RezervasyonIslemleri rezervasyonIslemleri = new RezervasyonIslemleri();
            rezervasyonIslemleri.MusteriID = int.Parse(MusteriID);
            rezervasyonIslemleri.OdemeTarihi = OdemeTarih;
            rezervasyonIslemleri._60GunOncedenOdemeYapma();
            MessageBox.Show("Ödeme İşlemi Tamamlanmıştır.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

        }

        private void Frm60GunOnceOdeme_Load(object sender, EventArgs e)
        {
            KartBilgileriGetir();
        }
    }
}
