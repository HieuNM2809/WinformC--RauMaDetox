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
        ChiTietHoaDonBUS cthd = new ChiTietHoaDonBUS();
        HoaDonBUS hd = new HoaDonBUS();
        ChiTietHoaDonDTO chitiethoadon = new ChiTietHoaDonDTO();
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDon_Load_1(object sender, EventArgs e)
        {

        }
    }
}
