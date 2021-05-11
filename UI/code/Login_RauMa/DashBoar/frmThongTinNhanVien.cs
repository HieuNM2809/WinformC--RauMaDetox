using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        //    if(string.IsNullOrEmpty(txtID.Text)||string.IsNullOrEmpty(txtHoTen.Text)||string.IsNullOrEmpty(txtSDT.Text)||string.IsNullOrEmpty(txtEmail.Text)|| dtpNgaySinh.Value<= DateTime.Now)
        //    {
        //        NhanVienDTO nv = new NhanVienDTO
        //        {
        //           ID_NV= txtID.Text,
        //           HoTen= txtHoTen.Text,
        //           NgaySinh=dtpNgaySinh.Value,
        //           GioiTinh = "Nam",
        //           ChucDanh = cbbChucDanh.SelectedValue.ToString(),
        //           LoaiNV = cbbLoaiNhanVien.SelectedValue.ToString(),
        //           SDT = txtSDT.Text,
        //           TaiKhoan = txtTaiKhoan.Text,
        //           MatKhau = txtMatKhau.Text,
        //           Email = txtEmail.Text,


        //        };

        //        if(_NhanVienBUS.ThemNV(nv))
        //        {
        //            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            frmThongTinNhanVien_Load(sender, e);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        }
    }
}
