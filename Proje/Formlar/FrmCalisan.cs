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
using System.Net.Mail;

namespace hotelOasis
{
    public partial class FrmCalisan : Form
    {
        public FrmCalisan()
        {
            InitializeComponent();
        }

        Sql bgl = new Sql();

        public void Temizlik()
        {
            lbl_Adsoyad.Text = "--------";
            dateTimePickerGiris.Text = "";
            dateTimePickerCikis.Text = "";
            lbl_RezervasyonTip.Text = "--------";
            lbl_Ucret.Text = "--------";
            txt_OdaNo.Text = "";
            cmbx_OdaNo.Text = "";
        }
        public void RezervasyonGetir()
        {
            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Rezervasyonlar", bgl.baglanti());
            da.Fill(dt);
            dgvw_Rezervasyonlar.DataSource = dt;

            dgvw_Rezervasyonlar.Columns[0].Visible = false;
            dgvw_Rezervasyonlar.Columns[1].Visible = false;
            dgvw_Rezervasyonlar.Columns[2].Visible = false;
            dgvw_Rezervasyonlar.Columns[3].Visible = false;
        }
        public void DoluOdalar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("DoluOdalarıGetir", bgl.baglanti());
            da.Fill(dt);
            dgvw_DoluOdalar.DataSource = dt;
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
        public void OdaDoldur()
        {
            RezervasyonIslemleri rezervasyonIslemleri = new RezervasyonIslemleri();
            rezervasyonIslemleri.GirisTarihi = dateTimePickerGiris.Value.ToString("yyyy-MM-dd");
            rezervasyonIslemleri.CikisTarihi = dateTimePickerCikis.Value.ToString("yyyy-MM-dd");
            rezervasyonIslemleri.MusteriID = int.Parse(lbl_MusteriID.Text);
            rezervasyonIslemleri.RezervasyonTipID = int.Parse(lbl_RezervasyonTipID.Text);
            rezervasyonIslemleri.OdaNO = int.Parse(cmbx_OdaNo.Text);
            rezervasyonIslemleri.Ucret = double.Parse(lbl_Ucret.Text);
            rezervasyonIslemleri.OdemeTarihi = OdemeTarihi;
            rezervasyonIslemleri.OdaDoldur();
        }


