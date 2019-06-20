namespace QuanLyPhongMachTu
{
    partial class frmLapHoaDon
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
            this.grbThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvThongTinHoaDon = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtChiPhiKham = new System.Windows.Forms.TextBox();
            this.txtChiPhiThuoc = new System.Windows.Forms.TextBox();
            this.dgvThongTinChiTiet = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblChiPhiThuoc = new System.Windows.Forms.Label();
            this.lblChiPhiKham = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblTenBenhNhan = new System.Windows.Forms.Label();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.grbNhapThongTin = new System.Windows.Forms.GroupBox();
            this.cmbMaPhieuKham = new System.Windows.Forms.ComboBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lblMaPhieuKham = new System.Windows.Forms.Label();
            this.lblLapHoaDon = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbThaotac = new System.Windows.Forms.GroupBox();
            this.grbThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTiet)).BeginInit();
            this.grbNhapThongTin.SuspendLayout();
            this.grbThaotac.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTinChiTiet
            // 
            this.grbThongTinChiTiet.Controls.Add(this.dgvThongTinHoaDon);
            this.grbThongTinChiTiet.Controls.Add(this.txtChiPhiKham);
            this.grbThongTinChiTiet.Controls.Add(this.txtChiPhiThuoc);
            this.grbThongTinChiTiet.Controls.Add(this.dgvThongTinChiTiet);
            this.grbThongTinChiTiet.Controls.Add(this.txtTongTien);
            this.grbThongTinChiTiet.Controls.Add(this.lblTongTien);
            this.grbThongTinChiTiet.Controls.Add(this.lblChiPhiThuoc);
            this.grbThongTinChiTiet.Controls.Add(this.lblChiPhiKham);
            this.grbThongTinChiTiet.Controls.Add(this.lblMaHoaDon);
            this.grbThongTinChiTiet.Controls.Add(this.txtMaHoaDon);
            this.grbThongTinChiTiet.Controls.Add(this.lblTenBenhNhan);
            this.grbThongTinChiTiet.Controls.Add(this.txtTenBenhNhan);
            this.grbThongTinChiTiet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinChiTiet.Location = new System.Drawing.Point(7, 138);
            this.grbThongTinChiTiet.Name = "grbThongTinChiTiet";
            this.grbThongTinChiTiet.Size = new System.Drawing.Size(799, 335);
            this.grbThongTinChiTiet.TabIndex = 3;
            this.grbThongTinChiTiet.TabStop = false;
            this.grbThongTinChiTiet.Text = "Chi tiết";
            this.grbThongTinChiTiet.Enter += new System.EventHandler(this.grbThongTinChiTiet_Enter);
            // 
            // dgvThongTinHoaDon
            // 
            this.dgvThongTinHoaDon.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvThongTinHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvThongTinHoaDon.Location = new System.Drawing.Point(3, 186);
            this.dgvThongTinHoaDon.Name = "dgvThongTinHoaDon";
            this.dgvThongTinHoaDon.Size = new System.Drawing.Size(774, 133);
            this.dgvThongTinHoaDon.TabIndex = 15;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Mã hóa đơn";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Mã phiếu khám";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Chi chí khám";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Chi phí thuốc";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Tổng tiền";
            this.Column9.Name = "Column9";
            // 
            // txtChiPhiKham
            // 
            this.txtChiPhiKham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChiPhiKham.Location = new System.Drawing.Point(638, 116);
            this.txtChiPhiKham.Name = "txtChiPhiKham";
            this.txtChiPhiKham.ReadOnly = true;
            this.txtChiPhiKham.Size = new System.Drawing.Size(138, 23);
            this.txtChiPhiKham.TabIndex = 14;
            this.txtChiPhiKham.Text = "100000";
            // 
            // txtChiPhiThuoc
            // 
            this.txtChiPhiThuoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChiPhiThuoc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiPhiThuoc.Location = new System.Drawing.Point(638, 84);
            this.txtChiPhiThuoc.Name = "txtChiPhiThuoc";
            this.txtChiPhiThuoc.ReadOnly = true;
            this.txtChiPhiThuoc.Size = new System.Drawing.Size(138, 23);
            this.txtChiPhiThuoc.TabIndex = 13;
            this.txtChiPhiThuoc.TextChanged += new System.EventHandler(this.txtChiPhiThuoc_TextChanged);
            // 
            // dgvThongTinChiTiet
            // 
            this.dgvThongTinChiTiet.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvThongTinChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvThongTinChiTiet.Location = new System.Drawing.Point(3, 26);
            this.dgvThongTinChiTiet.Name = "dgvThongTinChiTiet";
            this.dgvThongTinChiTiet.Size = new System.Drawing.Size(485, 148);
            this.dgvThongTinChiTiet.TabIndex = 2;
            this.dgvThongTinChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Tên thuốc";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.Name = "Column4";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTongTien.Location = new System.Drawing.Point(638, 148);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(138, 23);
            this.txtTongTien.TabIndex = 9;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(515, 148);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(80, 16);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "Tổng tiền:";
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // lblChiPhiThuoc
            // 
            this.lblChiPhiThuoc.AutoSize = true;
            this.lblChiPhiThuoc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiPhiThuoc.Location = new System.Drawing.Point(515, 84);
            this.lblChiPhiThuoc.Name = "lblChiPhiThuoc";
            this.lblChiPhiThuoc.Size = new System.Drawing.Size(88, 16);
            this.lblChiPhiThuoc.TabIndex = 12;
            this.lblChiPhiThuoc.Text = "Tiền thuốc:";
            this.lblChiPhiThuoc.Click += new System.EventHandler(this.lblChiPhiThuoc_Click);
            // 
            // lblChiPhiKham
            // 
            this.lblChiPhiKham.AutoSize = true;
            this.lblChiPhiKham.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiPhiKham.Location = new System.Drawing.Point(515, 116);
            this.lblChiPhiKham.Name = "lblChiPhiKham";
            this.lblChiPhiKham.Size = new System.Drawing.Size(87, 16);
            this.lblChiPhiKham.TabIndex = 6;
            this.lblChiPhiKham.Text = "Tiền khám:";
            this.lblChiPhiKham.Click += new System.EventHandler(this.lblChiPhiKham_Click);
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(515, 26);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(96, 16);
            this.lblMaHoaDon.TabIndex = 4;
            this.lblMaHoaDon.Text = "Mã hóa đơn:";
            this.lblMaHoaDon.Click += new System.EventHandler(this.lblMaHoaDon_Click);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(638, 23);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(138, 23);
            this.txtMaHoaDon.TabIndex = 5;
            this.txtMaHoaDon.TextChanged += new System.EventHandler(this.mahoadon_TextChanged);
            // 
            // lblTenBenhNhan
            // 
            this.lblTenBenhNhan.AutoSize = true;
            this.lblTenBenhNhan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBenhNhan.Location = new System.Drawing.Point(515, 52);
            this.lblTenBenhNhan.Name = "lblTenBenhNhan";
            this.lblTenBenhNhan.Size = new System.Drawing.Size(119, 16);
            this.lblTenBenhNhan.TabIndex = 4;
            this.lblTenBenhNhan.Text = "Tên bệnh nhân:";
            this.lblTenBenhNhan.Click += new System.EventHandler(this.lblTenBenhNhan_Click);
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenBenhNhan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBenhNhan.Location = new System.Drawing.Point(638, 52);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.ReadOnly = true;
            this.txtTenBenhNhan.Size = new System.Drawing.Size(138, 23);
            this.txtTenBenhNhan.TabIndex = 3;
            this.txtTenBenhNhan.TextChanged += new System.EventHandler(this.tenBN_TextChanged);
            // 
            // grbNhapThongTin
            // 
            this.grbNhapThongTin.Controls.Add(this.cmbMaPhieuKham);
            this.grbNhapThongTin.Controls.Add(this.btnNhap);
            this.grbNhapThongTin.Controls.Add(this.lblMaPhieuKham);
            this.grbNhapThongTin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhapThongTin.Location = new System.Drawing.Point(7, 59);
            this.grbNhapThongTin.Name = "grbNhapThongTin";
            this.grbNhapThongTin.Size = new System.Drawing.Size(346, 73);
            this.grbNhapThongTin.TabIndex = 4;
            this.grbNhapThongTin.TabStop = false;
            this.grbNhapThongTin.Text = "Nhập";
            this.grbNhapThongTin.Enter += new System.EventHandler(this.grbNhapThongTin_Enter);
            // 
            // cmbMaPhieuKham
            // 
            this.cmbMaPhieuKham.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPhieuKham.FormattingEnabled = true;
            this.cmbMaPhieuKham.Location = new System.Drawing.Point(128, 32);
            this.cmbMaPhieuKham.Name = "cmbMaPhieuKham";
            this.cmbMaPhieuKham.Size = new System.Drawing.Size(121, 24);
            this.cmbMaPhieuKham.TabIndex = 11;
            this.cmbMaPhieuKham.SelectedIndexChanged += new System.EventHandler(this.cbbMaPhieuKham_SelectedIndexChanged);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNhap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(270, 28);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(61, 30);
            this.btnNhap.TabIndex = 10;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lblMaPhieuKham
            // 
            this.lblMaPhieuKham.AutoSize = true;
            this.lblMaPhieuKham.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuKham.Location = new System.Drawing.Point(6, 32);
            this.lblMaPhieuKham.Name = "lblMaPhieuKham";
            this.lblMaPhieuKham.Size = new System.Drawing.Size(122, 16);
            this.lblMaPhieuKham.TabIndex = 0;
            this.lblMaPhieuKham.Text = "Mã phiếu khám:";
            this.lblMaPhieuKham.Click += new System.EventHandler(this.MaPK_Click);
            // 
            // lblLapHoaDon
            // 
            this.lblLapHoaDon.AutoSize = true;
            this.lblLapHoaDon.BackColor = System.Drawing.Color.Gainsboro;
            this.lblLapHoaDon.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapHoaDon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLapHoaDon.Location = new System.Drawing.Point(309, 9);
            this.lblLapHoaDon.Name = "lblLapHoaDon";
            this.lblLapHoaDon.Size = new System.Drawing.Size(202, 29);
            this.lblLapHoaDon.TabIndex = 5;
            this.lblLapHoaDon.Text = "LẬP HÓA ĐƠN";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(44, 28);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 30);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(275, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 33);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(160, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grbThaotac
            // 
            this.grbThaotac.Controls.Add(this.btnThoat);
            this.grbThaotac.Controls.Add(this.btnLuu);
            this.grbThaotac.Controls.Add(this.btnXoa);
            this.grbThaotac.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThaotac.Location = new System.Drawing.Point(436, 59);
            this.grbThaotac.Name = "grbThaotac";
            this.grbThaotac.Size = new System.Drawing.Size(348, 73);
            this.grbThaotac.TabIndex = 6;
            this.grbThaotac.TabStop = false;
            this.grbThaotac.Text = "Thao tác";
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(814, 469);
            this.Controls.Add(this.grbThaotac);
            this.Controls.Add(this.lblLapHoaDon);
            this.Controls.Add(this.grbThongTinChiTiet);
            this.Controls.Add(this.grbNhapThongTin);
            this.Name = "frmLapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LẬP HÓA ĐƠN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLapHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThongTinChiTiet.ResumeLayout(false);
            this.grbThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTiet)).EndInit();
            this.grbNhapThongTin.ResumeLayout(false);
            this.grbNhapThongTin.PerformLayout();
            this.grbThaotac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinChiTiet;
        private System.Windows.Forms.GroupBox grbNhapThongTin;
        private System.Windows.Forms.ComboBox cmbMaPhieuKham;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTenBenhNhan;
        private System.Windows.Forms.Label lblChiPhiKham;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblMaPhieuKham;
        private System.Windows.Forms.Label lblChiPhiThuoc;
        private System.Windows.Forms.TextBox txtChiPhiThuoc;
        private System.Windows.Forms.DataGridView dgvThongTinChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtChiPhiKham;
        private System.Windows.Forms.DataGridView dgvThongTinHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label lblLapHoaDon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grbThaotac;
    }
}

