using System;
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
    public partial class QL_NhanVien : Form
    {
        string strPath = @"D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\WinformC--RauMaDetox\UI\code\Login_RauMa\Icon";
        public QL_NhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            btnThem.Text = "Thêm";
            btnThem.Image = null;
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            btnThem.Text = " ";
            string icon = strPath + @"Them.png";
            btnThem.Image = Image.FromFile(icon);
        }

        private void btnSua_MouseHover(object sender, EventArgs e)
        {
            btnSua.Text = "Sửa";
            btnSua.Image = null;
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.Text = " ";
            String icon = strPath + @"Sua.png";
            btnSua.Image = Image.FromFile(icon);
        }

        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            btnXoa.Text = "Xóa";
            btnXoa.Image = null;
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            btnXoa.Text = " ";
            String icon = strPath + @"Xoa.png";
            btnXoa.Image = Image.FromFile(icon);
        }

        private void btnLamMoi_MouseHover(object sender, EventArgs e)
        {
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.Image = null;
        }

        private void btnLamMoi_MouseLeave(object sender, EventArgs e)
        {
            btnLamMoi.Text = " ";
            String icon = strPath + @"LamMoi.png";
            btnLamMoi.Image = Image.FromFile(icon);
        }

        private void QL_NhanVien_Load(object sender, EventArgs e)
        {
            cboChucNang.SelectedIndex = 0;
            cboLoaiNhanViên.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtHoTen.Text) ||
              String.IsNullOrEmpty(txtTaiKhoan.Text) || String.IsNullOrEmpty(txtMatKhau.Text) ||
              dtpNgaySinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Bạn vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // them thong tin vao listview
                ListViewItem lvwTTSV = new ListViewItem(txtID.Text);
                lvwTTSV.SubItems.Add(txtHoTen.Text);
                if (radNam.Checked == true) lvwTTSV.SubItems.Add("Nam");
                else if (radNu.Checked == true) lvwTTSV.SubItems.Add("Nữ");
                lvwTTSV.SubItems.Add(dtpNgaySinh.Text);
                lvwTTSV.SubItems.Add(txtSDT.Text);
                lvwTTSV.SubItems.Add(txtEmail.Text);
                lvwTTSV.SubItems.Add(txtTaiKhoan.Text);
                lvwTTSV.SubItems.Add(txtMatKhau.Text);
                if (chkTrangThai.Checked == true) lvwTTSV.SubItems.Add("Hoạt động");
                else lvwTTSV.SubItems.Add("Không hoạt động ");
                lvwTTSV.SubItems.Add(cboChucNang.Text);
                lvwTTSV.SubItems.Add(cboLoaiNhanViên.Text);
                lvwThongTinNhanVien.Items.Add(lvwTTSV);


                //Xoa Thong tin nhap
                txtID.Text = "";
                txtHoTen.Text = "";
                radNam.Checked = true;
                dtpNgaySinh.Value = DateTime.Now;
                txtSDT.Text = "";
                txtEmail.Text = "";
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                chkTrangThai.Checked = true;
                cboChucNang.SelectedIndex = 0;
                cboLoaiNhanViên.SelectedIndex = 0;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvwThongTinNhanVien.SelectedItems.Count > 0)
            {
                lvwThongTinNhanVien.SelectedItems[0].SubItems[0].Text = txtID.Text;
                lvwThongTinNhanVien.SelectedItems[0].SubItems[1].Text = txtHoTen.Text;
                if (radNam.Checked == true) lvwThongTinNhanVien.SelectedItems[0].SubItems[2].Text = "Nam";
                else if (radNu.Checked == true) lvwThongTinNhanVien.SelectedItems[0].SubItems[2].Text = "Nữ";
                lvwThongTinNhanVien.SelectedItems[0].SubItems[3].Text = dtpNgaySinh.Text;
                lvwThongTinNhanVien.SelectedItems[0].SubItems[4].Text = txtEmail.Text;
                lvwThongTinNhanVien.SelectedItems[0].SubItems[5].Text = txtEmail.Text;
                lvwThongTinNhanVien.SelectedItems[0].SubItems[6].Text = txtTaiKhoan.Text;
                lvwThongTinNhanVien.SelectedItems[0].SubItems[7].Text = txtMatKhau.Text;
                if (chkTrangThai.Checked == true)
                    lvwThongTinNhanVien.SelectedItems[0].SubItems[8].Text = "Hoạt động";
                else lvwThongTinNhanVien.SelectedItems[0].SubItems[8].Text = "không hoạt động";
                lvwThongTinNhanVien.SelectedItems[0].SubItems[9].Text = cboLoaiNhanViên.Text;
                lvwThongTinNhanVien.SelectedItems[0].SubItems[10].Text = cboChucNang.Text;


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwThongTinNhanVien.SelectedItems.Count > 0)
            {
                lvwThongTinNhanVien.Items.Remove(lvwThongTinNhanVien.SelectedItems[0]);
                txtID.Text = "";
                txtHoTen.Text = "";
                radNam.Checked = true;
                dtpNgaySinh.Value = DateTime.Now;
                txtSDT.Text = "";
                txtEmail.Text = "";
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                chkTrangThai.Checked = true;
                cboChucNang.SelectedIndex = 0;
                cboLoaiNhanViên.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Hãy chọn dòng xóa", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtTaiKhoan.Enabled = true;
            txtID.Text = "";
            txtHoTen.Text = "";
            radNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            chkTrangThai.Checked = true;
            cboChucNang.SelectedIndex = 0;
            cboLoaiNhanViên.SelectedIndex = 0;
        }
    }
}
