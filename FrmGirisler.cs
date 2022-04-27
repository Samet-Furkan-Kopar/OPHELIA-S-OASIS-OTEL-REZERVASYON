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
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void btn_Yetkili_Click(object sender, EventArgs e)
        {
            FrmYetkiliGiris frmYetkiliGiris = new FrmYetkiliGiris();
            frmYetkiliGiris.Show();
            this.Hide();
        }

        private void btn_Musteri_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris frmMusteriGiris = new FrmMusteriGiris();
            frmMusteriGiris.Show();
            this.Hide();
        }

        private void btn_Yetkili_MouseHover(object sender, EventArgs e)
        {
            btn_Yetkili.ForeColor = Color.PaleGoldenrod;
        }

        private void btn_Yetkili_MouseLeave(object sender, EventArgs e)
        {
            btn_Yetkili.ForeColor = Color.White;
        }

        private void btn_Musteri_MouseHover(object sender, EventArgs e)
        {
            btn_Musteri.ForeColor = Color.PaleGoldenrod;
        }

        private void btn_Musteri_MouseLeave(object sender, EventArgs e)
        {
            btn_Musteri.ForeColor = Color.White;

        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
