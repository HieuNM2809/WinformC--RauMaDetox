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
           
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmDoiMatKhau dmk = new FrmDoiMatKhau();
            dmk.Show();
            //FrmDoiMatKhau frmQMK = new FrmDoiMatKhau();
            //panel_show.Show();
            //panel_show.Controls.Clear();
            //frmQMK.TopLevel = false;

            //panel_show.Controls.Add(frmQMK);
            //frmQMK.Show();
            // ĐỔI LẠI CÁCH KẾT FORM CHA CON NHA NHỚ ĐỪNG BẬT MDICONTAINER
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien ttnv = new frmThongTinNhanVien();
            ttnv.Show();
            //frmThongTinNhanVien frmTTNV = new frmThongTinNhanVien();
            //panel_show.Show();
            //panel_show.Controls.Clear();
            //frmTTNV.TopLevel = false;
            //frmTTNV.Dock = DockStyle.Fill;
            //panel_show.Controls.Add(frmTTNV);
            //frmTTNV.Show();
            // ĐỔI LẠI CÁCH KẾT FORM CHA CON NHA NHỚ ĐỪNG BẬT MDICONTAINER
        }
    }


}
