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
    public partial class FrmRezervasyonlarım : Form
    {
        public FrmRezervasyonlarım()
        {
            InitializeComponent();
        }

        Sql bgl = new Sql();

        public int MusteriID { get; set; }
        public string OdemeTipi { get; set; }

        private void FrmRezervasyonlarım_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select R.RezerveID,R.GirisTarihi as 'Giriş Tarihi', R.CikisTarihi as 'Çıkış Tarihi',r.Ucret as 'Ödenen Ücret',t.RezervasyonTip as 'Rezervasyon Tipi' from Tbl_Rezervasyonlar R inner join Tbl_RezervasyonTip T on T.ID = R.RezervasyonTipID where MusteriID = '" + MusteriID+"'", bgl.baglanti());
            da.Fill(dt1);
            dgvw_Rezervasyonlarım.DataSource = dt1;
            dgvw_Rezervasyonlarım.Columns[0].Visible = false;

        }

        private void dgvw_Rezervasyonlarım_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvw_Rezervasyonlarım.SelectedCells[0].RowIndex;
            dateTimeGiris.Text = dgvw_Rezervasyonlarım.Rows[secilen].Cells[1].Value.ToString();
            dateTimeCikis.Text = dgvw_Rezervasyonlarım.Rows[secilen].Cells[2].Value.ToString();
            OdemeTipi = dgvw_Rezervasyonlarım.Rows[secilen].Cells[4].Value.ToString();
            if (OdemeTipi == "60 Gün Önceden")
            {
                btn_Odeme.Visible = true;
            }
            else
            {
                btn_Odeme.Visible = false;
            }
        }

        private void btn_Odeme_Click(object sender, EventArgs e)
        {

        }
    }
}
