
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
            this.txt_CVC = new System.Windows.Forms.TextBox();
            this.txt_SonKullanım_Tarihi = new System.Windows.Forms.TextBox();
            this.msktxt_KartNo = new System.Windows.Forms.MaskedTextBox();
            this.btn_Odeme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 77);
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
            this.label2.Location = new System.Drawing.Point(9, 111);
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
            this.label3.Location = new System.Drawing.Point(9, 145);
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
            this.label4.Location = new System.Drawing.Point(9, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kartın Üzerindeki Ad Soyad:";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AdSoyad.Location = new System.Drawing.Point(278, 40);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(135, 28);
            this.txt_AdSoyad.TabIndex = 4;
            // 
            // txt_CVC
            // 
            this.txt_CVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CVC.Location = new System.Drawing.Point(278, 108);
            this.txt_CVC.Name = "txt_CVC";
            this.txt_CVC.Size = new System.Drawing.Size(100, 28);
            this.txt_CVC.TabIndex = 5;
            // 
            // txt_SonKullanım_Tarihi
            // 
            this.txt_SonKullanım_Tarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SonKullanım_Tarihi.Location = new System.Drawing.Point(278, 142);
            this.txt_SonKullanım_Tarihi.Name = "txt_SonKullanım_Tarihi";
            this.txt_SonKullanım_Tarihi.Size = new System.Drawing.Size(100, 28);
            this.txt_SonKullanım_Tarihi.TabIndex = 6;
            // 
            // msktxt_KartNo
            // 
            this.msktxt_KartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxt_KartNo.Location = new System.Drawing.Point(278, 74);
            this.msktxt_KartNo.Mask = "0000-0000-0000-0000";
            this.msktxt_KartNo.Name = "msktxt_KartNo";
            this.msktxt_KartNo.Size = new System.Drawing.Size(217, 28);
            this.msktxt_KartNo.TabIndex = 7;
            // 
            // btn_Odeme
            // 
            this.btn_Odeme.BackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Odeme.FlatAppearance.BorderSize = 3;
            this.btn_Odeme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Odeme.ForeColor = System.Drawing.Color.Black;
            this.btn_Odeme.Location = new System.Drawing.Point(278, 180);
            this.btn_Odeme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Odeme.Name = "btn_Odeme";
            this.btn_Odeme.Size = new System.Drawing.Size(100, 45);
            this.btn_Odeme.TabIndex = 8;
            this.btn_Odeme.Text = "Ödeme Yap";
            this.btn_Odeme.UseVisualStyleBackColor = false;
            this.btn_Odeme.Click += new System.EventHandler(this.btn_Odeme_Click);
            // 
            // FrmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 240);
            this.Controls.Add(this.btn_Odeme);
            this.Controls.Add(this.msktxt_KartNo);
            this.Controls.Add(this.txt_SonKullanım_Tarihi);
            this.Controls.Add(this.txt_CVC);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOdeme";
            this.Text = "FrmOdeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.TextBox txt_CVC;
        private System.Windows.Forms.TextBox txt_SonKullanım_Tarihi;
        private System.Windows.Forms.MaskedTextBox msktxt_KartNo;
        private System.Windows.Forms.Button btn_Odeme;
    }
}