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
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idhoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGia = new System.Windows.Forms.Label();
            this.cbbTenSP = new System.Windows.Forms.ComboBox();
            this.lblso = new System.Windows.Forms.Label();
            this.lbl_tensp = new System.Windows.Forms.Label();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbGia = new System.Windows.Forms.ComboBox();
            this.lbl_tien = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTongTien = new System.Windows.Forms.RichTextBox();
            this.lbl_tong = new System.Windows.Forms.Label();
            this.lbl_tongtien = new System.Windows.Forms.Label();
            this.txtTongSoLuong = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_bo = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.AllowUserToAddRows = false;
            this.dgvDSHD.AllowUserToDeleteRows = false;
            this.dgvDSHD.AllowUserToOrderColumns = true;
            this.dgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Tensp,
            this.Gia,
            this.Masp,
            this.sol,
            this.sum,
            this.Idhoadon});
            this.dgvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHD.Location = new System.Drawing.Point(3, 3);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.ReadOnly = true;
            this.dgvDSHD.RowHeadersWidth = 51;
            this.dgvDSHD.RowTemplate.Height = 24;
            this.dgvDSHD.Size = new System.Drawing.Size(1159, 281);
            this.dgvDSHD.TabIndex = 0;
            this.dgvDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Tensp
            // 
            this.Tensp.DataPropertyName = "Tensp";
            this.Tensp.HeaderText = "Tên sản phẩm";
            this.Tensp.MinimumWidth = 6;
            this.Tensp.Name = "Tensp";
            this.Tensp.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "DonGia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // Masp
            // 
            this.Masp.DataPropertyName = "MASP";
            this.Masp.HeaderText = "Mã sản phẩm";
            this.Masp.MinimumWidth = 6;
            this.Masp.Name = "Masp";
            this.Masp.ReadOnly = true;
            this.Masp.Visible = false;
            // 
            // sol
            // 
            this.sol.DataPropertyName = "SoLuong";
            this.sol.HeaderText = "Số lương";
            this.sol.MinimumWidth = 6;
            this.sol.Name = "sol";
            this.sol.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.DataPropertyName = "TongTien";
            this.sum.HeaderText = "Tổng tiền";
            this.sum.MinimumWidth = 6;
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // Idhoadon
            // 
            this.Idhoadon.DataPropertyName = "IDHoaDon";
            this.Idhoadon.HeaderText = "ID Hòa Đơn";
            this.Idhoadon.MinimumWidth = 6;
            this.Idhoadon.Name = "Idhoadon";
            this.Idhoadon.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
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
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lblGia, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbbTenSP, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblso, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_tensp, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_soluong, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.numSoLuong, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbbGia, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_tien, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.627119F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.35593F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.74576F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(576, 118);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.White;
            this.lblGia.Location = new System.Drawing.Point(3, 87);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(272, 31);
            this.lblGia.TabIndex = 11;
            this.lblGia.Text = "Giá Tiền";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbTenSP
            // 
            this.cbbTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenSP.FormattingEnabled = true;
            this.cbbTenSP.Location = new System.Drawing.Point(281, 12);
            this.cbbTenSP.Name = "cbbTenSP";
            this.cbbTenSP.Size = new System.Drawing.Size(272, 28);
            this.cbbTenSP.TabIndex = 4;
            this.cbbTenSP.SelectedValueChanged += new System.EventHandler(this.cbbTenSP_SelectedValueChanged);
            // 
            // lblso
            // 
            this.lblso.AutoSize = true;
            this.lblso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblso.Location = new System.Drawing.Point(559, 46);
            this.lblso.Name = "lblso";
            this.lblso.Size = new System.Drawing.Size(14, 41);
            this.lblso.TabIndex = 2;
            this.lblso.Text = "label1";
            // 
            // lbl_tensp
            // 
            this.lbl_tensp.AutoSize = true;
            this.lbl_tensp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tensp.ForeColor = System.Drawing.Color.White;
            this.lbl_tensp.Location = new System.Drawing.Point(3, 9);
            this.lbl_tensp.Name = "lbl_tensp";
            this.lbl_tensp.Size = new System.Drawing.Size(272, 37);
            this.lbl_tensp.TabIndex = 1;
            this.lbl_tensp.Text = "Tên Sản Phẩm";
            this.lbl_tensp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soluong.ForeColor = System.Drawing.Color.White;
            this.lbl_soluong.Location = new System.Drawing.Point(3, 46);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(272, 41);
            this.lbl_soluong.TabIndex = 2;
            this.lbl_soluong.Text = "Số Lượng";
            this.lbl_soluong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(281, 49);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(272, 27);
            this.numSoLuong.TabIndex = 5;
            // 
            // cbbGia
            // 
            this.cbbGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGia.FormattingEnabled = true;
            this.cbbGia.Location = new System.Drawing.Point(281, 90);
            this.cbbGia.Name = "cbbGia";
            this.cbbGia.Size = new System.Drawing.Size(272, 28);
            this.cbbGia.TabIndex = 12;
            // 
            // lbl_tien
            // 
            this.lbl_tien.AutoSize = true;
            this.lbl_tien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lbl_tien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lbl_tien.Location = new System.Drawing.Point(559, 9);
            this.lbl_tien.Name = "lbl_tien";
            this.lbl_tien.Size = new System.Drawing.Size(14, 37);
            this.lbl_tien.TabIndex = 10;
            this.lbl_tien.Text = "label1";
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
            // txtTongTien
            // 
            this.txtTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongTien.Location = new System.Drawing.Point(291, 62);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(283, 53);
            this.txtTongTien.TabIndex = 9;
            this.txtTongTien.Text = "0";
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
            this.lbl_tong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lbl_tongtien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongSoLuong.Location = new System.Drawing.Point(291, 3);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.Size = new System.Drawing.Size(283, 53);
            this.txtTongSoLuong.TabIndex = 8;
            this.txtTongSoLuong.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button1.Location = new System.Drawing.Point(3, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(576, 105);
            this.button1.TabIndex = 2;
            this.button1.Text = "lạ nhà";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(577, 105);
            this.tableLayoutPanel5.TabIndex = 3;
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
            this.btn_bo.Text = "Bỏ món";
            this.btn_bo.UseVisualStyleBackColor = false;
            this.btn_bo.Click += new System.EventHandler(this.btn_bo_Click_1);
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
            this.btnXacNhan.Text = "Chọn món";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDSHD, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ma, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 327);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lbl_ma
            // 
            this.lbl_ma.AutoSize = true;
            this.lbl_ma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lbl_ma.Location = new System.Drawing.Point(3, 287);
            this.lbl_ma.Name = "lbl_ma";
            this.lbl_ma.Size = new System.Drawing.Size(46, 17);
            this.lbl_ma.TabIndex = 1;
            this.lbl_ma.Text = "label1";
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1165, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChiTietHoaDon";
            this.Text = "frmChiTietHoaDon";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbbTenSP;
        private System.Windows.Forms.Label lbl_tensp;
        private System.Windows.Forms.Label lbl_soluong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RichTextBox txtTongTien;
        private System.Windows.Forms.Label lbl_tong;
        private System.Windows.Forms.Label lbl_tongtien;
        private System.Windows.Forms.RichTextBox txtTongSoLuong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btn_bo;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.ComboBox cbbGia;
        private System.Windows.Forms.Label lbl_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idhoadon;
        private System.Windows.Forms.Label lbl_tien;
        private System.Windows.Forms.Label lblso;
    }
}