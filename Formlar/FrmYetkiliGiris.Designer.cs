
namespace hotelOasis
{
    partial class FrmYetkiliGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYetkiliGiris));
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAd = new System.Windows.Forms.TextBox();
            this.lbl_kullaniciAd = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Yetki = new System.Windows.Forms.ComboBox();
            this.pcr_Back = new System.Windows.Forms.PictureBox();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sifre.Location = new System.Drawing.Point(616, 198);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(123, 24);
            this.txt_sifre.TabIndex = 13;
            this.txt_sifre.Text = "123456";
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // txt_kullaniciAd
            // 
            this.txt_kullaniciAd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kullaniciAd.Location = new System.Drawing.Point(616, 169);
            this.txt_kullaniciAd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_kullaniciAd.Name = "txt_kullaniciAd";
            this.txt_kullaniciAd.Size = new System.Drawing.Size(123, 24);
            this.txt_kullaniciAd.TabIndex = 12;
            this.txt_kullaniciAd.Text = "Admin";
            // 
            // lbl_kullaniciAd
            // 
            this.lbl_kullaniciAd.AutoSize = true;
            this.lbl_kullaniciAd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kullaniciAd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kullaniciAd.ForeColor = System.Drawing.Color.White;
            this.lbl_kullaniciAd.Location = new System.Drawing.Point(498, 171);
            this.lbl_kullaniciAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kullaniciAd.Name = "lbl_kullaniciAd";
            this.lbl_kullaniciAd.Size = new System.Drawing.Size(111, 21);
            this.lbl_kullaniciAd.TabIndex = 11;
            this.lbl_kullaniciAd.Text = "Kullanıcı Adı: ";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Sifre.ForeColor = System.Drawing.Color.White;
            this.lbl_Sifre.Location = new System.Drawing.Point(563, 200);
            this.lbl_Sifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(46, 21);
            this.lbl_Sifre.TabIndex = 10;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.Transparent;
            this.btn_Giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Giris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Giris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giris.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Giris.ForeColor = System.Drawing.Color.White;
            this.btn_Giris.Location = new System.Drawing.Point(623, 256);
            this.btn_Giris.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(116, 31);
            this.btn_Giris.TabIndex = 9;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            this.btn_Giris.MouseLeave += new System.EventHandler(this.btn_Giris_MouseLeave);
            this.btn_Giris.MouseHover += new System.EventHandler(this.btn_Giris_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(499, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı Tür: ";
            // 
            // cmb_Yetki
            // 
            this.cmb_Yetki.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Yetki.FormattingEnabled = true;
            this.cmb_Yetki.Items.AddRange(new object[] {
            "Yönetici",
            "Çalışan"});
            this.cmb_Yetki.Location = new System.Drawing.Point(616, 227);
            this.cmb_Yetki.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Yetki.Name = "cmb_Yetki";
            this.cmb_Yetki.Size = new System.Drawing.Size(123, 23);
            this.cmb_Yetki.TabIndex = 15;
            this.cmb_Yetki.Text = "Yönetici";
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
            this.pcr_Back.TabIndex = 16;
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
            this.pcr_Exit.TabIndex = 17;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // FrmYetkiliGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.pcr_Back);
            this.Controls.Add(this.cmb_Yetki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciAd);
            this.Controls.Add(this.lbl_kullaniciAd);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.btn_Giris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmYetkiliGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYetkiliGiris";
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullaniciAd;
        private System.Windows.Forms.Label lbl_kullaniciAd;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Yetki;
        private System.Windows.Forms.PictureBox pcr_Back;
        private System.Windows.Forms.PictureBox pcr_Exit;
    }
}