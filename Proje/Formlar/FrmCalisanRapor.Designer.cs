
namespace hotelOasis
{
    partial class FrmCalisanRapor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalisanRapor));
            this.GunlukGelenlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Oasis_dbDataSet2 = new hotelOasis.DataSets.Oasis_dbDataSet2();
            this.btn_GunlukDoluluk = new System.Windows.Forms.Button();
            this.btn_GunlukGelenler = new System.Windows.Forms.Button();
            this.grpbx1 = new System.Windows.Forms.GroupBox();
            this.rpvw_GunlukGelenler = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GunlukGelenlerTableAdapter = new hotelOasis.DataSets.Oasis_dbDataSet2TableAdapters.GunlukGelenlerTableAdapter();
            this.grpbx2 = new System.Windows.Forms.GroupBox();
            this.dgvw_GunlukDoluluk = new System.Windows.Forms.DataGridView();
            this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıSoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.çıkışTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunlukDolulukOraniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oasis_dbDataSet7 = new hotelOasis.DataSets.Oasis_dbDataSet7();
            this.gunlukDolulukOraniTableAdapter = new hotelOasis.DataSets.Oasis_dbDataSet7TableAdapters.GunlukDolulukOraniTableAdapter();
            this.pcr_Back = new System.Windows.Forms.PictureBox();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GunlukGelenlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oasis_dbDataSet2)).BeginInit();
            this.grpbx1.SuspendLayout();
            this.grpbx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_GunlukDoluluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukDolulukOraniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oasis_dbDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // GunlukGelenlerBindingSource
            // 
            this.GunlukGelenlerBindingSource.DataMember = "GunlukGelenler";
            this.GunlukGelenlerBindingSource.DataSource = this.Oasis_dbDataSet2;
            // 
            // Oasis_dbDataSet2
            // 
            this.Oasis_dbDataSet2.DataSetName = "Oasis_dbDataSet2";
            this.Oasis_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_GunlukDoluluk
            // 
            this.btn_GunlukDoluluk.BackColor = System.Drawing.Color.Transparent;
            this.btn_GunlukDoluluk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GunlukDoluluk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GunlukDoluluk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_GunlukDoluluk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_GunlukDoluluk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GunlukDoluluk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_GunlukDoluluk.ForeColor = System.Drawing.Color.White;
            this.btn_GunlukDoluluk.Location = new System.Drawing.Point(391, 54);
            this.btn_GunlukDoluluk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GunlukDoluluk.Name = "btn_GunlukDoluluk";
            this.btn_GunlukDoluluk.Size = new System.Drawing.Size(197, 36);
            this.btn_GunlukDoluluk.TabIndex = 1;
            this.btn_GunlukDoluluk.Text = " Günlük Doluluk Oranı:";
            this.btn_GunlukDoluluk.UseVisualStyleBackColor = false;
            this.btn_GunlukDoluluk.Click += new System.EventHandler(this.btn_GunlukDoluluk_Click);
            this.btn_GunlukDoluluk.MouseLeave += new System.EventHandler(this.btn_GunlukDoluluk_MouseLeave);
            this.btn_GunlukDoluluk.MouseHover += new System.EventHandler(this.btn_GunlukDoluluk_MouseHover);
            // 
            // btn_GunlukGelenler
            // 
            this.btn_GunlukGelenler.BackColor = System.Drawing.Color.Transparent;
            this.btn_GunlukGelenler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GunlukGelenler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GunlukGelenler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_GunlukGelenler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_GunlukGelenler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GunlukGelenler.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_GunlukGelenler.ForeColor = System.Drawing.Color.White;
            this.btn_GunlukGelenler.Location = new System.Drawing.Point(148, 52);
            this.btn_GunlukGelenler.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GunlukGelenler.Name = "btn_GunlukGelenler";
            this.btn_GunlukGelenler.Size = new System.Drawing.Size(197, 36);
            this.btn_GunlukGelenler.TabIndex = 0;
            this.btn_GunlukGelenler.Text = "Günlük Gelenler Raporu:";
            this.btn_GunlukGelenler.UseVisualStyleBackColor = false;
            this.btn_GunlukGelenler.Click += new System.EventHandler(this.btn_GunlukGelenler_Click);
            this.btn_GunlukGelenler.MouseLeave += new System.EventHandler(this.btn_GunlukGelenler_MouseLeave);
            this.btn_GunlukGelenler.MouseHover += new System.EventHandler(this.btn_GunlukGelenler_MouseHover);
            // 
            // grpbx1
            // 
            this.grpbx1.BackColor = System.Drawing.Color.Transparent;
            this.grpbx1.Controls.Add(this.rpvw_GunlukGelenler);
            this.grpbx1.Location = new System.Drawing.Point(24, 93);
            this.grpbx1.Margin = new System.Windows.Forms.Padding(2);
            this.grpbx1.Name = "grpbx1";
            this.grpbx1.Padding = new System.Windows.Forms.Padding(2);
            this.grpbx1.Size = new System.Drawing.Size(748, 169);
            this.grpbx1.TabIndex = 53;
            this.grpbx1.TabStop = false;
            this.grpbx1.Text = "Günlük Gelenler Raporu:";
            this.grpbx1.Visible = false;
            // 
            // rpvw_GunlukGelenler
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GunlukGelenlerBindingSource;
            this.rpvw_GunlukGelenler.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvw_GunlukGelenler.LocalReport.ReportEmbeddedResource = "hotelOasis.GunlukGelenler.rdlc";
            this.rpvw_GunlukGelenler.Location = new System.Drawing.Point(9, 17);
            this.rpvw_GunlukGelenler.Margin = new System.Windows.Forms.Padding(2);
            this.rpvw_GunlukGelenler.Name = "rpvw_GunlukGelenler";
            this.rpvw_GunlukGelenler.ServerReport.BearerToken = null;
            this.rpvw_GunlukGelenler.Size = new System.Drawing.Size(721, 138);
            this.rpvw_GunlukGelenler.TabIndex = 0;
            // 
            // GunlukGelenlerTableAdapter
            // 
            this.GunlukGelenlerTableAdapter.ClearBeforeFill = true;
            // 
            // grpbx2
            // 
            this.grpbx2.BackColor = System.Drawing.Color.Transparent;
            this.grpbx2.Controls.Add(this.dgvw_GunlukDoluluk);
            this.grpbx2.Location = new System.Drawing.Point(24, 93);
            this.grpbx2.Margin = new System.Windows.Forms.Padding(2);
            this.grpbx2.Name = "grpbx2";
            this.grpbx2.Padding = new System.Windows.Forms.Padding(2);
            this.grpbx2.Size = new System.Drawing.Size(748, 169);
            this.grpbx2.TabIndex = 59;
            this.grpbx2.TabStop = false;
            this.grpbx2.Text = "Günlük Doluluk Oranı";
            // 
            // dgvw_GunlukDoluluk
            // 
            this.dgvw_GunlukDoluluk.AllowUserToAddRows = false;
            this.dgvw_GunlukDoluluk.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            this.dgvw_GunlukDoluluk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvw_GunlukDoluluk.AutoGenerateColumns = false;
            this.dgvw_GunlukDoluluk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvw_GunlukDoluluk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_GunlukDoluluk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaNoDataGridViewTextBoxColumn,
            this.adıSoyadıDataGridViewTextBoxColumn,
            this.çıkışTarihiDataGridViewTextBoxColumn});
            this.dgvw_GunlukDoluluk.DataSource = this.gunlukDolulukOraniBindingSource;
            this.dgvw_GunlukDoluluk.GridColor = System.Drawing.Color.DarkSalmon;
            this.dgvw_GunlukDoluluk.Location = new System.Drawing.Point(9, 18);
            this.dgvw_GunlukDoluluk.Name = "dgvw_GunlukDoluluk";
            this.dgvw_GunlukDoluluk.ReadOnly = true;
            this.dgvw_GunlukDoluluk.RowHeadersWidth = 51;
            this.dgvw_GunlukDoluluk.Size = new System.Drawing.Size(734, 115);
            this.dgvw_GunlukDoluluk.TabIndex = 42;
            // 
            // odaNoDataGridViewTextBoxColumn
            // 
            this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "Oda No";
            this.odaNoDataGridViewTextBoxColumn.HeaderText = "Oda No";
            this.odaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
            this.odaNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adıSoyadıDataGridViewTextBoxColumn
            // 
            this.adıSoyadıDataGridViewTextBoxColumn.DataPropertyName = "Adı Soyadı";
            this.adıSoyadıDataGridViewTextBoxColumn.HeaderText = "Adı Soyadı";
            this.adıSoyadıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adıSoyadıDataGridViewTextBoxColumn.Name = "adıSoyadıDataGridViewTextBoxColumn";
            this.adıSoyadıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // çıkışTarihiDataGridViewTextBoxColumn
            // 
            this.çıkışTarihiDataGridViewTextBoxColumn.DataPropertyName = "Çıkış Tarihi";
            this.çıkışTarihiDataGridViewTextBoxColumn.HeaderText = "Çıkış Tarihi";
            this.çıkışTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.çıkışTarihiDataGridViewTextBoxColumn.Name = "çıkışTarihiDataGridViewTextBoxColumn";
            this.çıkışTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gunlukDolulukOraniBindingSource
            // 
            this.gunlukDolulukOraniBindingSource.DataMember = "GunlukDolulukOrani";
            this.gunlukDolulukOraniBindingSource.DataSource = this.oasis_dbDataSet7;
            // 
            // oasis_dbDataSet7
            // 
            this.oasis_dbDataSet7.DataSetName = "Oasis_dbDataSet7";
            this.oasis_dbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunlukDolulukOraniTableAdapter
            // 
            this.gunlukDolulukOraniTableAdapter.ClearBeforeFill = true;
            // 
            // pcr_Back
            // 
            this.pcr_Back.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Back.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Back.Image")));
            this.pcr_Back.Location = new System.Drawing.Point(12, 17);
            this.pcr_Back.Name = "pcr_Back";
            this.pcr_Back.Size = new System.Drawing.Size(32, 21);
            this.pcr_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Back.TabIndex = 61;
            this.pcr_Back.TabStop = false;
            this.pcr_Back.Click += new System.EventHandler(this.pcr_Back_Click);
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.Image")));
            this.pcr_Exit.Location = new System.Drawing.Point(735, 17);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(32, 21);
            this.pcr_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Exit.TabIndex = 60;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // FrmCalisanRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 356);
            this.Controls.Add(this.pcr_Back);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.grpbx2);
            this.Controls.Add(this.btn_GunlukDoluluk);
            this.Controls.Add(this.btn_GunlukGelenler);
            this.Controls.Add(this.grpbx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCalisanRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCalisanRapor";
            this.Load += new System.EventHandler(this.FrmCalisanRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GunlukGelenlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oasis_dbDataSet2)).EndInit();
            this.grpbx1.ResumeLayout(false);
            this.grpbx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_GunlukDoluluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukDolulukOraniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oasis_dbDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_GunlukDoluluk;
        private System.Windows.Forms.Button btn_GunlukGelenler;
        private System.Windows.Forms.GroupBox grpbx1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvw_GunlukGelenler;
        private System.Windows.Forms.BindingSource GunlukGelenlerBindingSource;
        private DataSets.Oasis_dbDataSet2 Oasis_dbDataSet2;
        private DataSets.Oasis_dbDataSet2TableAdapters.GunlukGelenlerTableAdapter GunlukGelenlerTableAdapter;
        private System.Windows.Forms.GroupBox grpbx2;
        private System.Windows.Forms.DataGridView dgvw_GunlukDoluluk;
        private DataSets.Oasis_dbDataSet7 oasis_dbDataSet7;
        private System.Windows.Forms.BindingSource gunlukDolulukOraniBindingSource;
        private DataSets.Oasis_dbDataSet7TableAdapters.GunlukDolulukOraniTableAdapter gunlukDolulukOraniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn çıkışTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pcr_Back;
        private System.Windows.Forms.PictureBox pcr_Exit;
    }
}