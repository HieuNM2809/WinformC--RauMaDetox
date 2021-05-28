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
            NhanVienDTO nv = new NhanVienDTO()
            {
                IDNV = (_DKTK.MAXID() + 1),
                HoTen = txtHoTen.Text,
                SDT = txtSDT.Text,
                TaiKhoan = txtTenTruyCap.Text,
                MatKhau = txtMatKhau.Text.MaHoaMD5()

            };
            if  ( string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtMatKhau.Text)|| string.IsNullOrEmpty(txtNhaplaiMatKhau.Text) 
                || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtTenTruyCap.Text))
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                    if (_DKTK.KiemTraTK(txtTenTruyCap.Text) == false)
                    {
                        if (txtMatKhau.Text != txtNhaplaiMatKhau.Text)
                        {
                            MessageBox.Show(Constants.PASSWORD_DIF, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (_DKTK.DangKiTK(nv))
                            {
                                MessageBox.Show(Constants.ACCOUT_SUCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else MessageBox.Show(Constants.ACCOUT_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else MessageBox.Show(Constants.ACCOUNT_EXIST, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDangKiTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
