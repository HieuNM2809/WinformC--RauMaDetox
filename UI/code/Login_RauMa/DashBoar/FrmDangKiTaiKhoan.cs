using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DashBoar
{
   
    public partial class FrmDangKiTaiKhoan : Form
    {
        private DangKiTaiKhoanBUS _DKTK = new DangKiTaiKhoanBUS();
        public FrmDangKiTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO
            {
                TaiKhoan = txtTenTruyCap.Text,
                MatKhau = txtMatKhau.Text,

            };
        }
    }
}
