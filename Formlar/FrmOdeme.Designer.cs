
namespace hotelOasis
{
    partial class FrmOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdeme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.msktxt_KartNo = new System.Windows.Forms.MaskedTextBox();
            this.btn_Odeme = new System.Windows.Forms.Button();
            this.msktxt_SonKullanim = new System.Windows.Forms.MaskedTextBox();
            this.msktxt_Cvv = new System.Windows.Forms.MaskedTextBox();
            this.btn_KartKaydet = new System.Windows.Forms.Button();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kart Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CVV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Son Kullanma Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kartın Üzerindeki Ad Soyad:";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AdSoyad.Location = new System.Drawing.Point(277, 39);
            this.txt_AdSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(135, 28);
            this.txt_AdSoyad.TabIndex = 4;
            // 
            // msktxt_KartNo
            // 
            this.msktxt_KartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxt_KartNo.Location = new System.Drawing.Point(277, 74);
            this.msktxt_KartNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxt_KartNo.Mask = "0000-0000-0000-0000";
            this.msktxt_KartNo.Name = "msktxt_KartNo";
            this.msktxt_KartNo.Size = new System.Drawing.Size(217, 28);
            this.msktxt_KartNo.TabIndex = 7;
            // 
            // btn_Odeme
            // 
            this.btn_Odeme.BackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Odeme.FlatAppearance.BorderSize = 2;
            this.btn_Odeme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Odeme.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Odeme.ForeColor = System.Drawing.Color.White;
            this.btn_Odeme.Location = new System.Drawing.Point(60, 180);
            this.btn_Odeme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Odeme.Name = "btn_Odeme";
            this.btn_Odeme.Size = new System.Drawing.Size(172, 46);
            this.btn_Odeme.TabIndex = 8;
            this.btn_Odeme.Text = "Ödeme Yap";
            this.btn_Odeme.UseVisualStyleBackColor = false;
            this.btn_Odeme.Click += new System.EventHandler(this.btn_Odeme_Click);
            // 
            // msktxt_SonKullanim
            // 
            this.msktxt_SonKullanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxt_SonKullanim.Location = new System.Drawing.Point(279, 142);
            this.msktxt_SonKullanim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxt_SonKullanim.Mask = "00/00";
            this.msktxt_SonKullanim.Name = "msktxt_SonKullanim";
            this.msktxt_SonKullanim.Size = new System.Drawing.Size(59, 28);
            this.msktxt_SonKullanim.TabIndex = 9;
            this.msktxt_SonKullanim.ValidatingType = typeof(System.DateTime);
            // 
            // msktxt_Cvv
            // 
            this.msktxt_Cvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxt_Cvv.Location = new System.Drawing.Point(279, 108);
            this.msktxt_Cvv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxt_Cvv.Mask = "000";
            this.msktxt_Cvv.Name = "msktxt_Cvv";
            this.msktxt_Cvv.Size = new System.Drawing.Size(59, 28);
            this.msktxt_Cvv.TabIndex = 10;
            this.msktxt_Cvv.ValidatingType = typeof(System.DateTime);
            // 
            // btn_KartKaydet
            // 
            this.btn_KartKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btn_KartKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KartKaydet.FlatAppearance.BorderSize = 2;
            this.btn_KartKaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_KartKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_KartKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KartKaydet.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KartKaydet.ForeColor = System.Drawing.Color.White;
            this.btn_KartKaydet.Location = new System.Drawing.Point(259, 180);
            this.btn_KartKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_KartKaydet.Name = "btn_KartKaydet";
            this.btn_KartKaydet.Size = new System.Drawing.Size(235, 46);
            this.btn_KartKaydet.TabIndex = 12;
            this.btn_KartKaydet.Text = "Kartımı Kaydet";
            this.btn_KartKaydet.UseVisualStyleBackColor = false;
            this.btn_KartKaydet.Click += new System.EventHandler(this.btn_KartKaydet_Click);
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.Image")));
            this.pcr_Exit.Location = new System.Drawing.Point(457, 13);
            this.pcr_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(43, 26);
            this.pcr_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Exit.TabIndex = 31;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // FrmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 240);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.btn_KartKaydet);
            this.Controls.Add(this.msktxt_Cvv);
            this.Controls.Add(this.msktxt_SonKullanim);
            this.Controls.Add(this.btn_Odeme);
            this.Controls.Add(this.msktxt_KartNo);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmOdeme";
            this.Load += new System.EventHandler(this.FrmOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.MaskedTextBox msktxt_KartNo;
        private System.Windows.Forms.Button btn_Odeme;
        private System.Windows.Forms.MaskedTextBox msktxt_SonKullanim;
        private System.Windows.Forms.MaskedTextBox msktxt_Cvv;
        private System.Windows.Forms.Button btn_KartKaydet;
        private System.Windows.Forms.PictureBox pcr_Exit;
    }
}