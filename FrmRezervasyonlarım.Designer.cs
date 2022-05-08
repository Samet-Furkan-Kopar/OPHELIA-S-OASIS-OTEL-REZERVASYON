
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRezervasyonlarım));
            this.dgvw_Rezervasyonlarım = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeGiris = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCikis = new System.Windows.Forms.DateTimePicker();
            this.btn_Odeme = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_İptal = new System.Windows.Forms.Button();
            this.pcr_Back = new System.Windows.Forms.PictureBox();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            this.lbl_MusteriID = new System.Windows.Forms.Label();
            this.lbl_RezervasyonID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_Rezervasyonlarım)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvw_Rezervasyonlarım
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            this.dgvw_Rezervasyonlarım.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvw_Rezervasyonlarım.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvw_Rezervasyonlarım.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_Rezervasyonlarım.GridColor = System.Drawing.Color.DarkSalmon;
            this.dgvw_Rezervasyonlarım.Location = new System.Drawing.Point(11, 38);
            this.dgvw_Rezervasyonlarım.Margin = new System.Windows.Forms.Padding(2);
            this.dgvw_Rezervasyonlarım.Name = "dgvw_Rezervasyonlarım";
            this.dgvw_Rezervasyonlarım.RowHeadersWidth = 51;
            this.dgvw_Rezervasyonlarım.RowTemplate.Height = 24;
            this.dgvw_Rezervasyonlarım.Size = new System.Drawing.Size(728, 212);
            this.dgvw_Rezervasyonlarım.TabIndex = 0;
            this.dgvw_Rezervasyonlarım.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvw_Rezervasyonlarım_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giriş Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
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
            this.dateTimeGiris.Location = new System.Drawing.Point(117, 258);
            this.dateTimeGiris.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeGiris.Name = "dateTimeGiris";
            this.dateTimeGiris.Size = new System.Drawing.Size(159, 24);
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
            this.dateTimeCikis.Location = new System.Drawing.Point(117, 287);
            this.dateTimeCikis.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeCikis.Name = "dateTimeCikis";
            this.dateTimeCikis.Size = new System.Drawing.Size(159, 24);
            this.dateTimeCikis.TabIndex = 7;
            // 
            // btn_Odeme
            // 
            this.btn_Odeme.BackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Odeme.FlatAppearance.BorderSize = 2;
            this.btn_Odeme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Odeme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Odeme.ForeColor = System.Drawing.Color.White;
            this.btn_Odeme.Location = new System.Drawing.Point(607, 262);
            this.btn_Odeme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Odeme.Name = "btn_Odeme";
            this.btn_Odeme.Size = new System.Drawing.Size(131, 37);
            this.btn_Odeme.TabIndex = 9;
            this.btn_Odeme.Text = "Ödeme Yap";
            this.btn_Odeme.UseVisualStyleBackColor = false;
            this.btn_Odeme.Click += new System.EventHandler(this.btn_Odeme_Click);
            this.btn_Odeme.MouseLeave += new System.EventHandler(this.btn_Odeme_MouseLeave);
            this.btn_Odeme.MouseHover += new System.EventHandler(this.btn_Odeme_MouseHover);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guncelle.FlatAppearance.BorderSize = 3;
            this.btn_Guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_Guncelle.Location = new System.Drawing.Point(117, 326);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 37);
            this.btn_Guncelle.TabIndex = 10;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            this.btn_Guncelle.MouseLeave += new System.EventHandler(this.btn_Guncelle_MouseLeave);
            this.btn_Guncelle.MouseHover += new System.EventHandler(this.btn_Guncelle_MouseHover);
            // 
            // btn_İptal
            // 
            this.btn_İptal.BackColor = System.Drawing.Color.Transparent;
            this.btn_İptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_İptal.FlatAppearance.BorderSize = 3;
            this.btn_İptal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_İptal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_İptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_İptal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_İptal.ForeColor = System.Drawing.Color.White;
            this.btn_İptal.Location = new System.Drawing.Point(201, 326);
            this.btn_İptal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_İptal.Name = "btn_İptal";
            this.btn_İptal.Size = new System.Drawing.Size(75, 37);
            this.btn_İptal.TabIndex = 11;
            this.btn_İptal.Text = "İptal";
            this.btn_İptal.UseVisualStyleBackColor = false;
            this.btn_İptal.Click += new System.EventHandler(this.btn_İptal_Click);
            this.btn_İptal.MouseLeave += new System.EventHandler(this.btn_İptal_MouseLeave);
            this.btn_İptal.MouseHover += new System.EventHandler(this.btn_İptal_MouseHover);
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
            this.pcr_Back.TabIndex = 14;
            this.pcr_Back.TabStop = false;
            this.pcr_Back.Click += new System.EventHandler(this.pcr_Back_Click);
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.Image")));
            this.pcr_Exit.Location = new System.Drawing.Point(707, 12);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(32, 21);
            this.pcr_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Exit.TabIndex = 13;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // lbl_MusteriID
            // 
            this.lbl_MusteriID.AutoSize = true;
            this.lbl_MusteriID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MusteriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_MusteriID.ForeColor = System.Drawing.Color.White;
            this.lbl_MusteriID.Location = new System.Drawing.Point(8, 421);
            this.lbl_MusteriID.Name = "lbl_MusteriID";
            this.lbl_MusteriID.Size = new System.Drawing.Size(51, 20);
            this.lbl_MusteriID.TabIndex = 15;
            this.lbl_MusteriID.Text = "-------";
            this.lbl_MusteriID.Visible = false;
            // 
            // lbl_RezervasyonID
            // 
            this.lbl_RezervasyonID.AutoSize = true;
            this.lbl_RezervasyonID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RezervasyonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_RezervasyonID.ForeColor = System.Drawing.Color.White;
            this.lbl_RezervasyonID.Location = new System.Drawing.Point(78, 421);
            this.lbl_RezervasyonID.Name = "lbl_RezervasyonID";
            this.lbl_RezervasyonID.Size = new System.Drawing.Size(51, 20);
            this.lbl_RezervasyonID.TabIndex = 16;
            this.lbl_RezervasyonID.Text = "-------";
            this.lbl_RezervasyonID.Visible = false;
            // 
            // FrmRezervasyonlarım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.lbl_RezervasyonID);
            this.Controls.Add(this.lbl_MusteriID);
            this.Controls.Add(this.pcr_Back);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.btn_İptal);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Odeme);
            this.Controls.Add(this.dateTimeCikis);
            this.Controls.Add(this.dateTimeGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvw_Rezervasyonlarım);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRezervasyonlarım";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyonlarım";
            this.Load += new System.EventHandler(this.FrmRezervasyonlarım_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_Rezervasyonlarım)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
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
        private System.Windows.Forms.PictureBox pcr_Back;
        private System.Windows.Forms.PictureBox pcr_Exit;
        private System.Windows.Forms.Label lbl_MusteriID;
        private System.Windows.Forms.Label lbl_RezervasyonID;
    }
}