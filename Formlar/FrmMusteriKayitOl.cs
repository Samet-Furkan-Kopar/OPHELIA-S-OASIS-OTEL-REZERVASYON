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
            Musteriİslemeri musteriİslemeri = new Musteriİslemeri();
            musteriİslemeri.KullaniciAdi = txt_KullaniciAdi.Text;
            musteriİslemeri.Sifre = txt_Sifre.Text;
            musteriİslemeri.Eposta = txt_Eposta.Text;
            musteriİslemeri.AdSoyadi = txt_AdiSoyadi.Text;
            musteriİslemeri.KayıtOl();
            
            
            
            FrmMusteriGiris frmMusteriGiris = new FrmMusteriGiris();
            //frmMusteriGiris.Show();
            this.Hide();
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
