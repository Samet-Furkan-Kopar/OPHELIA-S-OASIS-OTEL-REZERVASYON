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
    public partial class FrmMusteriGiris : Form
    {
        public FrmMusteriGiris()
        {
            InitializeComponent();
        }

        private void lnklbl_kayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMusteriKayitOl frmMusteriKayitOl = new FrmMusteriKayitOl();
            frmMusteriKayitOl.Show();
            this.Hide();

        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            Musteriİslemeri musteriİslemeri = new Musteriİslemeri();

            musteriİslemeri.KullaniciAdi = txt_kullaniciAd.Text;
            musteriİslemeri.Sifre = txt_sifre.Text;
            musteriİslemeri.Giris();
            this.Hide();

        }

        private void btn_Giris_MouseHover(object sender, EventArgs e)
        {
            btn_Giris.ForeColor = Color.Goldenrod;
        }

        private void btn_Giris_MouseLeave(object sender, EventArgs e)
        {
            btn_Giris.ForeColor = Color.White;
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
    }
}
