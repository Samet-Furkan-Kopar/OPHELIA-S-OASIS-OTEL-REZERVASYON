
namespace hotelOasis
{
    partial class FrmRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRezervasyon));
            this.btn_RezervasyonYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeGiris = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCikis = new System.Windows.Forms.DateTimePicker();
            this.lbl_adSoyad = new System.Windows.Forms.Label();
            this.lblRezervasyonKacGunKaldi = new System.Windows.Forms.Label();
            this.btn_Rezervasyonlarım = new System.Windows.Forms.Button();
            this.lblKalinanGun = new System.Windows.Forms.Label();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.btn_UcretHesapla = new System.Windows.Forms.Button();
            this.pcr_Back = new System.Windows.Forms.PictureBox();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            this.lbl_MusteriID2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RezervasyonYap
            // 
            this.btn_RezervasyonYap.BackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RezervasyonYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RezervasyonYap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_RezervasyonYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RezervasyonYap.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RezervasyonYap.ForeColor = System.Drawing.Color.White;
            this.btn_RezervasyonYap.Location = new System.Drawing.Point(345, 190);
            this.btn_RezervasyonYap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_RezervasyonYap.Name = "btn_RezervasyonYap";
            this.btn_RezervasyonYap.Size = new System.Drawing.Size(193, 50);
            this.btn_RezervasyonYap.TabIndex = 0;
            this.btn_RezervasyonYap.Text = "Rezervasyon Yap";
            this.btn_RezervasyonYap.UseVisualStyleBackColor = false;
            this.btn_RezervasyonYap.Click += new System.EventHandler(this.btn_RezervasyonYap_Click);
            this.btn_RezervasyonYap.MouseLeave += new System.EventHandler(this.btn_RezervasyonYap_MouseLeave);
            this.btn_RezervasyonYap.MouseHover += new System.EventHandler(this.btn_RezervasyonYap_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giriş Tarihi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(229, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Çıkış Tarihi: ";
            // 
            // dateTimeGiris
            // 
            this.dateTimeGiris.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeGiris.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimeGiris.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimeGiris.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimeGiris.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimeGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeGiris.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeGiris.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimeGiris.Location = new System.Drawing.Point(345, 113);
            this.dateTimeGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeGiris.Name = "dateTimeGiris";
            this.dateTimeGiris.Size = new System.Drawing.Size(151, 24);
            this.dateTimeGiris.TabIndex = 5;
            this.dateTimeGiris.Value = new System.DateTime(2022, 5, 4, 0, 0, 0, 0);
            // 
            // dateTimeCikis
            // 
            this.dateTimeCikis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCikis.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimeCikis.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimeCikis.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimeCikis.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimeCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCikis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCikis.Location = new System.Drawing.Point(345, 153);
            this.dateTimeCikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeCikis.Name = "dateTimeCikis";
            this.dateTimeCikis.Size = new System.Drawing.Size(151, 24);
            this.dateTimeCikis.TabIndex = 6;
            this.dateTimeCikis.Value = new System.DateTime(2022, 5, 4, 17, 35, 19, 0);
            // 
            // lbl_adSoyad
            // 
            this.lbl_adSoyad.AutoSize = true;
            this.lbl_adSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adSoyad.ForeColor = System.Drawing.Color.White;
            this.lbl_adSoyad.Location = new System.Drawing.Point(341, 79);
            this.lbl_adSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adSoyad.Name = "lbl_adSoyad";
            this.lbl_adSoyad.Size = new System.Drawing.Size(34, 21);
            this.lbl_adSoyad.TabIndex = 8;
            this.lbl_adSoyad.Text = "----";
            // 
            // lblRezervasyonKacGunKaldi
            // 
            this.lblRezervasyonKacGunKaldi.AutoSize = true;
            this.lblRezervasyonKacGunKaldi.BackColor = System.Drawing.Color.Transparent;
            this.lblRezervasyonKacGunKaldi.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezervasyonKacGunKaldi.ForeColor = System.Drawing.Color.White;
            this.lblRezervasyonKacGunKaldi.Location = new System.Drawing.Point(8, 420);
            this.lblRezervasyonKacGunKaldi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRezervasyonKacGunKaldi.Name = "lblRezervasyonKacGunKaldi";
            this.lblRezervasyonKacGunKaldi.Size = new System.Drawing.Size(105, 21);
            this.lblRezervasyonKacGunKaldi.TabIndex = 19;
            this.lblRezervasyonKacGunKaldi.Text = "KacGunKaldı";
            this.lblRezervasyonKacGunKaldi.Visible = false;
            // 
            // btn_Rezervasyonlarım
            // 
            this.btn_Rezervasyonlarım.BackColor = System.Drawing.Color.Transparent;
            this.btn_Rezervasyonlarım.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Rezervasyonlarım.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Rezervasyonlarım.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Rezervasyonlarım.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Rezervasyonlarım.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rezervasyonlarım.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rezervasyonlarım.ForeColor = System.Drawing.Color.White;
            this.btn_Rezervasyonlarım.Location = new System.Drawing.Point(345, 263);
            this.btn_Rezervasyonlarım.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Rezervasyonlarım.Name = "btn_Rezervasyonlarım";
            this.btn_Rezervasyonlarım.Size = new System.Drawing.Size(193, 50);
            this.btn_Rezervasyonlarım.TabIndex = 1;
            this.btn_Rezervasyonlarım.Text = "Rezervasyonlarım";
            this.btn_Rezervasyonlarım.UseVisualStyleBackColor = false;
            this.btn_Rezervasyonlarım.Click += new System.EventHandler(this.btn_Rezervasyonlarım_Click);
            this.btn_Rezervasyonlarım.MouseLeave += new System.EventHandler(this.btn_Rezervasyonlarım_MouseLeave);
            this.btn_Rezervasyonlarım.MouseHover += new System.EventHandler(this.btn_Rezervasyonlarım_MouseHover);
            // 
            // lblKalinanGun
            // 
            this.lblKalinanGun.AutoSize = true;
            this.lblKalinanGun.BackColor = System.Drawing.Color.Transparent;
            this.lblKalinanGun.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalinanGun.ForeColor = System.Drawing.Color.White;
            this.lblKalinanGun.Location = new System.Drawing.Point(8, 399);
            this.lblKalinanGun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKalinanGun.Name = "lblKalinanGun";
            this.lblKalinanGun.Size = new System.Drawing.Size(99, 21);
            this.lblKalinanGun.TabIndex = 23;
            this.lblKalinanGun.Text = "KalinanGun";
            this.lblKalinanGun.Visible = false;
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.BackColor = System.Drawing.Color.Transparent;
            this.lblMusteriID.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusteriID.ForeColor = System.Drawing.Color.White;
            this.lblMusteriID.Location = new System.Drawing.Point(8, 378);
            this.lblMusteriID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(41, 21);
            this.lblMusteriID.TabIndex = 24;
            this.lblMusteriID.Text = "MID";
            this.lblMusteriID.Visible = false;
            // 
            // btn_UcretHesapla
            // 
            this.btn_UcretHesapla.BackColor = System.Drawing.Color.Transparent;
            this.btn_UcretHesapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UcretHesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UcretHesapla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_UcretHesapla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_UcretHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UcretHesapla.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UcretHesapla.ForeColor = System.Drawing.Color.White;
            this.btn_UcretHesapla.Location = new System.Drawing.Point(345, 331);
            this.btn_UcretHesapla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_UcretHesapla.Name = "btn_UcretHesapla";
            this.btn_UcretHesapla.Size = new System.Drawing.Size(193, 50);
            this.btn_UcretHesapla.TabIndex = 2;
            this.btn_UcretHesapla.Text = "Ücret Hesapla";
            this.btn_UcretHesapla.UseVisualStyleBackColor = false;
            this.btn_UcretHesapla.Click += new System.EventHandler(this.btn_UcretHesapla_Click);
            this.btn_UcretHesapla.MouseLeave += new System.EventHandler(this.btn_UcretHesapla_MouseLeave);
            this.btn_UcretHesapla.MouseHover += new System.EventHandler(this.btn_UcretHesapla_MouseHover);
            // 
            // pcr_Back
            // 
            this.pcr_Back.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Back.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Back.Image")));
            this.pcr_Back.Location = new System.Drawing.Point(12, 12);
            this.pcr_Back.Name = "pcr_Back";
            this.pcr_Back.Size = new System.Drawing.Size(32, 21);
            this.pcr_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Back.TabIndex = 31;
            this.pcr_Back.TabStop = false;
            this.pcr_Back.Click += new System.EventHandler(this.pcr_Back_Click);
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.Image")));
            this.pcr_Exit.Location = new System.Drawing.Point(706, 12);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(32, 21);
            this.pcr_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Exit.TabIndex = 30;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // lbl_MusteriID2
            // 
            this.lbl_MusteriID2.AutoSize = true;
            this.lbl_MusteriID2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MusteriID2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MusteriID2.ForeColor = System.Drawing.Color.White;
            this.lbl_MusteriID2.Location = new System.Drawing.Point(8, 357);
            this.lbl_MusteriID2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MusteriID2.Name = "lbl_MusteriID2";
            this.lbl_MusteriID2.Size = new System.Drawing.Size(50, 21);
            this.lbl_MusteriID2.TabIndex = 32;
            this.lbl_MusteriID2.Text = "MID2";
            this.lbl_MusteriID2.Visible = false;
            // 
            // FrmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.lbl_MusteriID2);
            this.Controls.Add(this.pcr_Back);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.btn_UcretHesapla);
            this.Controls.Add(this.lblMusteriID);
            this.Controls.Add(this.lblKalinanGun);
            this.Controls.Add(this.btn_Rezervasyonlarım);
            this.Controls.Add(this.lblRezervasyonKacGunKaldi);
            this.Controls.Add(this.lbl_adSoyad);
            this.Controls.Add(this.dateTimeCikis);
            this.Controls.Add(this.dateTimeGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RezervasyonYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Oasis Rezervasyon Ekranı";
            this.Load += new System.EventHandler(this.FrmRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RezervasyonYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeGiris;
        private System.Windows.Forms.DateTimePicker dateTimeCikis;
        private System.Windows.Forms.Label lbl_adSoyad;
        private System.Windows.Forms.Label lblRezervasyonKacGunKaldi;
        private System.Windows.Forms.Button btn_Rezervasyonlarım;
        private System.Windows.Forms.Label lblKalinanGun;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Button btn_UcretHesapla;
        private System.Windows.Forms.PictureBox pcr_Back;
        private System.Windows.Forms.PictureBox pcr_Exit;
        private System.Windows.Forms.Label lbl_MusteriID2;
    }
}