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
        public static string Quyen;
        public frmDashboar()
        {
            InitializeComponent();
        }
        public void tienganh()
        {
            btnCaiDat.Text = "Setting";
            btnHoaDon.Text = "Bill";
            btnQLTaiKhoan.Text = "Staff";
            btnSanPham.Text = "Product";
            btnThoat.Text = "Exit";
        }
        public void tiengviet()
        {
            btnCaiDat.Text = "Cài đặt";
            btnHoaDon.Text = "Hóa đơn";
            btnQLTaiKhoan.Text = "Nhân viên";
            btnSanPham.Text = "Sản phẩm";
            btnThoat.Text = "Thoát";
        }
        private void loadform(object Form)
        {
            if (this.pnlform.Controls.Count > 0)
            this.pnlform.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            this.pnlform.Controls.Add(f);
            this.pnlform.Tag = f;
            f.Show();
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
                pnlform.Dock = DockStyle.Fill;
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

        
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            
        }


        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            QL_SanPham sp = new QL_SanPham();
            loadform(sp);
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            QLNhanVien frmTTNV = new QLNhanVien();
            loadform(frmTTNV);
            
        }

        private void btnHoaDon_Click_1(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            loadform(hd);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmlogin DN = new frmlogin();
            DN.Show();
            this.Hide();
        }
    }
}
