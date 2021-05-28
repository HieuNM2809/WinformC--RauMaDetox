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
        HoaDonBUS hd = new HoaDonBUS();
        ChiTietHoaDonDTO chitiethoadon = new ChiTietHoaDonDTO();
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        private void frmChiTietHoaDon_load(object sender, EventArgs e)
        {
            cbbTenSP.DataSource = sp.lstViewSP();
            cbbTenSP.DisplayMember = "tensp";
            cbbTenSP.ValueMember = "masp";

        }
        private void button1_Click(object sender, EventArgs e)
        {
=======
        private int count = 0;
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            cbbTenSP.DataSource = cthd.layDSSP();
            cbbTenSP.DisplayMember = "Tensp";
            cbbTenSP.ValueMember = "Masp";
=======
        private int count = 0;
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            cbbTenSP.DataSource = cthd.layDSSP();
            cbbTenSP.DisplayMember = "Tensp";
            cbbTenSP.ValueMember = "Masp";

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtChietKhau.Text)||cbbTenSP.SelectedValue==null||numbrSoluong.Value<0)
            {
                MessageBox.Show(Constants.ERR_REQUIRED_2, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                count++;
                ListViewItem lst = new ListViewItem(count.ToString());
                lst.SubItems.Add(cbbTenSP.SelectedValue.ToString());
                
                lst.SubItems.Add(cbbTenSP.Text);
                lst.SubItems.Add(numbrSoluong.Value.ToString());
                lst.SubItems.Add(cbbGiaTien.Text);
                lst.SubItems.Add(txtChietKhau.Text);
=======
        private int count = 0;
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            cbbTenSP.DataSource = cthd.layDSSP();
            cbbTenSP.DisplayMember = "Tensp";
            cbbTenSP.ValueMember = "Masp";
>>>>>>> Stashed changes

                lstDanhSachSP.Items.Add(lst); 
            }    
        }
>>>>>>> Stashed changes

<<<<<<< Updated upstream
        private void cbbTenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbGiaTien.DataSource = cthd.lstViewSP(cbbTenSP.SelectedValue.ToString());
            cbbGiaTien.DisplayMember = "DonGia";
            cbbGiaTien.ValueMember = "Masp";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtChietKhau.Text)||cbbTenSP.SelectedValue==null||numbrSoluong.Value<0)
            {
                MessageBox.Show(Constants.ERR_REQUIRED_2, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                count++;
                ListViewItem lst = new ListViewItem(count.ToString());
                lst.SubItems.Add(cbbTenSP.SelectedValue.ToString());
                
                lst.SubItems.Add(cbbTenSP.Text);
                lst.SubItems.Add(numbrSoluong.Value.ToString());
                lst.SubItems.Add(cbbGiaTien.Text);
                lst.SubItems.Add(txtChietKhau.Text);

                lstDanhSachSP.Items.Add(lst); 
            }    
        }
>>>>>>> Stashed changes

=======
        private int count = 0;
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            cbbTenSP.DataSource = cthd.layDSSP();
            cbbTenSP.DisplayMember = "Tensp";
            cbbTenSP.ValueMember = "Masp";
=======
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtChietKhau.Text)||cbbTenSP.SelectedValue==null||numbrSoluong.Value<0)
            {
                MessageBox.Show(Constants.ERR_REQUIRED_2, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                count++;
                ListViewItem lst = new ListViewItem(count.ToString());
                lst.SubItems.Add(cbbTenSP.SelectedValue.ToString());
                
                lst.SubItems.Add(cbbTenSP.Text);
                lst.SubItems.Add(numbrSoluong.Value.ToString());
                lst.SubItems.Add(cbbGiaTien.Text);
                lst.SubItems.Add(txtChietKhau.Text);

                lstDanhSachSP.Items.Add(lst); 
            }    
        }
>>>>>>> Stashed changes

        private void cbbTenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbGiaTien.DataSource = cthd.lstViewSP(cbbTenSP.SelectedValue.ToString());
            cbbGiaTien.DisplayMember = "DonGia";
            cbbGiaTien.ValueMember = "Masp";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtChietKhau.Text)||cbbTenSP.SelectedValue==null||numbrSoluong.Value<0)
            {
                MessageBox.Show(Constants.ERR_REQUIRED_2, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                count++;
                ListViewItem lst = new ListViewItem(count.ToString());
                lst.SubItems.Add(cbbTenSP.SelectedValue.ToString());
                
                lst.SubItems.Add(cbbTenSP.Text);
                lst.SubItems.Add(numbrSoluong.Value.ToString());
                lst.SubItems.Add(cbbGiaTien.Text);
                lst.SubItems.Add(txtChietKhau.Text);

                lstDanhSachSP.Items.Add(lst); 
            }    
        }

>>>>>>> Stashed changes
        private void cbbTenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbGiaTien.DataSource = cthd.lstViewSP(cbbTenSP.SelectedValue.ToString());
            cbbGiaTien.DisplayMember = "DonGia";
            cbbGiaTien.ValueMember = "Masp";
        }
    }
}
