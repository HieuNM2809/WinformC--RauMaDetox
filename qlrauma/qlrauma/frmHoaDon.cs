using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLRauma
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private HoaDonBUS hoadon = new HoaDonBUS();
        private ChiTietHoaDonBUS cthd = new ChiTietHoaDonBUS();
        private HoaDonDTO hd = new HoaDonDTO();
        private void frmHoaDon_Load(object sender, EventArgs e)
        {

            int mahd = (cthd.max()) + 1;
            txtIDHoaDon.Text = mahd.ToString();
            dtPNgayLap.Value = DateTime.Now;
            dgvHoaDon.DataSource = hoadon.laydshd();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon frmcthd = new frmChiTietHoaDon();
            cthd.hienthi(txtIDHoaDon.Text);
            frmcthd.ShowDialog();
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

        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            int mahd = (cthd.max()) + 1;
            hd.id = mahd.ToString();
            txtIDNhanVien.Text = "1";
            hd.idnhanvien = txtIDNhanVien.Text;
            hd.ngaylaphoadon = dtPNgayLap.Value;
            if (hoadon.themHD(hd))
            {
                frmChiTietHoaDon frmcthd = new frmChiTietHoaDon(); ;
                frmcthd.ShowDialog();
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
    }
}
