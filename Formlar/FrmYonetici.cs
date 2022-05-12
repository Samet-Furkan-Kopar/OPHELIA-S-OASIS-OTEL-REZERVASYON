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
            // TODO: This line of code loads data into the 'oasis_dbDataSet6.BasıldıgıGunBeklenenGelir' table. You can move, or remove it, as needed.
            this.basıldıgıGunBeklenenGelirTableAdapter.Fill(this.oasis_dbDataSet6.BasıldıgıGunBeklenenGelir);
            grpbx1.Visible = false;
            grpbx2.Visible = false;
            grpbx3.Visible = false;
            // TODO: This line of code loads data into the 'oasis_dbDataSet5.TesvikRapor' table. You can move, or remove it, as needed.
            this.tesvikRaporTableAdapter.Fill(this.oasis_dbDataSet5.TesvikRapor);
            // TODO: This line of code loads data into the 'oasis_dbDataSet1.RezervasyonTipDoluOdaSayisi' table. You can move, or remove it, as needed.
            this.rezervasyonTipDoluOdaSayisiTableAdapter.Fill(this.oasis_dbDataSet1.RezervasyonTipDoluOdaSayisi);
            // TODO: This line of code loads data into the 'Oasis_dbDataSet._30GünlükDolulukBilgi' table. You can move, or remove it, as needed.
            this._30GünlükDolulukBilgiTableAdapter.Fill(this.Oasis_dbDataSet._30GünlükDolulukBilgi);
            this.rpvw_30GünlükDolulukBilgi.RefreshReport();

            SqlCommand Com2 = new SqlCommand("DolulukOrani", bgl.baglanti());
            SqlDataReader Dr1 = Com2.ExecuteReader();
            while (Dr1.Read())
            {
                lblDolulukOran.Text = "%" + Dr1[0];
            }

            SqlCommand Com3 = new SqlCommand("GerceklesenZarar", bgl.baglanti());
            SqlDataReader Dr2 = Com3.ExecuteReader();
            while (Dr2.Read())
            {
                lbl_AylikZarar.Text = Dr2[0] + " TL";
            }
            SqlCommand Com4 = new SqlCommand("Toplam_OrtalamaGelir", bgl.baglanti());
            SqlDataReader Dr3 = Com4.ExecuteReader();
            while (Dr3.Read())
            {
                lbl_ToplamGelir.Text = Dr3[0] + " TL";
                lbl_OrtalamaGelir.Text = Dr3[1] + " TL";
            }

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

        private void btn_BeklenenDoluluk_Click_1(object sender, EventArgs e)
        {
            grpbx1.Visible = true;
            grpbx2.Visible = false;
            grpbx3.Visible = false;
        }

        private void btn_BeklenenOdaGelirRapor_Click(object sender, EventArgs e)
        {
            grpbx1.Visible = false;
            grpbx2.Visible = true;
            grpbx3.Visible = false;
        }

        private void btn_TeşvikRapor_Click(object sender, EventArgs e)
        {
            grpbx1.Visible = false;
            grpbx2.Visible = false;
            grpbx3.Visible = true;
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

        private void btn_BeklenenDoluluk_MouseHover(object sender, EventArgs e)
        {
            btn_BeklenenDoluluk.ForeColor = Color.Goldenrod;
        }

        private void btn_BeklenenDoluluk_MouseLeave(object sender, EventArgs e)
        {
            btn_BeklenenDoluluk.ForeColor = Color.White;

        }

        private void btn_BeklenenOdaGelirRapor_MouseHover(object sender, EventArgs e)
        {
            btn_BeklenenOdaGelirRapor.ForeColor = Color.Goldenrod;
        }

        private void btn_BeklenenOdaGelirRapor_MouseLeave(object sender, EventArgs e)
        {
            btn_BeklenenOdaGelirRapor.ForeColor = Color.White;
        }

        private void btn_TeşvikRapor_MouseHover(object sender, EventArgs e)
        {
            btn_TeşvikRapor.ForeColor = Color.Goldenrod;
        }

        private void btn_TeşvikRapor_MouseLeave(object sender, EventArgs e)
        {
            btn_TeşvikRapor.ForeColor = Color.White;
        }

        private void btn_TabanFiyatGuncelle_MouseHover(object sender, EventArgs e)
        {
            btn_TabanFiyatGuncelle.ForeColor = Color.Goldenrod;
        }

        private void btn_TabanFiyatGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btn_TabanFiyatGuncelle.ForeColor = Color.White;
        }

        private void btn_VeritabanıYedekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("BACKUP DATABASE Oasis_db TO DISK='D:\\Oasis_db_Yedek.bak'", bgl.baglanti());
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Veri Tabanı Yedeklenmiştir.");
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
