using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelOasis
{
    public partial class FrmMusteriKayitOl : Form
    {
        public FrmMusteriKayitOl()
        {
            InitializeComponent();
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_AdiSoyadi.Text == "" || txt_KullaniciAdi.Text == "" || txt_Sifre.Text == "" || txt_Eposta.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alanları Doldurunuz.!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (txt_Eposta.Text.Contains("@") && txt_Eposta.Text.Contains(".com") && txt_AdiSoyadi.Text != null && txt_KullaniciAdi.Text != null && txt_Sifre.Text != null)
                {
                    Musteriİslemeri musteriİslemeri = new Musteriİslemeri();
                    musteriİslemeri.KullaniciAdi = txt_KullaniciAdi.Text;
                    musteriİslemeri.Sifre = txt_Sifre.Text;
                    musteriİslemeri.Eposta = txt_Eposta.Text;
                    musteriİslemeri.AdSoyadi = txt_AdiSoyadi.Text;
                    musteriİslemeri.KayıtOl();
                    FrmMusteriGiris frmMusteriGiris = new FrmMusteriGiris();
                    frmMusteriGiris.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen E-Posta'nızı Doğru Giriniz.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Boş Alanları Doldurunuz.!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcr_Back_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris frmMusteriGiris = new FrmMusteriGiris();
            frmMusteriGiris.Show();
            this.Hide();
        }

        private void btn_Kayit_MouseHover(object sender, EventArgs e)
        {
            btn_Kayit.ForeColor = Color.Goldenrod;
        }

        private void btn_Kayit_MouseLeave(object sender, EventArgs e)
        {
            btn_Kayit.ForeColor = Color.White;
        }
    }
}
