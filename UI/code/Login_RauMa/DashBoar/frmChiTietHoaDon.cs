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
        float Tong = 0;
        float TongTien = 0;
        double soluong = 0;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        public void tienganh()
        {
            lblGia.Text = "Price";
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
            string a = cbbGia.Text;
            string b = numSoLuong.Text;
            Tong = ((Convert.ToInt32(a)) * (Convert.ToInt32(b)));
            lst.SubItems.Add(Tong.ToString());
            lstDSSP.Items.Add(lst);
            TongTien = TongTien + Tong;
            soluong = soluong +(Convert.ToInt32(numSoLuong.Text));
            txtTongSoLuong.Text = soluong.ToString();
            txtTongTien.Text = TongTien.ToString();
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

        private void btn_bo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDSSP.Items.Count; i++)
            {

                if (lstDSSP.Items[i].Selected)
                {
                    lstDSSP.Items[i].Remove();
                    i--;
                }
            }
        }
    }
}
