namespace DashBoar
{
    partial class frmChiTietHoaDon
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
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDSSP = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_tensp = new System.Windows.Forms.Label();
            this.cbbTenSP = new System.Windows.Forms.ComboBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbGia = new System.Windows.Forms.ComboBox();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ColIDHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ColMaSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ColTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ColSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ColTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemCTHD = new System.Windows.Forms.Button();
            this.lbl_tongtien = new System.Windows.Forms.Label();
            this.lbl_tong = new System.Windows.Forms.Label();
            this.btn_bo = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTongSoLuong = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._ColSTT,
            this._ColIDHoaDon,
            this._ColMaSp,
            this._ColTenSP,
            this._ColSoLuong,
            this._ColDonGia,
            this._ColTongTien});
            this.dgvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHD.Location = new System.Drawing.Point(3, 3);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.RowHeadersWidth = 51;
            this.dgvDSHD.RowTemplate.Height = 24;
            this.dgvDSHD.Size = new System.Drawing.Size(576, 318);
            this.dgvDSHD.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 51;
            // 
            // colTongTien
            // 
            this.colTongTien.Text = "Tổng Tiền";
            this.colTongTien.Width = 227;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Giá";
            this.colDonGia.Width = 132;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số Lượng";
            this.colSoLuong.Width = 79;
            // 
            // colTenSp
            // 
            this.colTenSp.Text = "Tên Nước";
            this.colTenSp.Width = 79;
            // 
            // lstDSSP
            // 
            this.lstDSSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenSp,
            this.colSoLuong,
            this.colDonGia,
            this.colTongTien});
            this.lstDSSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDSSP.FullRowSelect = true;
            this.lstDSSP.GridLines = true;
            this.lstDSSP.HideSelection = false;
            this.lstDSSP.Location = new System.Drawing.Point(585, 3);
            this.lstDSSP.Name = "lstDSSP";
            this.lstDSSP.Size = new System.Drawing.Size(577, 318);
            this.lstDSSP.TabIndex = 1;
            this.lstDSSP.UseCompatibleStateImageBehavior = false;
            this.lstDSSP.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThemCTHD, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 327);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.96443F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.03557F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1165, 235);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_tensp, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbbTenSP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.numSoLuong, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbbGia, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_soluong, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblGia, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(576, 118);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lbl_tensp
            // 
            this.lbl_tensp.AutoSize = true;
            this.lbl_tensp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tensp.ForeColor = System.Drawing.Color.White;
            this.lbl_tensp.Location = new System.Drawing.Point(3, 0);
            this.lbl_tensp.Name = "lbl_tensp";
            this.lbl_tensp.Size = new System.Drawing.Size(282, 39);
            this.lbl_tensp.TabIndex = 1;
            this.lbl_tensp.Text = "Tên Sản Phẩm";
            this.lbl_tensp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_tensp.Click += new System.EventHandler(this.lbl_tensp_Click);
            // 
            // cbbTenSP
            // 
            this.cbbTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenSP.FormattingEnabled = true;
            this.cbbTenSP.Location = new System.Drawing.Point(291, 3);
            this.cbbTenSP.Name = "cbbTenSP";
            this.cbbTenSP.Size = new System.Drawing.Size(282, 28);
            this.cbbTenSP.TabIndex = 4;
            this.cbbTenSP.SelectedValueChanged += new System.EventHandler(this.cbbTenSP_SelectedValueChanged);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(291, 42);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(282, 27);
            this.numSoLuong.TabIndex = 5;
            // 
            // cbbGia
            // 
            this.cbbGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGia.FormattingEnabled = true;
            this.cbbGia.Location = new System.Drawing.Point(291, 81);
            this.cbbGia.Name = "cbbGia";
            this.cbbGia.Size = new System.Drawing.Size(282, 28);
            this.cbbGia.TabIndex = 12;
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soluong.ForeColor = System.Drawing.Color.White;
            this.lbl_soluong.Location = new System.Drawing.Point(3, 39);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(282, 39);
            this.lbl_soluong.TabIndex = 2;
            this.lbl_soluong.Text = "Số Lượng";
            this.lbl_soluong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.White;
            this.lblGia.Location = new System.Drawing.Point(3, 78);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(282, 40);
            this.lblGia.TabIndex = 11;
            this.lblGia.Text = "Giá Tiền";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDSHD, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstDSSP, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 324);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // _ColSTT
            // 
            this._ColSTT.DataPropertyName = "STT";
            this._ColSTT.HeaderText = "STT";
            this._ColSTT.MinimumWidth = 6;
            this._ColSTT.Name = "_ColSTT";
            // 
            // _ColIDHoaDon
            // 
            this._ColIDHoaDon.DataPropertyName = "IDHoaDon";
            this._ColIDHoaDon.HeaderText = "ID Hóa Đơn";
            this._ColIDHoaDon.MinimumWidth = 6;
            this._ColIDHoaDon.Name = "_ColIDHoaDon";
            // 
            // _ColMaSp
            // 
            this._ColMaSp.DataPropertyName = "MaSp";
            this._ColMaSp.HeaderText = "Mã Sản Phẩm";
            this._ColMaSp.MinimumWidth = 6;
            this._ColMaSp.Name = "_ColMaSp";
            // 
            // _ColTenSP
            // 
            this._ColTenSP.DataPropertyName = "TenSp";
            this._ColTenSP.HeaderText = "Tên Sản Phẩm";
            this._ColTenSP.MinimumWidth = 6;
            this._ColTenSP.Name = "_ColTenSP";
            // 
            // _ColSoLuong
            // 
            this._ColSoLuong.DataPropertyName = "SoLuong";
            this._ColSoLuong.HeaderText = "Số Lượng";
            this._ColSoLuong.MinimumWidth = 6;
            this._ColSoLuong.Name = "_ColSoLuong";
            // 
            // _ColDonGia
            // 
            this._ColDonGia.DataPropertyName = "DonGia";
            this._ColDonGia.HeaderText = "Đơn Giá";
            this._ColDonGia.MinimumWidth = 6;
            this._ColDonGia.Name = "_ColDonGia";
            // 
            // _ColTongTien
            // 
            this._ColTongTien.DataPropertyName = "TongTien";
            this._ColTongTien.HeaderText = "Tổng Tiền";
            this._ColTongTien.MinimumWidth = 6;
            this._ColTongTien.Name = "_ColTongTien";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.White;
            this.btnXacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnXacNhan.Location = new System.Drawing.Point(3, 3);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(282, 99);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btn_bo, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnXacNhan, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(585, 127);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(577, 105);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // btnThemCTHD
            // 
            this.btnThemCTHD.BackColor = System.Drawing.Color.White;
            this.btnThemCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemCTHD.FlatAppearance.BorderSize = 0;
            this.btnThemCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCTHD.Image = global::DashBoar.Properties.Resources.plus;
            this.btnThemCTHD.Location = new System.Drawing.Point(3, 127);
            this.btnThemCTHD.Name = "btnThemCTHD";
            this.btnThemCTHD.Size = new System.Drawing.Size(576, 105);
            this.btnThemCTHD.TabIndex = 2;
            this.btnThemCTHD.UseVisualStyleBackColor = false;
            this.btnThemCTHD.Click += new System.EventHandler(this.btnThemCTHD_Click);
            // 
            // lbl_tongtien
            // 
            this.lbl_tongtien.AutoSize = true;
            this.lbl_tongtien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongtien.ForeColor = System.Drawing.Color.White;
            this.lbl_tongtien.Location = new System.Drawing.Point(3, 59);
            this.lbl_tongtien.Name = "lbl_tongtien";
            this.lbl_tongtien.Size = new System.Drawing.Size(282, 59);
            this.lbl_tongtien.TabIndex = 7;
            this.lbl_tongtien.Text = "Tổng Tiền";
            this.lbl_tongtien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_tong
            // 
            this.lbl_tong.AutoSize = true;
            this.lbl_tong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tong.ForeColor = System.Drawing.Color.White;
            this.lbl_tong.Location = new System.Drawing.Point(3, 0);
            this.lbl_tong.Name = "lbl_tong";
            this.lbl_tong.Size = new System.Drawing.Size(282, 59);
            this.lbl_tong.TabIndex = 6;
            this.lbl_tong.Text = "Tổng Số Lượng";
            this.lbl_tong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_bo
            // 
            this.btn_bo.BackColor = System.Drawing.Color.White;
            this.btn_bo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_bo.FlatAppearance.BorderSize = 0;
            this.btn_bo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_bo.Location = new System.Drawing.Point(291, 3);
            this.btn_bo.Name = "btn_bo";
            this.btn_bo.Size = new System.Drawing.Size(283, 99);
            this.btn_bo.TabIndex = 1;
            this.btn_bo.Text = "Bỏ chọn";
            this.btn_bo.UseVisualStyleBackColor = false;
            this.btn_bo.Click += new System.EventHandler(this.btn_bo_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txtTongTien, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tong, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tongtien, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtTongSoLuong, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(585, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(577, 118);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoLuong.Location = new System.Drawing.Point(291, 3);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.Size = new System.Drawing.Size(283, 27);
            this.txtTongSoLuong.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(291, 62);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(283, 27);
            this.txtTongTien.TabIndex = 11;
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1165, 562);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChiTietHoaDon";
            this.Text = "frmChiTietHoaDon";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTongTien;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colTenSp;
        private System.Windows.Forms.ListView lstDSSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbbTenSP;
        private System.Windows.Forms.Label lbl_tensp;
        private System.Windows.Forms.Label lbl_soluong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbbGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ColIDHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ColMaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ColTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ColSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ColTongTien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbl_tong;
        private System.Windows.Forms.Label lbl_tongtien;
        private System.Windows.Forms.TextBox txtTongSoLuong;
        private System.Windows.Forms.Button btnThemCTHD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btn_bo;
        private System.Windows.Forms.Button btnXacNhan;
    }
}