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
                MessageBox.Show("chưa nhập thông tin hoặc ngày tháng sai ", "Thông báo");


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

            try
            {
                txtID.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dtpNgaySinh.Text = row.Cells["colNgaySinh"].Value.ToString();
                if (row.Cells[3].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
                cbbChucDanh.Text = row.Cells["colLop"].FormattedValue.ToString();
                cbbLoaiNhanVien.Text = row.Cells["colLoaiNV"].FormattedValue.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
                txtTaiKhoan.Text = row.Cells[7].Value.ToString();
                txtMatKhau.Text = row.Cells[8].Value.ToString();
                txtEmail.Text = row.Cells[9].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