        public void RezervasyonTipliOdaBosalt()
        {
            MessageBox.Show("Lütfen Ödemeyi Almayı Unutmayınız.", "Bilgilendirme.!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            try
            {
                RezervasyonIslemleri rezervasyonIslemleri = new RezervasyonIslemleri();
                rezervasyonIslemleri.OdaNO = int.Parse(txt_OdaNo.Text);
                rezervasyonIslemleri.OdaBosalt();
                Temizlik();
                DoluOdalar();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Oda No'yu Yan Tarafa Giriniz.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void RezervasyonBitir()
        {
            RezervasyonIslemleri rezervasyonIslemleri = new RezervasyonIslemleri();
            rezervasyonIslemleri.RezervasyonID = int.Parse(lbl_RezervasyonID.Text);
            rezervasyonIslemleri.RezervasyonBitir();
        }


        private void FrmCalisan_Load(object sender, EventArgs e)
        {

            dgvw_DoluOdalar.Visible = false;
            btn_EpostaGonder.Visible = false;
            label7.Visible = false;
            txt_OdaNo.Visible = false;
            RezervasyonGetir();
            OdaGetir();
        }


        private void btn_RezervasyonTalebi_Click(object sender, EventArgs e)
        {

            dgvw_DoluOdalar.Visible = false;
            dgvw_Rezervasyonlar.Visible = true;
            label5.Visible = true;
            lbl_Ucret.Visible = true;
            label7.Visible = false;
            txt_OdaNo.Visible = false;
            RezervasyonGetir();
        }
        private void btn_RezervasyonOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = dgvw_Rezervasyonlar.SelectedCells[0].RowIndex;
                RezervasyonIslemleri rezervasyonIslemleri = new RezervasyonIslemleri();
                rezervasyonIslemleri.OdaNO = int.Parse(cmbx_OdaNo.Text);
                rezervasyonIslemleri.MusteriID = int.Parse(lbl_MusteriID.Text);
                rezervasyonIslemleri.RezervasyonID = int.Parse(lbl_RezervasyonID.Text);
                rezervasyonIslemleri.RezervasyonOnayla();
                OdaDoldur();
                RezervasyonBitir();
                RezervasyonGetir();
                Temizlik();
                cmbx_OdaNo.Items.Clear();
                OdaGetir();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Boş Odalardan Birini Seçiniz.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void btn_DoluOdalar_Click(object sender, EventArgs e)
        {
            dgvw_DoluOdalar.Visible = true;
            label7.Visible = true;
            txt_OdaNo.Visible = true;
            dgvw_Rezervasyonlar.Visible = false;
            label5.Visible = false;
            lbl_Ucret.Visible = false;
            DoluOdalar();
            dgvw_DoluOdalar.Columns[0].Visible = false;
            cmbx_OdaNo.Items.Clear();
            OdaGetir();
        }
        private void btn_OdaBosalt_Click(object sender, EventArgs e)
        {
            FrmFatura frmFatura = new FrmFatura();
            frmFatura.MusteriID = int.Parse(lbl_MusteriID.Text);
            frmFatura.Show();
            if (lbl_RezervasyonTip.Text == "Standart")
            {
                RezervasyonTipliOdaBosalt();
            }
            else if (lbl_RezervasyonTip.Text == "Teşvikli Standart")
            {
                RezervasyonTipliOdaBosalt();
            }
            else if (lbl_RezervasyonTip.Text == "Teşvikli 60 Gün Önceden")
            {
                RezervasyonTipliOdaBosalt();
            }
            else if (lbl_RezervasyonTip.Text == "Teşvikli Ön Ödemeli")
            {
                RezervasyonTipliOdaBosalt();
            }
        }

        public string OdemeTarihi { get; set; }
        private void dgvw_Rezervasyonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvw_Rezervasyonlar.SelectedCells[0].RowIndex;
            Eposta = dgvw_Rezervasyonlar.Rows[secilen].Cells[0].Value.ToString();
            lbl_RezervasyonTipID.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[1].Value.ToString();
            lbl_RezervasyonID.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[2].Value.ToString();
            lbl_MusteriID.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[3].Value.ToString();
            lbl_Adsoyad.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[4].Value.ToString();
            dateTimePickerGiris.Value = (DateTime)dgvw_Rezervasyonlar.Rows[secilen].Cells[5].Value;
            dateTimePickerCikis.Value = (DateTime)dgvw_Rezervasyonlar.Rows[secilen].Cells[6].Value;
            lbl_RezervasyonTip.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[7].Value.ToString();
            lbl_Ucret.Text = dgvw_Rezervasyonlar.Rows[secilen].Cells[8].Value.ToString();
            OdemeTarihi = dgvw_Rezervasyonlar.Rows[secilen].Cells[9].Value.ToString();

            if (lbl_RezervasyonTip.Text == "60 Gün Önceden" || lbl_RezervasyonTip.Text == "Teşvikli 60 Gün Önceden")
            {
                btn_EpostaGonder.Visible = true;
            }
            else
            {
                btn_EpostaGonder.Visible = false;
            }
        }

        public string Eposta { get; set; }
        private void dgvw_DoluOdalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvw_DoluOdalar.SelectedCells[0].RowIndex;
            lbl_MusteriID.Text = dgvw_DoluOdalar.Rows[secilen].Cells[0].Value.ToString();
            lbl_Adsoyad.Text = dgvw_DoluOdalar.Rows[secilen].Cells[1].Value.ToString();
            dateTimePickerGiris.Value = (DateTime)dgvw_DoluOdalar.Rows[secilen].Cells[2].Value;
            dateTimePickerCikis.Value = (DateTime)dgvw_DoluOdalar.Rows[secilen].Cells[3].Value;
            txt_OdaNo.Text = dgvw_DoluOdalar.Rows[secilen].Cells[4].Value.ToString();
            lbl_RezervasyonTip.Text = dgvw_DoluOdalar.Rows[secilen].Cells[5].Value.ToString();
        }


        private void pcrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcrBack_Click(object sender, EventArgs e)
        {
            FrmGirisler frmGirisler = new FrmGirisler();
            frmGirisler.Show();
            this.Hide();
        }

        private void btn_RaporlarıGoster_Click(object sender, EventArgs e)
        {
            FrmCalisanRapor frmCalisanRapor = new FrmCalisanRapor();
            frmCalisanRapor.Show();
            this.Hide();
        }

        private void btn_EpostaGonder_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                MailMessage eMail = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("4seen.cs@gmail.com", "4seen.cs321");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                eMail.To.Add(Eposta);
                eMail.From = new MailAddress("4seen.cs@gmail.com");
                eMail.Subject = "ÖDEME HATIRLATMA";
                eMail.Body = $"Lütfen Ödemenizi 15 Gün İçerisinde Tamamlayınız.\n\n --->ÖDEME YAPTIYSANIZ BU MAİLİ DİKKATE ALMAYINIZ.!";
                smtp.Send(eMail);
                MessageBox.Show("Mail Gönderilmiştir.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Mail Bilgisi Hatalı.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
