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
    public partial class QL_SanPham : Form
    {
        public QL_SanPham()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QL_SanPham_Load(object sender, EventArgs e)
        {
            QLSP_User qlsp = new QLSP_User();
            qlsp.MdiParent = this;
            qlsp.Show();
            //phân quyền admin
            //QLSP_Admin qlsp = new QLSP_Admin();
            //qlsp.MdiParent = this;
            //qlsp.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
