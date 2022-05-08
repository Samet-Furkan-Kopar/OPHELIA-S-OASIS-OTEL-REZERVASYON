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
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }
        public int aralik { get; set; }
        public string MusteriID { get; set; }
        public string Giris { get; set; }
        public string Cikis { get; set; }
        public double RezervasyonaKacKaldi { get; set; }

        Sql bgl = new Sql();

        public void KartKaydet()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_KartBilgileri (MusteriID,KartNo,SonKullanımTarihi,CVV) Values ('" + MusteriID + "','" + msktxt_KartNo.Text + "','" + msktxt_SonKullanim.Text + "','" + msktxt_Cvv.Text + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

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
            if (txt_AdSoyad.Text == "" || msktxt_Cvv.Text == "" || msktxt_SonKullanim.Text == "" || msktxt_KartNo.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (RezervasyonaKacKaldi>=90)
                {
                    RezervasyonSistemi rezervasyonSistemi = new RezervasyonSistemi(new OnOdemeliRez(aralik, Giris, Cikis, MusteriID));
                    rezervasyonSistemi.RezervasyonIslemYap();
                    KartKaydet();
                }
                MessageBox.Show("Ödeme İşlemi Tamamlanmıştır.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            KartBilgileriGetir();
            if ((RezervasyonaKacKaldi >= 60) && (RezervasyonaKacKaldi <= 90) || (RezervasyonaKacKaldi < 60))
            {
                btn_Odeme.Visible = false;
                btn_KartKaydet.Visible = true;
            }
            else if (RezervasyonaKacKaldi >= 90)
            {
                btn_Odeme.Visible = true;
                btn_KartKaydet.Visible = false;
            }
        }

        private void btn_KartKaydet_Click(object sender, EventArgs e)
        {
            
            if (txt_AdSoyad.Text == "" || msktxt_Cvv.Text == "" || msktxt_SonKullanim.Text == "" || msktxt_KartNo.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ((RezervasyonaKacKaldi >= 60) && (RezervasyonaKacKaldi <= 90))
                {
                    RezervasyonSistemi rezervasyonSistemi = new RezervasyonSistemi(new _60GunOnceRez(aralik, Giris, Cikis, MusteriID));
                    rezervasyonSistemi.RezervasyonIslemYap();
                    KartKaydet();
                }
                else if(RezervasyonaKacKaldi<60)
                {
                    RezervasyonSistemi rezervasyonSistemi = new RezervasyonSistemi(new StandartRez(aralik, Giris, Cikis, MusteriID));
                    rezervasyonSistemi.RezervasyonIslemYap();
                    KartKaydet();
                }
                this.Hide();
            }
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
