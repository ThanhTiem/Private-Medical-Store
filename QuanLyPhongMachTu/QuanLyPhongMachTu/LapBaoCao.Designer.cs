namespace QuanLyPhongMachTu
{
    partial class LapBaoCao
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
            this.BAOCAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLKBDataSet = new QuanLyPhongMachTu.QLKBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BAOCAOTableAdapter = new QuanLyPhongMachTu.QLKBDataSetTableAdapters.BAOCAOTableAdapter();
            this.lblLapBaoCao = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BAOCAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BAOCAOBindingSource
            // 
            this.BAOCAOBindingSource.DataMember = "BAOCAO";
            this.BAOCAOBindingSource.DataSource = this.QLKBDataSet;
            // 
            // QLKBDataSet
            // 
            this.QLKBDataSet.DataSetName = "QLKBDataSet";
            this.QLKBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.BAOCAOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyPhongMachTu.BaoCao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 119);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(673, 288);
            this.reportViewer1.TabIndex = 0;
            // 
            // BAOCAOTableAdapter
            // 
            this.BAOCAOTableAdapter.ClearBeforeFill = true;
            // 
            // lblLapBaoCao
            // 
            this.lblLapBaoCao.AutoSize = true;
            this.lblLapBaoCao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapBaoCao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLapBaoCao.Location = new System.Drawing.Point(201, 9);
            this.lblLapBaoCao.Name = "lblLapBaoCao";
            this.lblLapBaoCao.Size = new System.Drawing.Size(265, 32);
            this.lblLapBaoCao.TabIndex = 1;
            this.lblLapBaoCao.Text = "LẬP BÁO CÁO THÁNG";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(34, 80);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(55, 17);
            this.lblThang.TabIndex = 2;
            this.lblThang.Text = "Tháng :";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(234, 80);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(45, 17);
            this.lblNam.TabIndex = 3;
            this.lblNam.Text = "Năm :";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(95, 80);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 20);
            this.txtThang.TabIndex = 1;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(305, 80);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 20);
            this.txtNam.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.Location = new System.Drawing.Point(477, 80);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(608, 80);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // LapBaoCao
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(699, 417);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.lblLapBaoCao);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LapBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapBaoCao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LapBaoCao_FormClosing);
            this.Load += new System.EventHandler(this.LapBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BAOCAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BAOCAOBindingSource;
        private QLKBDataSet QLKBDataSet;
        private QLKBDataSetTableAdapters.BAOCAOTableAdapter BAOCAOTableAdapter;
        private System.Windows.Forms.Label lblLapBaoCao;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}