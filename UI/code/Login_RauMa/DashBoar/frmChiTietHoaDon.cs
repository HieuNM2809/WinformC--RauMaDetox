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
        int count = 0;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        public void tienganh()
        {
            lblGia.Text = "Price";
            lbl_chietkhau.Text = "Discout";
            lbl_soluong.Text = "Amount";
            lbl_tensp.Text = "Product's name";
            lbl_tong.Text = "Total";
            lbl_tongtien.Text = "Total money";
            btnXacNhan.Text = "Confirm";
            btn_bo.Text = "Unchecked";
            lstDSSP.Columns[0].Name = "akl";
        }
        public void tiengviet()
        {

        }
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
        }
    }
}
