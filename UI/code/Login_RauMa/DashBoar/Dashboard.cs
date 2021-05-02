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
    public partial class frmDashboar : Form
    {
        public frmDashboar()
        {
            InitializeComponent();
        }

        private void btnQLTaiKhoan_DragEnter(object sender, DragEventArgs e)
        {
            btnQLTaiKhoan.Text = "Quản Lí Tài Khoản";
        }

        private void btnQLTaiKhoan_DragLeave(object sender, EventArgs e)
        {
            btnQLTaiKhoan.Text = " ";
        }

       private void btnCaiDat_MouseEnter(object sender, EventArgs e)
        {
            
            btnCaiDat.ForeColor = Color.FromArgb(39, 174, 96);
        }
        private void btnCaiDat_MouseLeave(object sender, EventArgs e)
        {
            btnCaiDat.ForeColor = Color.White;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLTaiKhoan_MouseEnter(object sender, EventArgs e)
        {
            btnQLTaiKhoan.ForeColor = Color.FromArgb(39, 174, 96);
        }

        private void btnQLTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            btnQLTaiKhoan.ForeColor = Color.White;
        }

        private void btnHoaDon_MouseEnter(object sender, EventArgs e)
        {
            btnHoaDon.ForeColor = Color.FromArgb(39, 174, 96);
        }

        private void btnHoaDon_MouseLeave(object sender, EventArgs e)
        {
            btnHoaDon.ForeColor = Color.White;
        }

        private void btnSanPham_MouseEnter(object sender, EventArgs e)
        {
            btnSanPham.ForeColor = Color.FromArgb(39, 174, 96);
        }

        private void btnSanPham_MouseLeave(object sender, EventArgs e)
        {
            btnSanPham.ForeColor = Color.White;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width==68)
            {
                pnlMenu.Width = 298;
                picAvatar.Width = 101;
                picAvatar.Height = 86;
                picAvatar.Location = new Point(-1, 70);
                btnQLTaiKhoan.Width = 298;
                btnSanPham.Width = 298;
                btnThoat.Width = 298;
                btnCaiDat.Width = 298;
                btnHoaDon.Width = 298;
                btnMenu.BackgroundImage = Properties.Resources.menu1;
            }
            else
            {
                pnlMenu.Width = 68;
                picAvatar.Width = 70;
                picAvatar.Height = 64;
                picAvatar.Location = new Point(0, 100);
                btnMenu.BackgroundImage = Properties.Resources.menu2;
            }
        }

        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.ForeColor = Color.FromArgb(39, 174, 96);
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.ForeColor = Color.White;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
