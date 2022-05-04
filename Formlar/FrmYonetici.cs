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

        public void RezervasyonGetir()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select R.RezerveID,M.AdiSoyadi,R.GirisTarihi,R.CikisTarihi,T.RezervasyonTip,R.Ucret,M.ID  from Tbl_Rezervasyonlar R inner join Tbl_Musteriler M on R.MusteriID = M.ID inner join Tbl_RezervasyonTip T on R.RezervasyonTipID =T.ID", bgl.baglanti());
            da.Fill(dt1);
            dgvw_Rezervasyonlar.DataSource = dt1;
            dgvw_Rezervasyonlar.Columns[0].Visible = false;
            dgvw_Rezervasyonlar.Columns[6].Visible = false;
        }

        public void OdaGetir()
        {
            SqlCommand Com2 = new SqlCommand("select o.No from Tbl_Odalar O where Doluluk = 0", bgl.baglanti());
            SqlDataReader Dr1 = Com2.ExecuteReader();
            while (Dr1.Read())
            {
                cmbx_OdaNo.Items.Add(Dr1[0]);
            }
        }
        private void FrmYonetici_Load(object sender, EventArgs e)
        {
            RezervasyonGetir();
            OdaGetir();
        }

        private void dgvw_Rezervasyonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvw_Rezervasyonlar.SelectedCells[0].RowIndex;
            lbl_Adsoyad.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[1].Value.ToString();
            lbl_GirisTarih.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[2].Value.ToString();
            lbl_CikisTarih.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[3].Value.ToString();
            lbl_Rezervasyon.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[4].Value.ToString();
            lbl_Ucret.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[5].Value.ToString();
            lbl_MusteriID.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btn_RezervasyonOnayla_Click(object sender, EventArgs e)
        {
            RezervasyonIslemleri rezervasyonIslemleri = new RezervasyonIslemleri();
            rezervasyonIslemleri.OdaNO = int.Parse(cmbx_OdaNo.Text);
            rezervasyonIslemleri.MusteriID = int.Parse(lbl_MusteriID.Text);
            rezervasyonIslemleri.RezervasyonOnayla();
            cmbx_OdaNo.Items.Clear();
            RezervasyonGetir();
            OdaGetir();
        }
    }
}
