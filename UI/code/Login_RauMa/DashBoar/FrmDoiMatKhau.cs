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
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show(Constants.PASSWORD_DIF, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (_DoiMatKhau.DoiMatKhau(nv))
                            {
                                MessageBox.Show(Constants.PASSWORD_SUCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else MessageBox.Show(Constants.PASSWORD_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }    
                    else MessageBox.Show(Constants.PASSWORD_INCORRECT, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show(Constants.ACCOUNT_NOT_EXIST, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
