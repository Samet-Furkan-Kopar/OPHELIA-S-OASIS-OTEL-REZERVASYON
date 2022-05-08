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
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }

        Sql bgl = new Sql();
        public int TabanFiyat { get; set; }
        public void TabanFiyatGetir()
        {
            SqlCommand Com2 = new SqlCommand("select TabanFiyat from Tbl_Fiyat", bgl.baglanti());
            SqlDataReader Dr1 = Com2.ExecuteReader();
            while (Dr1.Read())
            {
                TabanFiyat = (int)Dr1[0];
                txt_TabanFiyat.Text = TabanFiyat.ToString();
            }
        }

        public void TabanFiyatGuncelle()
        {
            SqlCommand Com = new SqlCommand("update Tbl_Fiyat set TabanFiyat=@TabanFiyat where ID=1", bgl.baglanti());
            Com.Parameters.AddWithValue("@TabanFiyat", txt_TabanFiyat.Text);
            Com.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Taban Fiyatı Güncellendi.!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmYonetici_Load(object sender, EventArgs e)
        {
            TabanFiyatGetir();
        }

        private void btn_TabanFiyatGuncelle_Click(object sender, EventArgs e)
        {
            TabanFiyatGuncelle();
            TabanFiyatGetir();
        }

        private void txt_TabanFiyat_TextChanged(object sender, EventArgs e)
        {

            if (txt_TabanFiyat.Text != TabanFiyat.ToString())
            {
                btn_TabanFiyatGuncelle.Enabled = true;
            }
            else
            {
                btn_TabanFiyatGuncelle.Enabled = false;
            }
        }
    }
}
