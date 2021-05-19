using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DashBoar
{
   
    public partial class FrmDangKiTaiKhoan : Form
    {
        private DangKiTaiKhoanBUS _DKTK = new DangKiTaiKhoanBUS();
        public FrmDangKiTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO
            {
                IDNV = txtID.Text,
                TaiKhoan = txtTenTruyCap.Text,
                MatKhau = txtMatKhau.Text

            };
            if (txtID.Text == "" || txtMatKhau.Text == "" || txtTenTruyCap.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            else
            {
                if (_DKTK.KiemTraID(txtID.Text))
                {
                    if (_DKTK.KiemTraTK(txtTenTruyCap.Text)== false)
                    {
                        if (txtMatKhau.Text != txtNhaplaiMatKhau.Text)
                        {
                            MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (_DKTK.DangKiTK(nv))
                            {
                                MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else MessageBox.Show("Đăng kí thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("ID không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
