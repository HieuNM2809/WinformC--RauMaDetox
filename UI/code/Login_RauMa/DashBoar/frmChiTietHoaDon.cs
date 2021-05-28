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
<<<<<<< HEAD
        BUS_sanpham sp = new BUS_sanpham();
=======
        ChiTietHoaDonBUS cthd = new ChiTietHoaDonBUS();
        int count = 0;
>>>>>>> 03aac24c7ebbbb114cdf087881bc786dd8086700
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        private void frmChiTietHoaDon_load(object sender, EventArgs e)
        {
            cbbTenSP.DataSource = sp.lstViewSP();
            cbbTenSP.DisplayMember = "tensp";
            cbbTenSP.ValueMember = "masp";


        }
        private void button1_Click(object sender, EventArgs e)
        {

=======
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            cbbTenSP.DataSource = cthd.LayDSSP();
            cbbTenSP.DisplayMember = "Tensp";
            cbbTenSP.ValueMember = "Masp";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            count++; 
            ListViewItem lst = new ListViewItem(count.ToString());
            lst.SubItems.Add(cbbTenSP.Text);
            lst.SubItems.Add(numSoLuong.Text);
            lst.SubItems.Add(cbbGia.Text);
            lst.SubItems.Add(txtChietKhau.Text);
            lst.SubItems.Add(txtTongTien.Text);
            lstDSSP.Items.Add(lst);
        }

        private void cbbTenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbGia.DataSource = cthd.LayGia(cbbTenSP.SelectedValue.ToString());
            cbbGia.DisplayMember = "DonGia";
            cbbGia.ValueMember = "DonGia";
>>>>>>> 03aac24c7ebbbb114cdf087881bc786dd8086700
        }
    }
}
