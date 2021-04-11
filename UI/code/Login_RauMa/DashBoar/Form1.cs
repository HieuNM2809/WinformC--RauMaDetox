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
    }
}
