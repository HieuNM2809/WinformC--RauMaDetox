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
    public partial class Xem_SanPham : Form
    {
        public Xem_SanPham()
        {
            InitializeComponent();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Them_sua sua = new Them_sua();
            sua.ShowDialog();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
