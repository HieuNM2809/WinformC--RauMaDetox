using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DashBoar
{
    public partial class frmThongTinNhanVien : Form
    {
        private NhanVienBUS _NhanVienBUS = new NhanVienBUS();   


        public frmThongTinNhanVien()
        {
            InitializeComponent();
            // Đổ dữ liệu vào combobox
            cbbLoaiNhanVien.DataSource = _NhanVienBUS.LayDSNhanVien();
            cbbLoaiNhanVien.DisplayMember = "LoaiNV";
            cbbLoaiNhanVien.ValueMember = "LoaiNV";

            cbbChucDanh.DataSource = _NhanVienBUS.LayDSNhanVien();
            cbbChucDanh.DisplayMember = "ChucDanh";
            cbbChucDanh.ValueMember = "ChucDanh";

        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            clChucDanh.DataSource = _NhanVienBUS.LayDSNhanVien();
            clChucDanh.DisplayMember = "ChucDanh";
            clChucDanh.ValueMember = "ChucDanh";

            clLoaiNV.DataSource = _NhanVienBUS.LayDSNhanVien();
            clLoaiNV.DisplayMember = "LoaiNV";
            clLoaiNV.ValueMember = "LoaiNV";


            dgvThongTinNhanVien.DataSource = _NhanVienBUS.LayDSNhanVien();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "" || txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || dtpNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");


            }
            else
            {
                if (_NhanVienBUS.KiemTraNhanVien(txtID.Text))
                {
                    MessageBox.Show("MSSV đã tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    NhanVienDTO nv = new NhanVienDTO
                    {
                        ID_NV = txtID.Text,
                        HoTen = txtHoTen.Text,
                        NgaySinh = dtpNgaySinh.Value,
                        GioiTinh = radNam.Text,
                        ChucDanh = cbbChucDanh.Text,
                        LoaiNV = cbbLoaiNhanVien.Text,
                        SDT = txtSDT.Text,
                        TaiKhoan = txtTaiKhoan.Text,
                        MatKhau = txtMatKhau.Text,
                        Email = txtEmail.Text

                    };
                    if (_NhanVienBUS.ThemNV(nv))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmThongTinNhanVien_Load(sender, e);
                    }
                    else MessageBox.Show("Thêm Thất bại", "Thông báo");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO
            {
                ID_NV = txtID.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = radNam.Text,
                ChucDanh = cbbChucDanh.Text,
                LoaiNV = cbbLoaiNhanVien.Text,
                SDT = txtSDT.Text,
                TaiKhoan = txtTaiKhoan.Text,
                MatKhau = txtMatKhau.Text,
                Email = txtEmail.Text

            };
            if (_NhanVienBUS.CapNhatNV(nv))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmThongTinNhanVien_Load(sender, e);
            }
            else MessageBox.Show("Cập nhật thât bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvThongTinNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvThongTinNhanVien.Rows[dgvThongTinNhanVien.CurrentCell.RowIndex];
            int hang = e.RowIndex;
            try
            {
                txtID.Text = dgvThongTinNhanVien.Rows[hang].Cells[0].Value.ToString();
                txtHoTen.Text = dgvThongTinNhanVien.Rows[hang].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvThongTinNhanVien.Rows[hang].Cells[2].Value.ToString();
                if (dgvThongTinNhanVien.Rows[hang].Cells[3].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
                cbbChucDanh.Text = dgvThongTinNhanVien.Rows[hang].Cells[4].Value.ToString();
                cbbLoaiNhanVien.Text = dgvThongTinNhanVien.Rows[hang].Cells[5].Value.ToString();
                txtSDT.Text = dgvThongTinNhanVien.Rows[hang].Cells[6].Value.ToString();
                txtTaiKhoan.Text = dgvThongTinNhanVien.Rows[hang].Cells[7].Value.ToString();
                txtMatKhau.Text = dgvThongTinNhanVien.Rows[hang].Cells[8].Value.ToString();
                txtEmail.Text = dgvThongTinNhanVien.Rows[hang].Cells[9].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrTTNV in this.grTTNV.Controls)
            {
                if (ctrTTNV is TextBox )
                {
                    ctrTTNV.Text = "";
                }
            }
            dtpNgaySinh.Value = DateTime.Now;
            chkTrangThai.CheckState = CheckState.Checked;
            cbbChucDanh.SelectedIndex = 0;
            cbbLoaiNhanVien.SelectedIndex = 0;
            picHinhNhanVien.Image = null; 


        }
    }
}
