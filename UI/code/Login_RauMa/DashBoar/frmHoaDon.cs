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
        public void tienganh()
        {
            label1.Text = "ID bill";
            label2.Text = "ID staff";
            label6.Text = "Invoice date";
            label7.Text = "BILL MANAGEMENT";
            btnCapNhat.Text = "Update";
            btnTimKiem.Text = "Search";
            btnXoa.Text = "Delete";
            dgvHoaDon.Columns[1].HeaderText = "ID Staff";
            dgvHoaDon.Columns[2].HeaderText = "Invoice date";
        }
        public void tiengviet()
        {
            label1.Text = "ID Hóa đơn";
            label2.Text = "ID Nhân viên";
            label6.Text = "Ngày lập hóa đơn";
            label7.Text = "QUẢN LÝ HÓA ĐƠN";
            btnCapNhat.Text = "Cập nhật";
            btnTimKiem.Text = "Tìm kiếm";
            btnXoa.Text = "Xóa";
            dgvHoaDon.Columns[1].HeaderText = "ID Nhân viên";
            dgvHoaDon.Columns[2].HeaderText = "Ngày lập hóa đơn";
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

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            int mahd = (cthd.max()) + 1;
            hd.id = mahd.ToString();
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
