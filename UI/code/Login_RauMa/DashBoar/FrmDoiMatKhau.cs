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

    public partial class FrmDoiMatKhau : Form
    {

        private DoiMatKhauBUS _DoiMatKhau = new DoiMatKhauBUS();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            NhanVienDTO nv = new NhanVienDTO
            {
                MatKhau = txtMatKhauMoi.Text,

            };
            if (txtTenDangNhap.Text == "" || txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtNhapLaiMKM.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            else
            {
                if (_DoiMatKhau.KiemTraTK(txtTenDangNhap.Text))
                {
                    if(_DoiMatKhau.KiemTraMK(txtMatKhauCu.Text))
                    {
                        if (txtMatKhauMoi.Text != txtNhapLaiMKM.Text)
                        {
                            MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (_DoiMatKhau.DoiMatKhau(nv))
                            {
                                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }    
                    else MessageBox.Show("Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Tên truy cập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
