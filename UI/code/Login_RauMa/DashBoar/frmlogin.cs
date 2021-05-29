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
    public partial class frmlogin : Form
    {
        private NhanVienBUS _nhanvienBUS = new NhanVienBUS();
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatKhau_MouseEnter(object sender, EventArgs e)
        {
            pnlPassword.BackgroundImage = Properties.Resources.lock2;
        }

        private void txtMatKhau_MouseLeave(object sender, EventArgs e)
        {
            pnlPassword.BackgroundImage = Properties.Resources.lock1;
            txtMatKhau.PasswordChar = '♥';
        }

        private void txtTaiKhoan_MouseEnter(object sender, EventArgs e)
        {
            pnlUsername.BackgroundImage = Properties.Resources.user2_1;
        }

        private void txttaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            pnlUsername.BackgroundImage = Properties.Resources.user2_2;
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
           
            pnlUsername.BackgroundImage = Properties.Resources.user2_1;
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
           
            pnlPassword.BackgroundImage = Properties.Resources.lock2;
        }

        private void btnSignin_MouseEnter(object sender, EventArgs e)
        {
            btnSignin.BackColor = Color.White;
            btnSignin.ForeColor = Color.FromArgb(39, 174, 96);
            btnSignin.FlatAppearance.BorderSize = 2;
        }

        private void btnSignin_MouseLeave(object sender, EventArgs e)
        {
            btnSignin.BackColor = Color.FromArgb(39, 174, 96);
            btnSignin.ForeColor = Color.White;
            btnSignin.FlatAppearance.BorderSize = 0;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Administrator" && txtMatKhau.Text == "1234")
            {
                MessageBox.Show(Constants.LOGIN_ADMIN_SUCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                QLNhanVien.QuyenNV = "Admin";
                frmDashboar.Quyen = "Admin";
                QL_SanPham.QuyenSP = "Admin";
                frmDashboar Dashboar = new frmDashboar();
                Dashboar.ShowDialog();
                this.Hide();
                return;
            }
            if (_nhanvienBUS.KTDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) != null)
            {
                MessageBox.Show(Constants.LOGIN_NV_SUCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                QLNhanVien.QuyenNV = "NV";
                QL_SanPham.QuyenSP = "NV";
                frmDashboar.Quyen = "NV";
                frmDashboar Dashboar = new frmDashboar();
                Dashboar.ShowDialog();
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show(Constants.LOGIN_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
            }
        }

        private void btnDKTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKiTaiKhoan DKTK = new FrmDangKiTaiKhoan();
            DKTK.Show();
            this.Hide();
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = null;
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            txtMatKhau.Text = null;
        }
    }
}
