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
        public int KalanGun { get; set; }
        public double OdenenUcret { get; set; }
        public string Giris { get; set; }
        public string Cikis { get; set; }
        public string RezervasyonaKalanGun { get; set; }

        public void RezervasyonlarimiGetir()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select R.RezerveID,R.GirisTarihi as 'Giriş Tarihi', R.CikisTarihi as 'Çıkış Tarihi',r.Ucret as 'Ödenen Ücret',t.RezervasyonTip as 'Rezervasyon Tipi' from Tbl_Rezervasyonlar R inner join Tbl_RezervasyonTip T on T.ID = R.RezervasyonTipID where MusteriID = '" + MusteriID + "'", bgl.baglanti());
            da.Fill(dt1);
            dgvw_Rezervasyonlarım.DataSource = dt1;
            dgvw_Rezervasyonlarım.Columns[0].Visible = false;
            lbl_MusteriID.Text = MusteriID.ToString();
        }

        private void FrmRezervasyonlarım_Load(object sender, EventArgs e)
        {
            btn_Odeme.Visible = false;
            RezervasyonlarimiGetir();
        }

        private void dgvw_Rezervasyonlarım_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvw_Rezervasyonlarım.SelectedCells[0].RowIndex;
            lbl_RezervasyonID.Text = dgvw_Rezervasyonlarım.Rows[secilen].Cells[0].Value.ToString();
            dateTimeGiris.Text = dgvw_Rezervasyonlarım.Rows[secilen].Cells[1].Value.ToString();
            dateTimeCikis.Text = dgvw_Rezervasyonlarım.Rows[secilen].Cells[2].Value.ToString();
            OdenenUcret = double.Parse(dgvw_Rezervasyonlarım.Rows[secilen].Cells[3].Value.ToString());
            OdemeTipi = dgvw_Rezervasyonlarım.Rows[secilen].Cells[4].Value.ToString();

            SqlCommand Com2 = new SqlCommand("select DATEDIFF(Day,GETDATE(),GirisTarihi) as 'Kalan Gün' from Tbl_Rezervasyonlar where  RezerveID = @RezerveId", bgl.baglanti());
            Com2.Parameters.AddWithValue("@rezerveId", lbl_RezervasyonID.Text);
            SqlDataReader Dr1 = Com2.ExecuteReader();
            while (Dr1.Read())
            {
                KalanGun = (int)Dr1[0];
            }

            if (OdemeTipi == "60 Gün Önceden" || OdemeTipi == "Teşvikli 60 Gün Önceden")
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
            TimeSpan RezervasyonAraligi, RezervasyonKacGunKaldi;
            RezervasyonAraligi = DateTime.Parse(dateTimeCikis.Text) - DateTime.Parse(dateTimeGiris.Text);
            RezervasyonKacGunKaldi = DateTime.Parse(dateTimeGiris.Text) - DateTime.Parse(DateTime.Now.ToString());
            RezervasyonaKalanGun = RezervasyonKacGunKaldi.TotalDays.ToString();
            int Rezervasyonaraligi = int.Parse(RezervasyonAraligi.TotalDays.ToString());

            OdemeSistemi odemeSistemi = new OdemeSistemi(new KrediKartiOdeme(Rezervasyonaraligi, Giris, Cikis, lbl_MusteriID.Text, RezervasyonaKalanGun));
            odemeSistemi._60GunOnceOdemeYap();
        }

        private void btn_Guncelle_MouseHover(object sender, EventArgs e)
        {
            btn_Guncelle.ForeColor = Color.Yellow;
        }

        private void btn_Guncelle_MouseLeave(object sender, EventArgs e)
        {
            btn_Guncelle.ForeColor = Color.White;
        }

        private void btn_İptal_MouseHover(object sender, EventArgs e)
        {
            btn_İptal.ForeColor = Color.Red;
        }

        private void btn_İptal_MouseLeave(object sender, EventArgs e)
        {
            btn_İptal.ForeColor = Color.White;
        }

        private void btn_Odeme_MouseHover(object sender, EventArgs e)
        {
            btn_Odeme.ForeColor = Color.Green;
        }

        private void btn_Odeme_MouseLeave(object sender, EventArgs e)
        {
            btn_Odeme.ForeColor = Color.White;
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcr_Back_Click(object sender, EventArgs e)
        {

                SqlCommand Com1 = new SqlCommand("select AdiSoyadi from Tbl_Musteriler where ID ='" + MusteriID + "'", bgl.baglanti());
                SqlDataReader Dr1 = Com1.ExecuteReader();
                while (Dr1.Read())
                {
                    FrmRezervasyon frmRezervasyon = new FrmRezervasyon();
                    frmRezervasyon.AdSoyad = Dr1[0].ToString();
                    frmRezervasyon.MusteriID = MusteriID;
                    frmRezervasyon.Show();
                    this.Hide();
                }
        }

        private void btn_İptal_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("delete from Tbl_Rezervasyonlar where RezerveID =@rezerveId", bgl.baglanti());
            com.Parameters.AddWithValue("@rezerveId", lbl_RezervasyonID.Text);
            com.ExecuteNonQuery();
            bgl.baglanti().Close();

            RezervasyonlarimiGetir();

            if ((OdemeTipi == "Standart" || OdemeTipi =="Teşvikli Standart" || OdemeTipi == "Teşvikli Ön Ödemeli" || OdemeTipi == "Teşvikli 60 Gün Önceden") && (KalanGun <= 3) )
            {
                MessageBox.Show("Kartınızdan Cezai İşlem Uygulandı.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            TimeSpan RezervasyonAraligi;
            RezervasyonAraligi = DateTime.Parse(dateTimeCikis.Text) - DateTime.Parse(dateTimeGiris.Text);

            RezervasyonIslemleri rezervasyonIslemleri = new RezervasyonIslemleri();
            rezervasyonIslemleri.RezervasyonID = int.Parse(lbl_RezervasyonID.Text);
            rezervasyonIslemleri.GirisTarihi = dateTimeGiris.Value.ToString("yyyy-MM-dd");
            rezervasyonIslemleri.CikisTarihi = dateTimeCikis.Value.ToString("yyyy-MM-dd");
            rezervasyonIslemleri.Aralik = int.Parse(RezervasyonAraligi.TotalDays.ToString());
            rezervasyonIslemleri.RezervasyonGuncelleme();
            RezervasyonlarimiGetir();
        }
    }
}
