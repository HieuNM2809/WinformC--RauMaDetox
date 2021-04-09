using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Login_RauMa : DevExpress.XtraEditors.XtraForm
    {
        public Login_RauMa()
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
            txtUsername.Text = "USERNAME";
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            pnlUsername.BackgroundImage = Properties.Resources.user2_1;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
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
    }
}
