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
    public partial class FrmYetkiliGiris : Form
    {
        public FrmYetkiliGiris()
        {
            InitializeComponent();
        }
        Sql sql = new Sql();

        private void btn_Giris_Click(object sender, EventArgs e)
        {
              Yetkiliİslemleri yetkiliİslemleri = new Yetkiliİslemleri();
              yetkiliİslemleri.KullaniciAdi = txt_kullaniciAd.Text;
              yetkiliİslemleri.Sifre = txt_sifre.Text;
              yetkiliİslemleri.Yetki = cmb_Yetki.Text;
              yetkiliİslemleri.Giris();
              this.Hide();
        }

        private void btn_Giris_MouseHover(object sender, EventArgs e)
        {
            btn_Giris.ForeColor = Color.Green;
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
