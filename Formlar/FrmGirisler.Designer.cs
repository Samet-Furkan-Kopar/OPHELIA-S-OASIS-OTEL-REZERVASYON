
namespace hotelOasis
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btn_Yetkili = new System.Windows.Forms.Button();
            this.btn_Musteri = new System.Windows.Forms.Button();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Yetkili
            // 
            this.btn_Yetkili.BackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yetkili.FlatAppearance.BorderSize = 2;
            this.btn_Yetkili.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yetkili.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yetkili.ForeColor = System.Drawing.Color.White;
            this.btn_Yetkili.Location = new System.Drawing.Point(123, 308);
            this.btn_Yetkili.Name = "btn_Yetkili";
            this.btn_Yetkili.Size = new System.Drawing.Size(201, 101);
            this.btn_Yetkili.TabIndex = 0;
            this.btn_Yetkili.Text = "Yetkili";
            this.btn_Yetkili.UseVisualStyleBackColor = false;
            this.btn_Yetkili.Click += new System.EventHandler(this.btn_Yetkili_Click);
            this.btn_Yetkili.MouseLeave += new System.EventHandler(this.btn_Yetkili_MouseLeave);
            this.btn_Yetkili.MouseHover += new System.EventHandler(this.btn_Yetkili_MouseHover);
            // 
            // btn_Musteri
            // 
            this.btn_Musteri.BackColor = System.Drawing.Color.Transparent;
            this.btn_Musteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Musteri.FlatAppearance.BorderSize = 2;
            this.btn_Musteri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Musteri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Musteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Musteri.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Musteri.ForeColor = System.Drawing.Color.White;
            this.btn_Musteri.Location = new System.Drawing.Point(453, 308);
            this.btn_Musteri.Name = "btn_Musteri";
            this.btn_Musteri.Size = new System.Drawing.Size(201, 101);
            this.btn_Musteri.TabIndex = 1;
            this.btn_Musteri.Text = "Müşteri";
            this.btn_Musteri.UseVisualStyleBackColor = false;
            this.btn_Musteri.Click += new System.EventHandler(this.btn_Musteri_Click);
            this.btn_Musteri.MouseLeave += new System.EventHandler(this.btn_Musteri_MouseLeave);
            this.btn_Musteri.MouseHover += new System.EventHandler(this.btn_Musteri_MouseHover);
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.Image")));
            this.pcr_Exit.Location = new System.Drawing.Point(756, 12);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(32, 21);
            this.pcr_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Exit.TabIndex = 2;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.btn_Musteri);
            this.Controls.Add(this.btn_Yetkili);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Oasis";
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Yetkili;
        private System.Windows.Forms.Button btn_Musteri;
        private System.Windows.Forms.PictureBox pcr_Exit;
    }
}