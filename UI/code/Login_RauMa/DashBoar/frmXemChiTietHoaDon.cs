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
    public partial class frmXemChiTietHoaDon : Form
    {
        ChiTietHoaDonDTO hoadon = new ChiTietHoaDonDTO();
        ChiTietHoaDonBUS cthd = new ChiTietHoaDonBUS();
        HoaDonDTO hd = new HoaDonDTO();
        HoaDonBUS hdb = new HoaDonBUS();
        int count = 0;
        int Tong = 0;
        int TongTien = 0;
        int soluong = 0;
        public frmXemChiTietHoaDon()
        {
            InitializeComponent();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                lis.STT = count.ToString();
                lis.MaSp = cthd.laymasp(cbbTenSP.Text);
                lis.SoLuong = Convert.ToInt32(numSoLuong.Text);
                lis.TenSp = cbbTenSP.Text;
                lis.DonGia = Convert.ToInt32(cbbGia.Text);
                lis.TongTien = Convert.ToInt32(numSoLuong.Text) * Convert.ToInt32(cbbGia.Text);
            }
            TongTien = TongTien + Tong;
            soluong = soluong + (Convert.ToInt32(numSoLuong.Text));
            txtTongSoLuong.Text = soluong.ToString();
            txtTongTien.Text = TongTien.ToString();
            if (cthd.them(lis))
            {
                frmXemChiTietHoaDon_Load(sender, e);
            }
        }

        private void btn_bo_Click(object sender, EventArgs e)
        {
            string c = cthd.max().ToString();
            if (lbl_ma.Text != "")
            {
                if (cthd.loadlai(lbl_ma.Text, c))
                {
                    frmXemChiTietHoaDon_Load(sender, e);
                    TongTien = TongTien - Convert.ToInt32(lbl_tien.Text);
                    txtTongTien.Text = TongTien.ToString();
                    numSoLuong.Text = "0";
                    soluong = soluong - Convert.ToInt32(lblso.Text);
                    txtTongSoLuong.Text = soluong.ToString();
                    frmXemChiTietHoaDon_Load(sender, e);
                }
            }
        }

        private void frmXemChiTietHoaDon_Load(object sender, EventArgs e)
        {
            cbbTenSP.DataSource = cthd.LayDSSP();
            cbbTenSP.DisplayMember = "Tensp";
            cbbTenSP.ValueMember = "Masp";
            dgvDSHD.DataSource = cthd.hienthi(cthd.max().ToString());

        }
    }
}
