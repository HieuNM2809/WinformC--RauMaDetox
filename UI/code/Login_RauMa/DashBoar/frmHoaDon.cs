using System;
using DTO;
using BUS;
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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private HoaDonBUS hoadon = new HoaDonBUS();

        private HoaDonDTO hd = new HoaDonDTO();
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hoadon.laydshd();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hd.id = txtIDHoaDon.Text;
            hd.idnhanvien = txtIDNhanVien.Text;
            hd.ngaylaphoadon = dtPNgayLap.Value;
            if(hoadon.ThemHoaDon(hd))
            {
                dgvHoaDon.DataSource = hoadon.laydshd();
                MessageBox.Show("Thêm Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
