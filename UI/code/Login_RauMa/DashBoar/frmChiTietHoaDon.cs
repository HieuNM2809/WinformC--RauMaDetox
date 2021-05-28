using System;
using BUS;
using DTO;
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
    public partial class frmChiTietHoaDon : Form
    {
        BUS_sanpham sp = new BUS_sanpham();
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        private void frmChiTietHoaDon_load(object sender, EventArgs e)
        {
            cbbTenSP.DataSource = sp.lstViewSP();
            cbbTenSP.DisplayMember = "tensp";
            cbbTenSP.ValueMember = "masp";

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
