
namespace hotelOasis
{
    partial class FrmYonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYonetici));
            this.dgvw_Rezervasyonlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Adsoyad = new System.Windows.Forms.Label();
            this.lbl_GirisTarih = new System.Windows.Forms.Label();
            this.lbl_CikisTarih = new System.Windows.Forms.Label();
            this.lbl_Rezervasyon = new System.Windows.Forms.Label();
            this.lbl_Ucret = new System.Windows.Forms.Label();
            this.btn_RezervasyonOnayla = new System.Windows.Forms.Button();
            this.cmbx_OdaNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_MusteriID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_Rezervasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvw_Rezervasyonlar
            // 
            this.dgvw_Rezervasyonlar.AllowUserToAddRows = false;
            this.dgvw_Rezervasyonlar.AllowUserToDeleteRows = false;
            this.dgvw_Rezervasyonlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvw_Rezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_Rezervasyonlar.Location = new System.Drawing.Point(12, 12);
            this.dgvw_Rezervasyonlar.Name = "dgvw_Rezervasyonlar";
            this.dgvw_Rezervasyonlar.ReadOnly = true;
            this.dgvw_Rezervasyonlar.RowHeadersWidth = 51;
            this.dgvw_Rezervasyonlar.RowTemplate.Height = 24;
            this.dgvw_Rezervasyonlar.Size = new System.Drawing.Size(880, 258);
            this.dgvw_Rezervasyonlar.TabIndex = 1;
            this.dgvw_Rezervasyonlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvw_Rezervasyonlar_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rezervasyon Tip:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ücret:";
            // 
            // lbl_Adsoyad
            // 
            this.lbl_Adsoyad.AutoSize = true;
            this.lbl_Adsoyad.Location = new System.Drawing.Point(186, 292);
            this.lbl_Adsoyad.Name = "lbl_Adsoyad";
            this.lbl_Adsoyad.Size = new System.Drawing.Size(43, 17);
            this.lbl_Adsoyad.TabIndex = 7;
            this.lbl_Adsoyad.Text = "-------";
            // 
            // lbl_GirisTarih
            // 
            this.lbl_GirisTarih.AutoSize = true;
            this.lbl_GirisTarih.Location = new System.Drawing.Point(186, 324);
            this.lbl_GirisTarih.Name = "lbl_GirisTarih";
            this.lbl_GirisTarih.Size = new System.Drawing.Size(43, 17);
            this.lbl_GirisTarih.TabIndex = 8;
            this.lbl_GirisTarih.Text = "-------";
            // 
            // lbl_CikisTarih
            // 
            this.lbl_CikisTarih.AutoSize = true;
            this.lbl_CikisTarih.Location = new System.Drawing.Point(186, 359);
            this.lbl_CikisTarih.Name = "lbl_CikisTarih";
            this.lbl_CikisTarih.Size = new System.Drawing.Size(43, 17);
            this.lbl_CikisTarih.TabIndex = 9;
            this.lbl_CikisTarih.Text = "-------";
            // 
            // lbl_Rezervasyon
            // 
            this.lbl_Rezervasyon.AutoSize = true;
            this.lbl_Rezervasyon.Location = new System.Drawing.Point(186, 393);
            this.lbl_Rezervasyon.Name = "lbl_Rezervasyon";
            this.lbl_Rezervasyon.Size = new System.Drawing.Size(43, 17);
            this.lbl_Rezervasyon.TabIndex = 10;
            this.lbl_Rezervasyon.Text = "-------";
            // 
            // lbl_Ucret
            // 
            this.lbl_Ucret.AutoSize = true;
            this.lbl_Ucret.Location = new System.Drawing.Point(186, 422);
            this.lbl_Ucret.Name = "lbl_Ucret";
            this.lbl_Ucret.Size = new System.Drawing.Size(43, 17);
            this.lbl_Ucret.TabIndex = 11;
            this.lbl_Ucret.Text = "-------";
            // 
            // btn_RezervasyonOnayla
            // 
            this.btn_RezervasyonOnayla.BackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonOnayla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RezervasyonOnayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RezervasyonOnayla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonOnayla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RezervasyonOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RezervasyonOnayla.ForeColor = System.Drawing.Color.Black;
            this.btn_RezervasyonOnayla.Location = new System.Drawing.Point(676, 298);
            this.btn_RezervasyonOnayla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RezervasyonOnayla.Name = "btn_RezervasyonOnayla";
            this.btn_RezervasyonOnayla.Size = new System.Drawing.Size(201, 62);
            this.btn_RezervasyonOnayla.TabIndex = 30;
            this.btn_RezervasyonOnayla.Text = "Rezervasyon Onayla";
            this.btn_RezervasyonOnayla.UseVisualStyleBackColor = false;
            this.btn_RezervasyonOnayla.Click += new System.EventHandler(this.btn_RezervasyonOnayla_Click);
            // 
            // cmbx_OdaNo
            // 
            this.cmbx_OdaNo.FormattingEnabled = true;
            this.cmbx_OdaNo.Location = new System.Drawing.Point(467, 289);
            this.cmbx_OdaNo.Name = "cmbx_OdaNo";
            this.cmbx_OdaNo.Size = new System.Drawing.Size(110, 24);
            this.cmbx_OdaNo.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Oda No:";
            // 
            // lbl_MusteriID
            // 
            this.lbl_MusteriID.AutoSize = true;
            this.lbl_MusteriID.Location = new System.Drawing.Point(849, 393);
            this.lbl_MusteriID.Name = "lbl_MusteriID";
            this.lbl_MusteriID.Size = new System.Drawing.Size(43, 17);
            this.lbl_MusteriID.TabIndex = 33;
            this.lbl_MusteriID.Text = "-------";
            // 
            // FrmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 514);
            this.Controls.Add(this.lbl_MusteriID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbx_OdaNo);
            this.Controls.Add(this.btn_RezervasyonOnayla);
            this.Controls.Add(this.lbl_Ucret);
            this.Controls.Add(this.lbl_Rezervasyon);
            this.Controls.Add(this.lbl_CikisTarih);
            this.Controls.Add(this.lbl_GirisTarih);
            this.Controls.Add(this.lbl_Adsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvw_Rezervasyonlar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmYonetici";
            this.Text = "Yönetici";
            this.Load += new System.EventHandler(this.FrmYonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_Rezervasyonlar)).EndInit();
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
        private System.Windows.Forms.Label lbl_GirisTarih;
        private System.Windows.Forms.Label lbl_CikisTarih;
        private System.Windows.Forms.Label lbl_Rezervasyon;
        private System.Windows.Forms.Label lbl_Ucret;
        private System.Windows.Forms.Button btn_RezervasyonOnayla;
        private System.Windows.Forms.ComboBox cmbx_OdaNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_MusteriID;
    }
}