
namespace hotelOasis
{
    partial class FrmCalisan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalisan));
            this.dgvw_Rezervasyonlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Adsoyad = new System.Windows.Forms.Label();
            this.lbl_RezervasyonTip = new System.Windows.Forms.Label();
            this.lbl_Ucret = new System.Windows.Forms.Label();
            this.btn_RezervasyonOnayla = new System.Windows.Forms.Button();
            this.cmbx_OdaNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_MusteriID = new System.Windows.Forms.Label();
            this.btn_DoluOdalar = new System.Windows.Forms.Button();
            this.btn_RezervasyonTalebi = new System.Windows.Forms.Button();
            this.btn_OdaBosalt = new System.Windows.Forms.Button();
            this.lbl_RezervasyonID = new System.Windows.Forms.Label();
            this.txt_OdaNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvw_DoluOdalar = new System.Windows.Forms.DataGridView();
            this.lbl_RezervasyonTipID = new System.Windows.Forms.Label();
            this.pcrExit = new System.Windows.Forms.PictureBox();
            this.pcrBack = new System.Windows.Forms.PictureBox();
            this.dateTimePickerGiris = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCikis = new System.Windows.Forms.DateTimePicker();
            this.btn_RaporlarıGoster = new System.Windows.Forms.Button();
            this.btn_EpostaGonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_Rezervasyonlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_DoluOdalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvw_Rezervasyonlar
            // 
            this.dgvw_Rezervasyonlar.AllowUserToAddRows = false;
            this.dgvw_Rezervasyonlar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            this.dgvw_Rezervasyonlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvw_Rezervasyonlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvw_Rezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_Rezervasyonlar.GridColor = System.Drawing.Color.DarkSalmon;
            this.dgvw_Rezervasyonlar.Location = new System.Drawing.Point(8, 47);
            this.dgvw_Rezervasyonlar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvw_Rezervasyonlar.Name = "dgvw_Rezervasyonlar";
            this.dgvw_Rezervasyonlar.ReadOnly = true;
            this.dgvw_Rezervasyonlar.RowHeadersWidth = 51;
            this.dgvw_Rezervasyonlar.RowTemplate.Height = 24;
            this.dgvw_Rezervasyonlar.Size = new System.Drawing.Size(730, 222);
            this.dgvw_Rezervasyonlar.TabIndex = 1;
            this.dgvw_Rezervasyonlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvw_Rezervasyonlar_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 367);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rezervasyon Tip:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 403);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ücret:";
            // 
            // lbl_Adsoyad
            // 
            this.lbl_Adsoyad.AutoSize = true;
            this.lbl_Adsoyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Adsoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adsoyad.ForeColor = System.Drawing.Color.White;
            this.lbl_Adsoyad.Location = new System.Drawing.Point(154, 272);
            this.lbl_Adsoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Adsoyad.Name = "lbl_Adsoyad";
            this.lbl_Adsoyad.Size = new System.Drawing.Size(58, 21);
            this.lbl_Adsoyad.TabIndex = 7;
            this.lbl_Adsoyad.Text = "--------";
            // 
            // lbl_RezervasyonTip
            // 
            this.lbl_RezervasyonTip.AutoSize = true;
            this.lbl_RezervasyonTip.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RezervasyonTip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RezervasyonTip.ForeColor = System.Drawing.Color.White;
            this.lbl_RezervasyonTip.Location = new System.Drawing.Point(154, 365);
            this.lbl_RezervasyonTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RezervasyonTip.Name = "lbl_RezervasyonTip";
            this.lbl_RezervasyonTip.Size = new System.Drawing.Size(58, 21);
            this.lbl_RezervasyonTip.TabIndex = 10;
            this.lbl_RezervasyonTip.Text = "--------";
            // 
            // lbl_Ucret
            // 
            this.lbl_Ucret.AutoSize = true;
            this.lbl_Ucret.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ucret.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ucret.ForeColor = System.Drawing.Color.White;
            this.lbl_Ucret.Location = new System.Drawing.Point(154, 398);
            this.lbl_Ucret.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Ucret.Name = "lbl_Ucret";
            this.lbl_Ucret.Size = new System.Drawing.Size(58, 21);
            this.lbl_Ucret.TabIndex = 11;
            this.lbl_Ucret.Text = "--------";
            // 
            // btn_RezervasyonOnayla
            // 
            this.btn_RezervasyonOnayla.BackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonOnayla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RezervasyonOnayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RezervasyonOnayla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonOnayla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RezervasyonOnayla.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_RezervasyonOnayla.ForeColor = System.Drawing.Color.White;
            this.btn_RezervasyonOnayla.Location = new System.Drawing.Point(551, 312);
            this.btn_RezervasyonOnayla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_RezervasyonOnayla.Name = "btn_RezervasyonOnayla";
            this.btn_RezervasyonOnayla.Size = new System.Drawing.Size(188, 36);
            this.btn_RezervasyonOnayla.TabIndex = 2;
            this.btn_RezervasyonOnayla.Text = "Rezervasyon Onayla";
            this.btn_RezervasyonOnayla.UseVisualStyleBackColor = false;
            this.btn_RezervasyonOnayla.Click += new System.EventHandler(this.btn_RezervasyonOnayla_Click);
            // 
            // cmbx_OdaNo
            // 
            this.cmbx_OdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_OdaNo.FormattingEnabled = true;
            this.cmbx_OdaNo.Location = new System.Drawing.Point(461, 273);
            this.cmbx_OdaNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbx_OdaNo.Name = "cmbx_OdaNo";
            this.cmbx_OdaNo.Size = new System.Drawing.Size(84, 25);
            this.cmbx_OdaNo.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(363, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Boş Odalar:";
            // 
            // lbl_MusteriID
            // 
            this.lbl_MusteriID.AutoSize = true;
            this.lbl_MusteriID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MusteriID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_MusteriID.ForeColor = System.Drawing.Color.White;
            this.lbl_MusteriID.Location = new System.Drawing.Point(5, 448);
            this.lbl_MusteriID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MusteriID.Name = "lbl_MusteriID";
            this.lbl_MusteriID.Size = new System.Drawing.Size(51, 20);
            this.lbl_MusteriID.TabIndex = 33;
            this.lbl_MusteriID.Text = "-------";
            this.lbl_MusteriID.Visible = false;
            // 
            // btn_DoluOdalar
            // 
            this.btn_DoluOdalar.BackColor = System.Drawing.Color.Transparent;
            this.btn_DoluOdalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DoluOdalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DoluOdalar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_DoluOdalar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_DoluOdalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoluOdalar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DoluOdalar.ForeColor = System.Drawing.Color.White;
            this.btn_DoluOdalar.Location = new System.Drawing.Point(551, 352);
            this.btn_DoluOdalar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DoluOdalar.Name = "btn_DoluOdalar";
            this.btn_DoluOdalar.Size = new System.Drawing.Size(188, 36);
            this.btn_DoluOdalar.TabIndex = 3;
            this.btn_DoluOdalar.Text = "Dolu Odalar";
            this.btn_DoluOdalar.UseVisualStyleBackColor = false;
            this.btn_DoluOdalar.Click += new System.EventHandler(this.btn_DoluOdalar_Click);
            // 
            // btn_RezervasyonTalebi
            // 
            this.btn_RezervasyonTalebi.BackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonTalebi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RezervasyonTalebi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RezervasyonTalebi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonTalebi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonTalebi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RezervasyonTalebi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_RezervasyonTalebi.ForeColor = System.Drawing.Color.White;
            this.btn_RezervasyonTalebi.Location = new System.Drawing.Point(551, 273);
            this.btn_RezervasyonTalebi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_RezervasyonTalebi.Name = "btn_RezervasyonTalebi";
            this.btn_RezervasyonTalebi.Size = new System.Drawing.Size(188, 36);
            this.btn_RezervasyonTalebi.TabIndex = 1;
            this.btn_RezervasyonTalebi.Text = "Rezervasyon Talepleri";
            this.btn_RezervasyonTalebi.UseVisualStyleBackColor = false;
            this.btn_RezervasyonTalebi.Click += new System.EventHandler(this.btn_RezervasyonTalebi_Click);
            // 
            // btn_OdaBosalt
            // 
            this.btn_OdaBosalt.BackColor = System.Drawing.Color.Transparent;
            this.btn_OdaBosalt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_OdaBosalt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OdaBosalt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_OdaBosalt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_OdaBosalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OdaBosalt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_OdaBosalt.ForeColor = System.Drawing.Color.White;
            this.btn_OdaBosalt.Location = new System.Drawing.Point(551, 392);
            this.btn_OdaBosalt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_OdaBosalt.Name = "btn_OdaBosalt";
            this.btn_OdaBosalt.Size = new System.Drawing.Size(188, 36);
            this.btn_OdaBosalt.TabIndex = 4;
            this.btn_OdaBosalt.Text = "Odayı Boşalt";
            this.btn_OdaBosalt.UseVisualStyleBackColor = false;
            this.btn_OdaBosalt.Click += new System.EventHandler(this.btn_OdaBosalt_Click);
            // 
            // lbl_RezervasyonID
            // 
            this.lbl_RezervasyonID.AutoSize = true;
            this.lbl_RezervasyonID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RezervasyonID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_RezervasyonID.ForeColor = System.Drawing.Color.White;
            this.lbl_RezervasyonID.Location = new System.Drawing.Point(61, 448);
            this.lbl_RezervasyonID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RezervasyonID.Name = "lbl_RezervasyonID";
            this.lbl_RezervasyonID.Size = new System.Drawing.Size(51, 20);
            this.lbl_RezervasyonID.TabIndex = 37;
            this.lbl_RezervasyonID.Text = "-------";
            this.lbl_RezervasyonID.Visible = false;
            // 
            // txt_OdaNo
            // 
            this.txt_OdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_OdaNo.Location = new System.Drawing.Point(461, 401);
            this.txt_OdaNo.Name = "txt_OdaNo";
            this.txt_OdaNo.Size = new System.Drawing.Size(84, 25);
            this.txt_OdaNo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(386, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "Oda No:";
            // 
            // dgvw_DoluOdalar
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            this.dgvw_DoluOdalar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvw_DoluOdalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvw_DoluOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_DoluOdalar.GridColor = System.Drawing.Color.DarkSalmon;
            this.dgvw_DoluOdalar.Location = new System.Drawing.Point(8, 47);
            this.dgvw_DoluOdalar.Name = "dgvw_DoluOdalar";
            this.dgvw_DoluOdalar.RowHeadersWidth = 51;
            this.dgvw_DoluOdalar.Size = new System.Drawing.Size(730, 222);
            this.dgvw_DoluOdalar.TabIndex = 41;
            this.dgvw_DoluOdalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvw_DoluOdalar_CellClick);
            // 
            // lbl_RezervasyonTipID
            // 
            this.lbl_RezervasyonTipID.AutoSize = true;
            this.lbl_RezervasyonTipID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RezervasyonTipID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_RezervasyonTipID.ForeColor = System.Drawing.Color.White;
            this.lbl_RezervasyonTipID.Location = new System.Drawing.Point(120, 448);
            this.lbl_RezervasyonTipID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_RezervasyonTipID.Name = "lbl_RezervasyonTipID";
            this.lbl_RezervasyonTipID.Size = new System.Drawing.Size(57, 20);
            this.lbl_RezervasyonTipID.TabIndex = 37;
            this.lbl_RezervasyonTipID.Text = "--------";
            this.lbl_RezervasyonTipID.Visible = false;
            // 
            // pcrExit
            // 
            this.pcrExit.BackColor = System.Drawing.Color.Transparent;
            this.pcrExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcrExit.BackgroundImage")));
            this.pcrExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcrExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcrExit.Location = new System.Drawing.Point(707, 12);
            this.pcrExit.Name = "pcrExit";
            this.pcrExit.Size = new System.Drawing.Size(32, 21);
            this.pcrExit.TabIndex = 43;
            this.pcrExit.TabStop = false;
            this.pcrExit.Click += new System.EventHandler(this.pcrExit_Click);
            // 
            // pcrBack
            // 
            this.pcrBack.BackColor = System.Drawing.Color.Transparent;
            this.pcrBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcrBack.BackgroundImage")));
            this.pcrBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcrBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcrBack.Location = new System.Drawing.Point(8, 12);
            this.pcrBack.Name = "pcrBack";
            this.pcrBack.Size = new System.Drawing.Size(32, 21);
            this.pcrBack.TabIndex = 42;
            this.pcrBack.TabStop = false;
            this.pcrBack.Click += new System.EventHandler(this.pcrBack_Click);
            // 
            // dateTimePickerGiris
            // 
            this.dateTimePickerGiris.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerGiris.Location = new System.Drawing.Point(154, 299);
            this.dateTimePickerGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerGiris.Name = "dateTimePickerGiris";
            this.dateTimePickerGiris.Size = new System.Drawing.Size(206, 26);
            this.dateTimePickerGiris.TabIndex = 44;
            // 
            // dateTimePickerCikis
            // 
            this.dateTimePickerCikis.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerCikis.Location = new System.Drawing.Point(154, 335);
            this.dateTimePickerCikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerCikis.Name = "dateTimePickerCikis";
            this.dateTimePickerCikis.Size = new System.Drawing.Size(206, 26);
            this.dateTimePickerCikis.TabIndex = 45;
            // 
            // btn_RaporlarıGoster
            // 
            this.btn_RaporlarıGoster.BackColor = System.Drawing.Color.Transparent;
            this.btn_RaporlarıGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RaporlarıGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RaporlarıGoster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_RaporlarıGoster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_RaporlarıGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RaporlarıGoster.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_RaporlarıGoster.ForeColor = System.Drawing.Color.White;
            this.btn_RaporlarıGoster.Location = new System.Drawing.Point(551, 432);
            this.btn_RaporlarıGoster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_RaporlarıGoster.Name = "btn_RaporlarıGoster";
            this.btn_RaporlarıGoster.Size = new System.Drawing.Size(188, 36);
            this.btn_RaporlarıGoster.TabIndex = 5;
            this.btn_RaporlarıGoster.Text = "Raporlar";
            this.btn_RaporlarıGoster.UseVisualStyleBackColor = false;
            this.btn_RaporlarıGoster.Click += new System.EventHandler(this.btn_RaporlarıGoster_Click);
            // 
            // btn_EpostaGonder
            // 
            this.btn_EpostaGonder.BackColor = System.Drawing.Color.Transparent;
            this.btn_EpostaGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EpostaGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EpostaGonder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_EpostaGonder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_EpostaGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EpostaGonder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_EpostaGonder.ForeColor = System.Drawing.Color.White;
            this.btn_EpostaGonder.Location = new System.Drawing.Point(356, 431);
            this.btn_EpostaGonder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_EpostaGonder.Name = "btn_EpostaGonder";
            this.btn_EpostaGonder.Size = new System.Drawing.Size(188, 36);
            this.btn_EpostaGonder.TabIndex = 6;
            this.btn_EpostaGonder.Text = "E-Posta Gönder";
            this.btn_EpostaGonder.UseVisualStyleBackColor = false;
            this.btn_EpostaGonder.Click += new System.EventHandler(this.btn_EpostaGonder_Click);
            // 
            // FrmCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 477);
            this.Controls.Add(this.btn_EpostaGonder);
            this.Controls.Add(this.btn_RaporlarıGoster);
            this.Controls.Add(this.dateTimePickerCikis);
            this.Controls.Add(this.dateTimePickerGiris);
            this.Controls.Add(this.pcrExit);
            this.Controls.Add(this.pcrBack);
            this.Controls.Add(this.lbl_RezervasyonTipID);
            this.Controls.Add(this.dgvw_DoluOdalar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_OdaNo);
            this.Controls.Add(this.lbl_RezervasyonID);
            this.Controls.Add(this.btn_OdaBosalt);
            this.Controls.Add(this.btn_RezervasyonTalebi);
            this.Controls.Add(this.btn_DoluOdalar);
            this.Controls.Add(this.lbl_MusteriID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbx_OdaNo);
            this.Controls.Add(this.btn_RezervasyonOnayla);
            this.Controls.Add(this.lbl_Ucret);
            this.Controls.Add(this.lbl_RezervasyonTip);
            this.Controls.Add(this.lbl_Adsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvw_Rezervasyonlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCalisan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan";
            this.Load += new System.EventHandler(this.FrmCalisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_Rezervasyonlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_DoluOdalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvw_Rezervasyonlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Adsoyad;
        private System.Windows.Forms.Label lbl_RezervasyonTip;
        private System.Windows.Forms.Label lbl_Ucret;
        private System.Windows.Forms.Button btn_RezervasyonOnayla;
        private System.Windows.Forms.ComboBox cmbx_OdaNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_MusteriID;
        private System.Windows.Forms.Button btn_DoluOdalar;
        private System.Windows.Forms.Button btn_RezervasyonTalebi;
        private System.Windows.Forms.Button btn_OdaBosalt;
        private System.Windows.Forms.Label lbl_RezervasyonID;
        private System.Windows.Forms.TextBox txt_OdaNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvw_DoluOdalar;
        private System.Windows.Forms.Label lbl_RezervasyonTipID;
        private System.Windows.Forms.PictureBox pcrExit;
        private System.Windows.Forms.PictureBox pcrBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerGiris;
        private System.Windows.Forms.DateTimePicker dateTimePickerCikis;
        private System.Windows.Forms.Button btn_RaporlarıGoster;
        private System.Windows.Forms.Button btn_EpostaGonder;
    }
}