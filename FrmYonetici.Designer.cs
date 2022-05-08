
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TabanFiyat = new System.Windows.Forms.TextBox();
            this.btn_TabanFiyatGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(606, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Taban Fiyat:";
            // 
            // txt_TabanFiyat
            // 
            this.txt_TabanFiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_TabanFiyat.Location = new System.Drawing.Point(705, 7);
            this.txt_TabanFiyat.Name = "txt_TabanFiyat";
            this.txt_TabanFiyat.Size = new System.Drawing.Size(84, 25);
            this.txt_TabanFiyat.TabIndex = 1;
            this.txt_TabanFiyat.TextChanged += new System.EventHandler(this.txt_TabanFiyat_TextChanged);
            // 
            // btn_TabanFiyatGuncelle
            // 
            this.btn_TabanFiyatGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_TabanFiyatGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TabanFiyatGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TabanFiyatGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_TabanFiyatGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_TabanFiyatGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TabanFiyatGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TabanFiyatGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_TabanFiyatGuncelle.Location = new System.Drawing.Point(601, 37);
            this.btn_TabanFiyatGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TabanFiyatGuncelle.Name = "btn_TabanFiyatGuncelle";
            this.btn_TabanFiyatGuncelle.Size = new System.Drawing.Size(188, 36);
            this.btn_TabanFiyatGuncelle.TabIndex = 43;
            this.btn_TabanFiyatGuncelle.Text = "Fiyat Güncelle";
            this.btn_TabanFiyatGuncelle.UseVisualStyleBackColor = false;
            this.btn_TabanFiyatGuncelle.Click += new System.EventHandler(this.btn_TabanFiyatGuncelle_Click);
            // 
            // FrmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_TabanFiyatGuncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_TabanFiyat);
            this.Name = "FrmYonetici";
            this.Text = "FrmYonetici";
            this.Load += new System.EventHandler(this.FrmYonetici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TabanFiyat;
        private System.Windows.Forms.Button btn_TabanFiyatGuncelle;
    }
}