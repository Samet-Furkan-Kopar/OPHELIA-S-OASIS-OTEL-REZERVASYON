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
    public partial class FrmCalisanRapor : Form
    {
        public FrmCalisanRapor()
        {
            InitializeComponent();
        }

        private void FrmCalisanRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oasis_dbDataSet7.GunlukDolulukOrani' table. You can move, or remove it, as needed.
            this.gunlukDolulukOraniTableAdapter.Fill(this.oasis_dbDataSet7.GunlukDolulukOrani);
            grpbx1.Visible = false;
            grpbx2.Visible = false;

            // TODO: This line of code loads data into the 'Oasis_dbDataSet2.GunlukGelenler' table. You can move, or remove it, as needed.
            this.GunlukGelenlerTableAdapter.Fill(this.Oasis_dbDataSet2.GunlukGelenler);
            this.rpvw_GunlukGelenler.RefreshReport();

            
        }

        private void pcrBack_Click(object sender, EventArgs e)
        {
            FrmCalisan frmCalisan = new FrmCalisan();
            frmCalisan.Show();
            this.Hide();
        }

        private void pcrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_GunlukGelenler_Click(object sender, EventArgs e)
        {
            grpbx1.Visible = true;
            grpbx2.Visible = false;
        }

        private void btn_GunlukDoluluk_Click(object sender, EventArgs e)
        {
            grpbx1.Visible = false;
            grpbx2.Visible = true;
        }

        private void btn_GunlukGelenler_MouseHover(object sender, EventArgs e)
        {
            btn_GunlukGelenler.ForeColor = Color.Goldenrod;
        }

        private void btn_GunlukGelenler_MouseLeave(object sender, EventArgs e)
        {
            btn_GunlukGelenler.ForeColor = Color.White;
        }

        private void btn_GunlukDoluluk_MouseHover(object sender, EventArgs e)
        {
            btn_GunlukDoluluk.ForeColor = Color.Goldenrod;
        }

        private void btn_GunlukDoluluk_MouseLeave(object sender, EventArgs e)
        {
            btn_GunlukDoluluk.ForeColor = Color.Goldenrod;
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcr_Back_Click(object sender, EventArgs e)
        {
            FrmCalisan frmCalisan = new FrmCalisan();
            frmCalisan.Show();
            this.Hide();
        }
    }
}
