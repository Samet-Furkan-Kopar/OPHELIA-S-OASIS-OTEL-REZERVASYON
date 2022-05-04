
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
            this.SuspendLayout();
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(280, 124);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(76, 20);
            this.txt_sifre.TabIndex = 13;
            // 
            // txt_kullaniciAd
            // 
            this.txt_kullaniciAd.Location = new System.Drawing.Point(280, 87);
            this.txt_kullaniciAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_kullaniciAd.Name = "txt_kullaniciAd";
            this.txt_kullaniciAd.Size = new System.Drawing.Size(76, 20);
            this.txt_kullaniciAd.TabIndex = 12;
            // 
            // lbl_kullaniciAd
            // 
            this.lbl_kullaniciAd.AutoSize = true;
            this.lbl_kullaniciAd.Location = new System.Drawing.Point(166, 87);
            this.lbl_kullaniciAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kullaniciAd.Name = "lbl_kullaniciAd";
            this.lbl_kullaniciAd.Size = new System.Drawing.Size(70, 13);
            this.lbl_kullaniciAd.TabIndex = 11;
            this.lbl_kullaniciAd.Text = "Kullanıcı Adı: ";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(166, 128);
            this.lbl_Sifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(28, 13);
            this.lbl_Sifre.TabIndex = 10;
            this.lbl_Sifre.Text = "Şifre";
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(256, 217);
            this.btn_Giris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(116, 31);
            this.btn_Giris.TabIndex = 9;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı Tür: ";
            // 
            // cmb_Yetki
            // 
            this.cmb_Yetki.FormattingEnabled = true;
            this.cmb_Yetki.Items.AddRange(new object[] {
            "Yönetici",
            "Çalışan"});
            this.cmb_Yetki.Location = new System.Drawing.Point(280, 171);
            this.cmb_Yetki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Yetki.Name = "cmb_Yetki";
            this.cmb_Yetki.Size = new System.Drawing.Size(92, 21);
            this.cmb_Yetki.TabIndex = 15;
            // 
            // FrmYetkiliGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmb_Yetki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciAd);
            this.Controls.Add(this.lbl_kullaniciAd);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.btn_Giris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmYetkiliGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYetkiliGiris";
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
    }
}