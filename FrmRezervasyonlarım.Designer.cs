
namespace hotelOasis
{
    partial class FrmRezervasyonlarım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRezervasyonlarım));
            this.dgvw_Rezervasyonlarım = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeGiris = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCikis = new System.Windows.Forms.DateTimePicker();
            this.btn_Odeme = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_İptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_Rezervasyonlarım)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvw_Rezervasyonlarım
            // 
            this.dgvw_Rezervasyonlarım.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvw_Rezervasyonlarım.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_Rezervasyonlarım.Location = new System.Drawing.Point(12, 12);
            this.dgvw_Rezervasyonlarım.Name = "dgvw_Rezervasyonlarım";
            this.dgvw_Rezervasyonlarım.RowHeadersWidth = 51;
            this.dgvw_Rezervasyonlarım.RowTemplate.Height = 24;
            this.dgvw_Rezervasyonlarım.Size = new System.Drawing.Size(776, 190);
            this.dgvw_Rezervasyonlarım.TabIndex = 0;
            this.dgvw_Rezervasyonlarım.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvw_Rezervasyonlarım_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giriş Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çıkış Tarihi:";
            // 
            // dateTimeGiris
            // 
            this.dateTimeGiris.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeGiris.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimeGiris.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimeGiris.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimeGiris.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimeGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeGiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeGiris.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimeGiris.Location = new System.Drawing.Point(157, 236);
            this.dateTimeGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeGiris.Name = "dateTimeGiris";
            this.dateTimeGiris.Size = new System.Drawing.Size(160, 29);
            this.dateTimeGiris.TabIndex = 6;
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
            this.dateTimeCikis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCikis.Location = new System.Drawing.Point(157, 271);
            this.dateTimeCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeCikis.Name = "dateTimeCikis";
            this.dateTimeCikis.Size = new System.Drawing.Size(160, 29);
            this.dateTimeCikis.TabIndex = 7;
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
            this.btn_Odeme.Location = new System.Drawing.Point(687, 225);
            this.btn_Odeme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Odeme.Name = "btn_Odeme";
            this.btn_Odeme.Size = new System.Drawing.Size(100, 45);
            this.btn_Odeme.TabIndex = 9;
            this.btn_Odeme.Text = "Ödeme Yap";
            this.btn_Odeme.UseVisualStyleBackColor = false;
            this.btn_Odeme.Click += new System.EventHandler(this.btn_Odeme_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guncelle.FlatAppearance.BorderSize = 3;
            this.btn_Guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_Guncelle.Location = new System.Drawing.Point(157, 318);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(100, 45);
            this.btn_Guncelle.TabIndex = 10;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            // 
            // btn_İptal
            // 
            this.btn_İptal.BackColor = System.Drawing.Color.Transparent;
            this.btn_İptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_İptal.FlatAppearance.BorderSize = 3;
            this.btn_İptal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_İptal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_İptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_İptal.ForeColor = System.Drawing.Color.Black;
            this.btn_İptal.Location = new System.Drawing.Point(265, 318);
            this.btn_İptal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_İptal.Name = "btn_İptal";
            this.btn_İptal.Size = new System.Drawing.Size(100, 45);
            this.btn_İptal.TabIndex = 11;
            this.btn_İptal.Text = "İptal";
            this.btn_İptal.UseVisualStyleBackColor = false;
            // 
            // FrmRezervasyonlarım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.btn_İptal);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Odeme);
            this.Controls.Add(this.dateTimeCikis);
            this.Controls.Add(this.dateTimeGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvw_Rezervasyonlarım);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRezervasyonlarım";
            this.Text = "Rezervasyonlarım";
            this.Load += new System.EventHandler(this.FrmRezervasyonlarım_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_Rezervasyonlarım)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvw_Rezervasyonlarım;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeGiris;
        private System.Windows.Forms.DateTimePicker dateTimeCikis;
        private System.Windows.Forms.Button btn_Odeme;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_İptal;
    }
}