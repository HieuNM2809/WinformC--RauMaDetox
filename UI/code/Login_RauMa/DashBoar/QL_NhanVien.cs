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
    public partial class QL_NhanVien : Form
    {
        public QL_NhanVien()
        {
            InitializeComponent();
        }

        private void đăngKíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangKiTaiKhoan frmDK = new FrmDangKiTaiKhoan();
            panel_show.Show();
            panel_show.Controls.Clear();
            frmDK.TopLevel = false;
            frmDK.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frmDK);
            frmDK.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmQuenMatKhau frmQMK = new FrmQuenMatKhau();
            panel_show.Show();
            panel_show.Controls.Clear();
            frmQMK.TopLevel = false;
            frmQMK.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frmQMK);
            frmQMK.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinNhanVien frmTTNV = new FrmThongTinNhanVien();
            panel_show.Show();
            panel_show.Controls.Clear();
            frmTTNV.TopLevel = false;
            frmTTNV.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frmTTNV);
            frmTTNV.Show();
        }

        private void hồSơThửViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThuViec frmTV = new FrmThuViec();
            panel_show.Show();
            panel_show.Controls.Clear();
            frmTV.TopLevel = false;
            frmTV.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frmTV);
            frmTV.Show();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiem frmTKiem = new FrmTimKiem();
            panel_show.Show();
            panel_show.Controls.Clear();
            frmTKiem.TopLevel = false;
            frmTKiem.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frmTKiem);
            frmTKiem.Show();
        }
    }


}
