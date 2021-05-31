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
        ChiTietHoaDonDTO hoadon = new ChiTietHoaDonDTO();
        ChiTietHoaDonBUS cthd = new ChiTietHoaDonBUS();
        HoaDonDTO hd = new HoaDonDTO();
        HoaDonBUS hdb = new HoaDonBUS();
        int count = 0;
        int Tong = 0;
        int TongTien = 0;
        int soluong = 0;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        public void tienganh()
        {
        }
        public void tiengviet()
        {

        }
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            cbbTenSP.DataSource = cthd.LayDSSP();
            cbbTenSP.DisplayMember = "Tensp";
            cbbTenSP.ValueMember = "Masp";
            dgvDSHD.DataSource = cthd.hienthi(cthd.max().ToString());
            if (txtTongSoLuong.Text == "0" && txtTongTien.Text == "0")
            {
                button1.Text = "THOÁT";
            }
            else
            {
                button1.Text = "In Hóa Đơn";
            }

        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            count++;
            string a = cbbGia.Text;
            string b = numSoLuong.Text;
            Tong = ((Convert.ToInt32(a)) * (Convert.ToInt32(b)));
            ChiTietHoaDonDTO lis = new ChiTietHoaDonDTO();
            {
                lis.IDHoaDon = Convert.ToString(cthd.max());
                lis.STT =count.ToString();
                lis.MaSp = cthd.laymasp(cbbTenSP.Text);
                lis.SoLuong = Convert.ToInt32 ( numSoLuong.Text);
                lis.TenSp = cbbTenSP.Text;
                lis.DonGia = Convert.ToInt32 (cbbGia.Text);
                lis.TongTien = Convert.ToInt32(numSoLuong.Text) * Convert.ToInt32(cbbGia.Text);                
            }
            TongTien = TongTien + Tong;
            soluong = soluong + (Convert.ToInt32(numSoLuong.Text));
            txtTongSoLuong.Text = soluong.ToString();
            txtTongTien.Text = TongTien.ToString();
            if (cthd.them(lis))
            {
                frmChiTietHoaDon_Load(sender, e);
            }
            
        }

        private void cbbTenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbGia.DataSource = cthd.LayGia(cbbTenSP.SelectedValue.ToString());
            cbbGia.DisplayMember = "DonGia";
            cbbGia.ValueMember = "DonGia";
        }

        private void lbl_tensp_Click(object sender, EventArgs e)
        {

        }
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
        }

        private void btn_bo_Click_1(object sender, EventArgs e)
        {
            string c = cthd.max().ToString();
            if (lbl_ma.Text != "")
            {
                if (dgvDSHD.RowCount > 0)
                {
                    if (cthd.loadlai(lbl_ma.Text, c)==true)
                    {
                        frmChiTietHoaDon_Load(sender, e);
                        try
                        {
                            TongTien = TongTien - Convert.ToInt32(lbl_tien.Text);
                            txtTongTien.Text = TongTien.ToString();
                            lbl_tien.Text = "O";
                            numSoLuong.Text = "0";
                            soluong = soluong - Convert.ToInt32(lblso.Text);
                            txtTongSoLuong.Text = soluong.ToString();
                            lblso.Text = "0";
                        }
                        catch
                        {
                            return;
                        }
                        frmChiTietHoaDon_Load(sender, e);
                    }
                }
            }
            else return;
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.dgvDSHD.Rows[e.RowIndex];
                lbl_ma.Text = row.Cells[6].Value.ToString();
                lbl_tien.Text = row.Cells[5].Value.ToString();
                lblso.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = cthd.max().ToString();
            if (txtTongSoLuong.Text=="0" || txtTongTien.Text == "0")
            {
                this.Close();
            }
            else
            {
                if (hdb.them(c, TongTien, soluong))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmChiTietHoaDon_Load(sender, e);
                }
                else MessageBox.Show("Thêm Thất bại", "Thông báo");
                this.Close();
            }
        }
    }
}
