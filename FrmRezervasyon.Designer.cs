
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
            this.lblAralik = new System.Windows.Forms.Label();
            this.pcrBack = new System.Windows.Forms.PictureBox();
            this.pcrExit = new System.Windows.Forms.PictureBox();
            this.btn_Rezervasyonlarım = new System.Windows.Forms.Button();
            this.lblKalinanGun = new System.Windows.Forms.Label();
            this.lblMusteriID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrExit)).BeginInit();
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
            this.btn_RezervasyonYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RezervasyonYap.ForeColor = System.Drawing.Color.White;
            this.btn_RezervasyonYap.Location = new System.Drawing.Point(255, 222);
            this.btn_RezervasyonYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RezervasyonYap.Name = "btn_RezervasyonYap";
            this.btn_RezervasyonYap.Size = new System.Drawing.Size(201, 62);
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
            this.label1.Location = new System.Drawing.Point(83, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giriş Tarihi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
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
            this.dateTimeGiris.Location = new System.Drawing.Point(255, 125);
            this.dateTimeGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeGiris.Name = "dateTimeGiris";
            this.dateTimeGiris.Size = new System.Drawing.Size(200, 29);
            this.dateTimeGiris.TabIndex = 5;
            this.dateTimeGiris.Value = new System.DateTime(2022, 4, 23, 2, 13, 51, 0);
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
            this.dateTimeCikis.Location = new System.Drawing.Point(255, 173);
            this.dateTimeCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeCikis.Name = "dateTimeCikis";
            this.dateTimeCikis.Size = new System.Drawing.Size(200, 29);
            this.dateTimeCikis.TabIndex = 6;
            // 
            // lbl_adSoyad
            // 
            this.lbl_adSoyad.AutoSize = true;
            this.lbl_adSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adSoyad.ForeColor = System.Drawing.Color.White;
            this.lbl_adSoyad.Location = new System.Drawing.Point(249, 85);
            this.lbl_adSoyad.Name = "lbl_adSoyad";
            this.lbl_adSoyad.Size = new System.Drawing.Size(44, 28);
            this.lbl_adSoyad.TabIndex = 8;
            this.lbl_adSoyad.Text = "----";
            // 
            // lblAralik
            // 
            this.lblAralik.AutoSize = true;
            this.lblAralik.BackColor = System.Drawing.Color.Transparent;
            this.lblAralik.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAralik.ForeColor = System.Drawing.Color.White;
            this.lblAralik.Location = new System.Drawing.Point(12, 447);
            this.lblAralik.Name = "lblAralik";
            this.lblAralik.Size = new System.Drawing.Size(44, 28);
            this.lblAralik.TabIndex = 19;
            this.lblAralik.Text = "----";
            // 
            // pcrBack
            // 
            this.pcrBack.BackColor = System.Drawing.Color.Transparent;
            this.pcrBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcrBack.BackgroundImage")));
            this.pcrBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcrBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcrBack.Location = new System.Drawing.Point(16, 15);
            this.pcrBack.Margin = new System.Windows.Forms.Padding(4);
            this.pcrBack.Name = "pcrBack";
            this.pcrBack.Size = new System.Drawing.Size(43, 26);
            this.pcrBack.TabIndex = 20;
            this.pcrBack.TabStop = false;
            this.pcrBack.Click += new System.EventHandler(this.pcrBack_Click);
            // 
            // pcrExit
            // 
            this.pcrExit.BackColor = System.Drawing.Color.Transparent;
            this.pcrExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcrExit.BackgroundImage")));
            this.pcrExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcrExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcrExit.Location = new System.Drawing.Point(413, 15);
            this.pcrExit.Margin = new System.Windows.Forms.Padding(4);
            this.pcrExit.Name = "pcrExit";
            this.pcrExit.Size = new System.Drawing.Size(43, 26);
            this.pcrExit.TabIndex = 21;
            this.pcrExit.TabStop = false;
            this.pcrExit.Click += new System.EventHandler(this.pcrExit_Click);
            // 
            // btn_Rezervasyonlarım
            // 
            this.btn_Rezervasyonlarım.BackColor = System.Drawing.Color.Transparent;
            this.btn_Rezervasyonlarım.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Rezervasyonlarım.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Rezervasyonlarım.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Rezervasyonlarım.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Rezervasyonlarım.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rezervasyonlarım.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rezervasyonlarım.ForeColor = System.Drawing.Color.White;
            this.btn_Rezervasyonlarım.Location = new System.Drawing.Point(255, 289);
            this.btn_Rezervasyonlarım.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Rezervasyonlarım.Name = "btn_Rezervasyonlarım";
            this.btn_Rezervasyonlarım.Size = new System.Drawing.Size(200, 62);
            this.btn_Rezervasyonlarım.TabIndex = 22;
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
            this.lblKalinanGun.Location = new System.Drawing.Point(12, 419);
            this.lblKalinanGun.Name = "lblKalinanGun";
            this.lblKalinanGun.Size = new System.Drawing.Size(44, 28);
            this.lblKalinanGun.TabIndex = 23;
            this.lblKalinanGun.Text = "----";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.BackColor = System.Drawing.Color.Transparent;
            this.lblMusteriID.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusteriID.ForeColor = System.Drawing.Color.White;
            this.lblMusteriID.Location = new System.Drawing.Point(11, 391);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(44, 28);
            this.lblMusteriID.TabIndex = 24;
            this.lblMusteriID.Text = "----";
            // 
            // FrmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 484);
            this.Controls.Add(this.lblMusteriID);
            this.Controls.Add(this.lblKalinanGun);
            this.Controls.Add(this.btn_Rezervasyonlarım);
            this.Controls.Add(this.pcrExit);
            this.Controls.Add(this.pcrBack);
            this.Controls.Add(this.lblAralik);
            this.Controls.Add(this.lbl_adSoyad);
            this.Controls.Add(this.dateTimeCikis);
            this.Controls.Add(this.dateTimeGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RezervasyonYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Oasis Rezervasyon Ekranı";
            this.Load += new System.EventHandler(this.FrmRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcrBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrExit)).EndInit();
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
        private System.Windows.Forms.Label lblAralik;
        private System.Windows.Forms.PictureBox pcrBack;
        private System.Windows.Forms.PictureBox pcrExit;
        private System.Windows.Forms.Button btn_Rezervasyonlarım;
        private System.Windows.Forms.Label lblKalinanGun;
        private System.Windows.Forms.Label lblMusteriID;
    }
}