
namespace DashBoar
{
    partial class frmThongTinNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinNhanVien));
            this.dgvThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChucDanh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clLoaiNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radHoTen = new System.Windows.Forms.RadioButton();
            this.radID = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.ofdimgNhanVien = new System.Windows.Forms.OpenFileDialog();
            this.grTTT = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.cbbChucDanh = new System.Windows.Forms.ComboBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.grHinhNhanVien = new System.Windows.Forms.GroupBox();
            this.picNhanVien = new System.Windows.Forms.PictureBox();
            this.grTTNV = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grTTT.SuspendLayout();
            this.grHinhNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.grTTNV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinNhanVien
            // 
            this.dgvThongTinNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongTinNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTinNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clHoTen,
            this.clNgaySinh,
            this.clGioiTinh,
            this.clChucDanh,
            this.clLoaiNV,
            this.clSDT,
            this.clTaiKhoan,
            this.clMatKhau,
            this.clEmail,
            this.clHinh});
            this.dgvThongTinNhanVien.GridColor = System.Drawing.Color.Silver;
            this.dgvThongTinNhanVien.Location = new System.Drawing.Point(0, 625);
            this.dgvThongTinNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThongTinNhanVien.Name = "dgvThongTinNhanVien";
            this.dgvThongTinNhanVien.RowHeadersWidth = 62;
            this.dgvThongTinNhanVien.RowTemplate.Height = 28;
            this.dgvThongTinNhanVien.Size = new System.Drawing.Size(1215, 211);
            this.dgvThongTinNhanVien.TabIndex = 4;
            this.dgvThongTinNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinNhanVien_CellContentClick);
            // 
            // clID
            // 
            this.clID.DataPropertyName = "IDNV";
            this.clID.FillWeight = 53.8662F;
            this.clID.HeaderText = "ID";
            this.clID.MinimumWidth = 8;
            this.clID.Name = "clID";
            this.clID.Visible = false;
            // 
            // clHoTen
            // 
            this.clHoTen.DataPropertyName = "HoTen";
            this.clHoTen.FillWeight = 87.1276F;
            this.clHoTen.HeaderText = "Họ tên";
            this.clHoTen.MinimumWidth = 8;
            this.clHoTen.Name = "clHoTen";
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.DataPropertyName = "NgaySinh";
            this.clNgaySinh.FillWeight = 111.4715F;
            this.clNgaySinh.HeaderText = "Ngày sinh";
            this.clNgaySinh.MinimumWidth = 8;
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.Visible = false;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.DataPropertyName = "GioiTinh";
            this.clGioiTinh.FillWeight = 102.6667F;
            this.clGioiTinh.HeaderText = "Giới tính";
            this.clGioiTinh.MinimumWidth = 8;
            this.clGioiTinh.Name = "clGioiTinh";
            this.clGioiTinh.Visible = false;
            // 
            // clChucDanh
            // 
            this.clChucDanh.DataPropertyName = "ChucDanh";
            this.clChucDanh.FillWeight = 94.18014F;
            this.clChucDanh.HeaderText = "Chức danh";
            this.clChucDanh.MinimumWidth = 8;
            this.clChucDanh.Name = "clChucDanh";
            // 
            // clLoaiNV
            // 
            this.clLoaiNV.DataPropertyName = "LoaiNV";
            this.clLoaiNV.FillWeight = 123.9504F;
            this.clLoaiNV.HeaderText = "Loại nhân viên";
            this.clLoaiNV.MinimumWidth = 8;
            this.clLoaiNV.Name = "clLoaiNV";
            // 
            // clSDT
            // 
            this.clSDT.DataPropertyName = "SDT";
            this.clSDT.FillWeight = 82.05608F;
            this.clSDT.HeaderText = "SDT";
            this.clSDT.MinimumWidth = 8;
            this.clSDT.Name = "clSDT";
            this.clSDT.Visible = false;
            // 
            // clTaiKhoan
            // 
            this.clTaiKhoan.DataPropertyName = "TaiKhoan";
            this.clTaiKhoan.FillWeight = 126.6187F;
            this.clTaiKhoan.HeaderText = "Tài khoản";
            this.clTaiKhoan.MinimumWidth = 8;
            this.clTaiKhoan.Name = "clTaiKhoan";
            // 
            // clMatKhau
            // 
            this.clMatKhau.DataPropertyName = "MatKhau";
            this.clMatKhau.FillWeight = 123.9106F;
            this.clMatKhau.HeaderText = "Mật khẩu";
            this.clMatKhau.MinimumWidth = 8;
            this.clMatKhau.Name = "clMatKhau";
            // 
            // clEmail
            // 
            this.clEmail.DataPropertyName = "Email";
            this.clEmail.FillWeight = 94.15199F;
            this.clEmail.HeaderText = "Email";
            this.clEmail.MinimumWidth = 8;
            this.clEmail.Name = "clEmail";
            // 
            // clHinh
            // 
            this.clHinh.DataPropertyName = "Hinh";
            this.clHinh.HeaderText = "Hinh";
            this.clHinh.MinimumWidth = 8;
            this.clHinh.Name = "clHinh";
            this.clHinh.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(42, 556);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(145, 558);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(198, 26);
            this.txtTimKiem.TabIndex = 6;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radHoTen);
            this.groupBox6.Controls.Add(this.radID);
            this.groupBox6.Location = new System.Drawing.Point(407, 545);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(713, 42);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // radHoTen
            // 
            this.radHoTen.AutoSize = true;
            this.radHoTen.ForeColor = System.Drawing.Color.White;
            this.radHoTen.Location = new System.Drawing.Point(359, 14);
            this.radHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radHoTen.Name = "radHoTen";
            this.radHoTen.Size = new System.Drawing.Size(86, 24);
            this.radHoTen.TabIndex = 3;
            this.radHoTen.Text = "Họ Tên";
            this.radHoTen.UseVisualStyleBackColor = true;
            // 
            // radID
            // 
            this.radID.AutoSize = true;
            this.radID.Checked = true;
            this.radID.ForeColor = System.Drawing.Color.White;
            this.radID.Location = new System.Drawing.Point(51, 14);
            this.radID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radID.Name = "radID";
            this.radID.Size = new System.Drawing.Size(51, 24);
            this.radID.TabIndex = 2;
            this.radID.TabStop = true;
            this.radID.Text = "ID";
            this.radID.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkOrange;
            this.label13.Location = new System.Drawing.Point(502, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(297, 38);
            this.label13.TabIndex = 9;
            this.label13.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 430);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1170, 111);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(935, 32);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 62);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(106, 22);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 71);
            this.btnThem.TabIndex = 8;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(320, 22);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 71);
            this.btnSua.TabIndex = 9;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(737, 28);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(102, 68);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(542, 22);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 71);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(349, 556);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(52, 32);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // ofdimgNhanVien
            // 
            this.ofdimgNhanVien.FileName = "ofdimgNhanVien";
            // 
            // grTTT
            // 
            this.grTTT.Controls.Add(this.chkTrangThai);
            this.grTTT.Controls.Add(this.cbbChucDanh);
            this.grTTT.Controls.Add(this.cbbLoaiNhanVien);
            this.grTTT.Controls.Add(this.label11);
            this.grTTT.Controls.Add(this.label5);
            this.grTTT.Controls.Add(this.label6);
            this.grTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTT.ForeColor = System.Drawing.Color.White;
            this.grTTT.Location = new System.Drawing.Point(883, 262);
            this.grTTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grTTT.Name = "grTTT";
            this.grTTT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grTTT.Size = new System.Drawing.Size(316, 155);
            this.grTTT.TabIndex = 2;
            this.grTTT.TabStop = false;
            this.grTTT.Text = "Thông tin thêm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Loại nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Chức danh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(22, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Trạng Thái:";
            // 
            // cbbLoaiNhanVien
            // 
            this.cbbLoaiNhanVien.BackColor = System.Drawing.Color.White;
            this.cbbLoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiNhanVien.FormattingEnabled = true;
            this.cbbLoaiNhanVien.Items.AddRange(new object[] {
            "Partime",
            "fulltime"});
            this.cbbLoaiNhanVien.Location = new System.Drawing.Point(165, 72);
            this.cbbLoaiNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLoaiNhanVien.Name = "cbbLoaiNhanVien";
            this.cbbLoaiNhanVien.Size = new System.Drawing.Size(138, 28);
            this.cbbLoaiNhanVien.TabIndex = 31;
            // 
            // cbbChucDanh
            // 
            this.cbbChucDanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucDanh.Enabled = false;
            this.cbbChucDanh.FormattingEnabled = true;
            this.cbbChucDanh.Location = new System.Drawing.Point(165, 111);
            this.cbbChucDanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbChucDanh.Name = "cbbChucDanh";
            this.cbbChucDanh.Size = new System.Drawing.Size(138, 28);
            this.cbbChucDanh.TabIndex = 32;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Checked = true;
            this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrangThai.ForeColor = System.Drawing.Color.White;
            this.chkTrangThai.Location = new System.Drawing.Point(165, 36);
            this.chkTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(138, 30);
            this.chkTrangThai.TabIndex = 33;
            this.chkTrangThai.Text = "Hoạt động";
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // grHinhNhanVien
            // 
            this.grHinhNhanVien.Controls.Add(this.picNhanVien);
            this.grHinhNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHinhNhanVien.ForeColor = System.Drawing.Color.White;
            this.grHinhNhanVien.Location = new System.Drawing.Point(883, 51);
            this.grHinhNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grHinhNhanVien.Name = "grHinhNhanVien";
            this.grHinhNhanVien.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grHinhNhanVien.Size = new System.Drawing.Size(316, 188);
            this.grHinhNhanVien.TabIndex = 1;
            this.grHinhNhanVien.TabStop = false;
            this.grHinhNhanVien.Text = "Hình Nhân Viên";
            // 
            // picNhanVien
            // 
            this.picNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNhanVien.Location = new System.Drawing.Point(66, 39);
            this.picNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(180, 122);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhanVien.TabIndex = 1;
            this.picNhanVien.TabStop = false;
            this.picNhanVien.Click += new System.EventHandler(this.picNhanVien_Click);
            // 
            // grTTNV
            // 
            this.grTTNV.Controls.Add(this.groupBox2);
            this.grTTNV.Controls.Add(this.txtEmail);
            this.grTTNV.Controls.Add(this.txtMatKhau);
            this.grTTNV.Controls.Add(this.txtTaiKhoan);
            this.grTTNV.Controls.Add(this.txtSDT);
            this.grTTNV.Controls.Add(this.dtpNgaySinh);
            this.grTTNV.Controls.Add(this.txtHoTen);
            this.grTTNV.Controls.Add(this.txtID);
            this.grTTNV.Controls.Add(this.label1);
            this.grTTNV.Controls.Add(this.label2);
            this.grTTNV.Controls.Add(this.label10);
            this.grTTNV.Controls.Add(this.label3);
            this.grTTNV.Controls.Add(this.label9);
            this.grTTNV.Controls.Add(this.label4);
            this.grTTNV.Controls.Add(this.label8);
            this.grTTNV.Controls.Add(this.label7);
            this.grTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTNV.ForeColor = System.Drawing.Color.White;
            this.grTTNV.Location = new System.Drawing.Point(29, 51);
            this.grTTNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grTTNV.Name = "grTTNV";
            this.grTTNV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grTTNV.Size = new System.Drawing.Size(819, 366);
            this.grTTNV.TabIndex = 0;
            this.grTTNV.TabStop = false;
            this.grTTNV.Text = "Thông Tin Nhân Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "SDT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tài khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Giới tính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(363, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ngày sinh:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(36, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(374, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(146, 52);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 25);
            this.txtID.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(480, 58);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(206, 25);
            this.txtHoTen.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(146, 149);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(155, 29);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(146, 192);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(155, 25);
            this.txtSDT.TabIndex = 4;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(146, 288);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(155, 25);
            this.txtTaiKhoan.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(480, 288);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(206, 25);
            this.txtMatKhau.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 240);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 25);
            this.txtEmail.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radNu);
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(146, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(155, 45);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.ForeColor = System.Drawing.Color.White;
            this.radNam.Location = new System.Drawing.Point(15, 12);
            this.radNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(70, 24);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.ForeColor = System.Drawing.Color.White;
            this.radNu.Location = new System.Drawing.Point(83, 12);
            this.radNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(56, 24);
            this.radNu.TabIndex = 1;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // frmThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1215, 836);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvThongTinNhanVien);
            this.Controls.Add(this.grTTT);
            this.Controls.Add(this.grHinhNhanVien);
            this.Controls.Add(this.grTTNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongTinNhanVien";
            this.Text = "frmThongTinNhanVien";
            this.Load += new System.EventHandler(this.frmThongTinNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grTTT.ResumeLayout(false);
            this.grTTT.PerformLayout();
            this.grHinhNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            this.grTTNV.ResumeLayout(false);
            this.grTTNV.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvThongTinNhanVien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radHoTen;
        private System.Windows.Forms.RadioButton radID;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewComboBoxColumn clChucDanh;
        private System.Windows.Forms.DataGridViewComboBoxColumn clLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHinh;
        private System.Windows.Forms.OpenFileDialog ofdimgNhanVien;
        private System.Windows.Forms.GroupBox grTTT;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.ComboBox cbbChucDanh;
        private System.Windows.Forms.ComboBox cbbLoaiNhanVien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grHinhNhanVien;
        private System.Windows.Forms.PictureBox picNhanVien;
        private System.Windows.Forms.GroupBox grTTNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}