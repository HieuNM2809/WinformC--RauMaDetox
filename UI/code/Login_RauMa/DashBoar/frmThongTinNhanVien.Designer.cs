
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
            this.lbTimKiem = new System.Windows.Forms.Label();
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
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.cbbChucDanh = new System.Windows.Forms.ComboBox();
            this.cbbLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbChucDanh = new System.Windows.Forms.Label();
            this.lbLoaiNV = new System.Windows.Forms.Label();
            this.grHinhNhanVien = new System.Windows.Forms.GroupBox();
            this.picNhanVien = new System.Windows.Forms.PictureBox();
            this.grTTNV = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.pnThongTinNV = new System.Windows.Forms.Panel();
            this.pnHinhAnh = new System.Windows.Forms.Panel();
            this.pnThongtinThem = new System.Windows.Forms.Panel();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.pndtgv = new System.Windows.Forms.Panel();
            this.pnTimKiem = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grTTT.SuspendLayout();
            this.grHinhNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.grTTNV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnThongTinNV.SuspendLayout();
            this.pnHinhAnh.SuspendLayout();
            this.pnThongtinThem.SuspendLayout();
            this.pnChucNang.SuspendLayout();
            this.pndtgv.SuspendLayout();
            this.pnTimKiem.SuspendLayout();
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
            this.dgvThongTinNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThongTinNhanVien.GridColor = System.Drawing.Color.Silver;
            this.dgvThongTinNhanVien.Location = new System.Drawing.Point(0, 89);
            this.dgvThongTinNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThongTinNhanVien.Name = "dgvThongTinNhanVien";
            this.dgvThongTinNhanVien.RowHeadersWidth = 62;
            this.dgvThongTinNhanVien.RowTemplate.Height = 28;
            this.dgvThongTinNhanVien.Size = new System.Drawing.Size(1269, 263);
            this.dgvThongTinNhanVien.TabIndex = 18;
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
            this.clChucDanh.Visible = false;
            // 
            // clLoaiNV
            // 
            this.clLoaiNV.DataPropertyName = "LoaiNV";
            this.clLoaiNV.FillWeight = 123.9504F;
            this.clLoaiNV.HeaderText = "Loại nhân viên";
            this.clLoaiNV.Items.AddRange(new object[] {
            "Part time",
            "Full time"});
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
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.ForeColor = System.Drawing.Color.White;
            this.lbTimKiem.Location = new System.Drawing.Point(45, 32);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(97, 25);
            this.lbTimKiem.TabIndex = 5;
            this.lbTimKiem.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(167, 34);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(198, 26);
            this.txtTimKiem.TabIndex = 16;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radHoTen);
            this.groupBox6.Controls.Add(this.radID);
            this.groupBox6.Location = new System.Drawing.Point(429, 21);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(713, 42);
            this.groupBox6.TabIndex = 15;
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1245, 129);
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
            this.btnThoat.Location = new System.Drawing.Point(935, 41);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 62);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseLeave += new System.EventHandler(this.btnThoat_MouseLeave);
            this.btnThoat.MouseHover += new System.EventHandler(this.btnThoat_MouseHover);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(96, 32);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 71);
            this.btnThem.TabIndex = 10;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.MouseLeave += new System.EventHandler(this.btnThem_MouseLeave);
            this.btnThem.MouseHover += new System.EventHandler(this.btnThem_MouseHover);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(314, 32);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 71);
            this.btnSua.TabIndex = 11;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnSua.MouseLeave += new System.EventHandler(this.btnSua_MouseLeave);
            this.btnSua.MouseHover += new System.EventHandler(this.btnSua_MouseHover);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(738, 35);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(102, 68);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.btnLamMoi.MouseLeave += new System.EventHandler(this.btnLamMoi_MouseLeave);
            this.btnLamMoi.MouseHover += new System.EventHandler(this.btnLamMoi_MouseHover);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(529, 32);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 71);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.MouseLeave += new System.EventHandler(this.btnXoa_MouseLeave);
            this.btnXoa.MouseHover += new System.EventHandler(this.btnXoa_MouseHover);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(371, 32);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(52, 32);
            this.btnTimKiem.TabIndex = 17;
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
            this.grTTT.Controls.Add(this.lbTrangThai);
            this.grTTT.Controls.Add(this.lbChucDanh);
            this.grTTT.Controls.Add(this.lbLoaiNV);
            this.grTTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTT.ForeColor = System.Drawing.Color.White;
            this.grTTT.Location = new System.Drawing.Point(0, 0);
            this.grTTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grTTT.Name = "grTTT";
            this.grTTT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grTTT.Size = new System.Drawing.Size(337, 147);
            this.grTTT.TabIndex = 2;
            this.grTTT.TabStop = false;
            this.grTTT.Text = "Thông tin thêm";
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Checked = true;
            this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrangThai.ForeColor = System.Drawing.Color.White;
            this.chkTrangThai.Location = new System.Drawing.Point(165, 33);
            this.chkTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(138, 30);
            this.chkTrangThai.TabIndex = 33;
            this.chkTrangThai.Text = "Hoạt động";
            this.chkTrangThai.UseVisualStyleBackColor = true;
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
            // cbbLoaiNhanVien
            // 
            this.cbbLoaiNhanVien.BackColor = System.Drawing.Color.White;
            this.cbbLoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiNhanVien.FormattingEnabled = true;
            this.cbbLoaiNhanVien.Items.AddRange(new object[] {
            "Part time",
            "Full time"});
            this.cbbLoaiNhanVien.Location = new System.Drawing.Point(165, 72);
            this.cbbLoaiNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLoaiNhanVien.Name = "cbbLoaiNhanVien";
            this.cbbLoaiNhanVien.Size = new System.Drawing.Size(138, 28);
            this.cbbLoaiNhanVien.TabIndex = 9;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.White;
            this.lbTrangThai.Location = new System.Drawing.Point(22, 41);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(103, 25);
            this.lbTrangThai.TabIndex = 30;
            this.lbTrangThai.Text = "Trạng Thái";
            // 
            // lbChucDanh
            // 
            this.lbChucDanh.AutoSize = true;
            this.lbChucDanh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucDanh.ForeColor = System.Drawing.Color.White;
            this.lbChucDanh.Location = new System.Drawing.Point(22, 110);
            this.lbChucDanh.Name = "lbChucDanh";
            this.lbChucDanh.Size = new System.Drawing.Size(103, 25);
            this.lbChucDanh.TabIndex = 28;
            this.lbChucDanh.Text = "Chức danh";
            // 
            // lbLoaiNV
            // 
            this.lbLoaiNV.AutoSize = true;
            this.lbLoaiNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiNV.ForeColor = System.Drawing.Color.White;
            this.lbLoaiNV.Location = new System.Drawing.Point(22, 74);
            this.lbLoaiNV.Name = "lbLoaiNV";
            this.lbLoaiNV.Size = new System.Drawing.Size(136, 25);
            this.lbLoaiNV.TabIndex = 29;
            this.lbLoaiNV.Text = "Loại nhân viên";
            // 
            // grHinhNhanVien
            // 
            this.grHinhNhanVien.Controls.Add(this.picNhanVien);
            this.grHinhNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grHinhNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHinhNhanVien.ForeColor = System.Drawing.Color.White;
            this.grHinhNhanVien.Location = new System.Drawing.Point(0, 0);
            this.grHinhNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grHinhNhanVien.Name = "grHinhNhanVien";
            this.grHinhNhanVien.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grHinhNhanVien.Size = new System.Drawing.Size(310, 193);
            this.grHinhNhanVien.TabIndex = 1;
            this.grHinhNhanVien.TabStop = false;
            this.grHinhNhanVien.Text = "Hình Nhân Viên";
            // 
            // picNhanVien
            // 
            this.picNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNhanVien.Location = new System.Drawing.Point(19, 25);
            this.picNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(260, 150);
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
            this.grTTNV.Controls.Add(this.lbID);
            this.grTTNV.Controls.Add(this.lbHoTen);
            this.grTTNV.Controls.Add(this.lbEmail);
            this.grTTNV.Controls.Add(this.lbNgaySinh);
            this.grTTNV.Controls.Add(this.lbMatKhau);
            this.grTTNV.Controls.Add(this.lbGioiTinh);
            this.grTTNV.Controls.Add(this.lbTaiKhoan);
            this.grTTNV.Controls.Add(this.lbSDT);
            this.grTTNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTNV.ForeColor = System.Drawing.Color.White;
            this.grTTNV.Location = new System.Drawing.Point(0, 0);
            this.grTTNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grTTNV.Name = "grTTNV";
            this.grTTNV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grTTNV.Size = new System.Drawing.Size(883, 359);
            this.grTTNV.TabIndex = 0;
            this.grTTNV.TabStop = false;
            this.grTTNV.Text = "Thông Tin Nhân Viên";
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
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 240);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 25);
            this.txtEmail.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(480, 288);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(206, 25);
            this.txtMatKhau.TabIndex = 8;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Enabled = false;
            this.txtTaiKhoan.Location = new System.Drawing.Point(146, 288);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(155, 25);
            this.txtTaiKhoan.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(146, 192);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(155, 25);
            this.txtSDT.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(146, 149);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(155, 29);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(480, 58);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(206, 25);
            this.txtHoTen.TabIndex = 2;
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
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(36, 52);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(31, 25);
            this.lbID.TabIndex = 23;
            this.lbID.Text = "ID";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.ForeColor = System.Drawing.Color.White;
            this.lbHoTen.Location = new System.Drawing.Point(374, 58);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(70, 25);
            this.lbHoTen.TabIndex = 24;
            this.lbHoTen.Text = "Họ tên";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(36, 241);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(58, 25);
            this.lbEmail.TabIndex = 30;
            this.lbEmail.Text = "Email";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.ForeColor = System.Drawing.Color.White;
            this.lbNgaySinh.Location = new System.Drawing.Point(33, 149);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(97, 25);
            this.lbNgaySinh.TabIndex = 25;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lbMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.ForeColor = System.Drawing.Color.White;
            this.lbMatKhau.Location = new System.Drawing.Point(363, 288);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(93, 25);
            this.lbMatKhau.TabIndex = 29;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.ForeColor = System.Drawing.Color.White;
            this.lbGioiTinh.Location = new System.Drawing.Point(36, 102);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(85, 25);
            this.lbGioiTinh.TabIndex = 26;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lbTaiKhoan.Location = new System.Drawing.Point(36, 288);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(94, 25);
            this.lbTaiKhoan.TabIndex = 28;
            this.lbTaiKhoan.Text = "Tài khoản";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.Color.White;
            this.lbSDT.Location = new System.Drawing.Point(36, 192);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(45, 25);
            this.lbSDT.TabIndex = 27;
            this.lbSDT.Text = "SDT";
            // 
            // pnThongTinNV
            // 
            this.pnThongTinNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnThongTinNV.AutoSize = true;
            this.pnThongTinNV.Controls.Add(this.grTTNV);
            this.pnThongTinNV.Location = new System.Drawing.Point(12, 59);
            this.pnThongTinNV.Name = "pnThongTinNV";
            this.pnThongTinNV.Size = new System.Drawing.Size(883, 359);
            this.pnThongTinNV.TabIndex = 11;
            // 
            // pnHinhAnh
            // 
            this.pnHinhAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnHinhAnh.Controls.Add(this.grHinhNhanVien);
            this.pnHinhAnh.Location = new System.Drawing.Point(910, 60);
            this.pnHinhAnh.Name = "pnHinhAnh";
            this.pnHinhAnh.Size = new System.Drawing.Size(310, 193);
            this.pnHinhAnh.TabIndex = 12;
            // 
            // pnThongtinThem
            // 
            this.pnThongtinThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnThongtinThem.Controls.Add(this.grTTT);
            this.pnThongtinThem.Location = new System.Drawing.Point(910, 271);
            this.pnThongtinThem.Name = "pnThongtinThem";
            this.pnThongtinThem.Size = new System.Drawing.Size(337, 147);
            this.pnThongtinThem.TabIndex = 13;
            // 
            // pnChucNang
            // 
            this.pnChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnChucNang.Controls.Add(this.groupBox1);
            this.pnChucNang.Location = new System.Drawing.Point(12, 466);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(1245, 129);
            this.pnChucNang.TabIndex = 14;
            // 
            // pndtgv
            // 
            this.pndtgv.Controls.Add(this.pnTimKiem);
            this.pndtgv.Controls.Add(this.dgvThongTinNhanVien);
            this.pndtgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pndtgv.Location = new System.Drawing.Point(0, 707);
            this.pndtgv.Name = "pndtgv";
            this.pndtgv.Size = new System.Drawing.Size(1269, 352);
            this.pndtgv.TabIndex = 15;
            // 
            // pnTimKiem
            // 
            this.pnTimKiem.Controls.Add(this.txtTimKiem);
            this.pnTimKiem.Controls.Add(this.lbTimKiem);
            this.pnTimKiem.Controls.Add(this.btnTimKiem);
            this.pnTimKiem.Controls.Add(this.groupBox6);
            this.pnTimKiem.Location = new System.Drawing.Point(33, 3);
            this.pnTimKiem.Name = "pnTimKiem";
            this.pnTimKiem.Size = new System.Drawing.Size(1193, 81);
            this.pnTimKiem.TabIndex = 9;
            // 
            // frmThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1269, 1059);
            this.Controls.Add(this.pndtgv);
            this.Controls.Add(this.pnChucNang);
            this.Controls.Add(this.pnThongtinThem);
            this.Controls.Add(this.pnHinhAnh);
            this.Controls.Add(this.pnThongTinNV);
            this.Controls.Add(this.label13);
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
            this.pnThongTinNV.ResumeLayout(false);
            this.pnHinhAnh.ResumeLayout(false);
            this.pnThongtinThem.ResumeLayout(false);
            this.pnChucNang.ResumeLayout(false);
            this.pndtgv.ResumeLayout(false);
            this.pnTimKiem.ResumeLayout(false);
            this.pnTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTimKiem;
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
        private System.Windows.Forms.OpenFileDialog ofdimgNhanVien;
        private System.Windows.Forms.GroupBox grTTT;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.ComboBox cbbChucDanh;
        private System.Windows.Forms.ComboBox cbbLoaiNhanVien;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbChucDanh;
        private System.Windows.Forms.Label lbLoaiNV;
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
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbSDT;
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
        private System.Windows.Forms.Panel pnThongTinNV;
        private System.Windows.Forms.Panel pnHinhAnh;
        private System.Windows.Forms.Panel pnThongtinThem;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.Panel pndtgv;
        private System.Windows.Forms.Panel pnTimKiem;
        private System.Windows.Forms.DataGridView dgvThongTinNhanVien;
    }
}