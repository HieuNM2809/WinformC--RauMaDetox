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
        float Tong ;
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
            //int i;
            //for ( i = 0; i < lstDSSP.Items.Count; i++)
            //{
            //    lstDSSP.Items[i].SubItems[1].Text = count.ToString();
            //    lstDSSP.Items[i].SubItems[2].Text = cbbTenSP.Text;
            //    lstDSSP.Items[i].SubItems[3].Text = numSoLuong.Text;
            //    lstDSSP.Items[i].SubItems[4].Text = cbbGia.Text;
            //    lstDSSP.Items[i].SubItems[5].Text = txtChietKhau.Text;
            //    Tong = Tong * Convert.ToInt32(lstDSSP.Items[i].SubItems[2].Text) * Convert.ToInt32(lstDSSP.Items[i].SubItems[3].Text) * (1 - (Convert.ToInt32(lstDSSP.Items[i].SubItems[4].Text)));
            //    lstDSSP.Items[i].SubItems[6].Text = Tong.ToString();

            //}


            ListViewItem lst = new ListViewItem(count.ToString());
            lst.SubItems.Add(cbbTenSP.Text);
            lst.SubItems.Add(numSoLuong.Text);
            lst.SubItems.Add(cbbGia.Text);
            lst.SubItems.Add(txtChietKhau.Text);
            string a = cbbGia.Text;
            string b = numSoLuong.Text;
            Tong += (Convert.ToInt32(a)) * (Convert.ToInt32(b));
            lst.SubItems.Add(Tong.ToString());
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
