
namespace hotelOasis
{
    partial class FrmFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFatura));
            this.dgvw_Fatura = new System.Windows.Forms.DataGridView();
            this.btn_FaturaYazdir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_Fatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvw_Fatura
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            this.dgvw_Fatura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvw_Fatura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvw_Fatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_Fatura.GridColor = System.Drawing.Color.DarkSalmon;
            this.dgvw_Fatura.Location = new System.Drawing.Point(10, 41);
            this.dgvw_Fatura.Name = "dgvw_Fatura";
            this.dgvw_Fatura.RowHeadersWidth = 51;
            this.dgvw_Fatura.Size = new System.Drawing.Size(578, 81);
            this.dgvw_Fatura.TabIndex = 42;
            // 
            // btn_FaturaYazdir
            // 
            this.btn_FaturaYazdir.BackColor = System.Drawing.Color.Transparent;
            this.btn_FaturaYazdir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FaturaYazdir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FaturaYazdir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_FaturaYazdir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_FaturaYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FaturaYazdir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_FaturaYazdir.ForeColor = System.Drawing.Color.White;
            this.btn_FaturaYazdir.Location = new System.Drawing.Point(10, 127);
            this.btn_FaturaYazdir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FaturaYazdir.Name = "btn_FaturaYazdir";
            this.btn_FaturaYazdir.Size = new System.Drawing.Size(126, 36);
            this.btn_FaturaYazdir.TabIndex = 0;
            this.btn_FaturaYazdir.Text = "Fatura Yazdır";
            this.btn_FaturaYazdir.UseVisualStyleBackColor = false;
            this.btn_FaturaYazdir.Click += new System.EventHandler(this.btn_FaturaYazdir_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.Image")));
            this.pcr_Exit.Location = new System.Drawing.Point(556, 12);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(32, 21);
            this.pcr_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Exit.TabIndex = 56;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // FrmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 186);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.btn_FaturaYazdir);
            this.Controls.Add(this.dgvw_Fatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFatura";
            this.Text = "FrmFatura";
            this.Load += new System.EventHandler(this.FrmFatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_Fatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvw_Fatura;
        private System.Windows.Forms.Button btn_FaturaYazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pcr_Exit;
    }
}