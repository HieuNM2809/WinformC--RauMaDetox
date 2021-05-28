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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            pnlPassword.BackgroundImage = Properties.Resources.lock2;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            pnlPassword.BackgroundImage = Properties.Resources.lock1;
            txtPassword.PasswordChar = '♥';
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            pnlUsername.BackgroundImage = Properties.Resources.user2_1;
        }

        private void txtUsername_MouseLeave(object sender, EventArgs e)
        {
            pnlUsername.BackgroundImage = Properties.Resources.user2_2;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
           
            pnlUsername.BackgroundImage = Properties.Resources.user2_1;
        }

        private void txtPassword_Click(object sender, EventArgs e)
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
            if(txtUsername.Text=="Administrator" && txtPassword.Text=="1234")
            {
                frmDashboar Dashboar = new frmDashboar();
                Dashboar.ShowDialog();
                this.Close();
            }    
            else
            {
                MessageBox.Show("Đăng nhập sai mật khẩu hoặc tên tài khoản!", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }    
            
        }

        private void lnkCreateAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmDangKiTaiKhoan frmDangKi = new frmDangKiTaiKhoan();
            //frmDangKi.Show();
        }
    }
}
