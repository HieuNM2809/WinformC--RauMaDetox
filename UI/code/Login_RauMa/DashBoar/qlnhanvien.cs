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
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }

        public static string QuyenNV;
        private void frmloadFill(object frm)
        {
            if (this.panel_show.Controls.Count > 0)
                this.panel_show.Controls.RemoveAt(0);
            Form f = frm as Form;
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            this.panel_show.Controls.Add(f);
            this.panel_show.Tag = f;
            f.Show();
        }

        private void frmloadNoNe(object frm)
        {
            if (this.panel_show.Controls.Count > 0)
                this.panel_show.Controls.RemoveAt(0);
            Form f = frm as Form;
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.None;
            this.panel_show.Controls.Add(f);
            this.panel_show.Tag = f;
            f.Show();
        }
        private void đăngKíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangKiTaiKhoan dk = new FrmDangKiTaiKhoan();
            panel_show.Show();
            panel_show.Controls.Clear();
            dk.TopLevel = false;
            dk.Dock = DockStyle.Left;
            panel_show.Controls.Add(dk);
            dk.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau dk = new FrmDoiMatKhau();
            frmloadNoNe(dk);
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien TTNV = new frmThongTinNhanVien();
            frmloadFill(TTNV);
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            if (QuyenNV == "Admin")
            {
                tsmlQLNV.Enabled = true;
                tsmlDKTK.Enabled = true;
                FrmDangKiTaiKhoan DKTK = new FrmDangKiTaiKhoan();
                frmloadNoNe(DKTK);
                return;
            }
            if(QuyenNV == "NV")
            {
                FrmDoiMatKhau DMK = new FrmDoiMatKhau();
                frmloadNoNe(DMK);
            }    
            
        }
    }
}
