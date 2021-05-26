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
            dtPNgayLap.Value = DateTime.Now;
            dgvHoaDon.DataSource = hoadon.laydshd();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            hd.id = txtIDHoaDon.Text;
            hd.idnhanvien = txtIDNhanVien.Text;
            hd.ngaylaphoadon = dtPNgayLap.Value;
            if (hoadon.CapnhatHD(hd))
            {
                dgvHoaDon.DataSource = hoadon.laydshd();
                MessageBox.Show("Cập nhật Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvHoaDon.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                txtIDHoaDon.Text = row.Cells[0].Value.ToString();
                txtIDNhanVien.Text = row.Cells[1].Value.ToString();
                dtPNgayLap.Text = row.Cells[2].FormattedValue.ToString();
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hd.id = txtIDHoaDon.Text;
            if (hoadon.XoaHD(hd))
            {
                dgvHoaDon.DataSource = hoadon.laydshd();
                MessageBox.Show("Xóa Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
