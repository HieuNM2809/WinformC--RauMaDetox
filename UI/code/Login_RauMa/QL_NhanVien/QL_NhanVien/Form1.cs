using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvwThongTinNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwThongTinNhanVien.SelectedItems.Count > 0)
            {
                txtID.Enabled = false;
                txtTaiKhoan.Enabled = false;
                txtID.Text = lvwThongTinNhanVien.SelectedItems[0].SubItems[0].Text;
                txtHoTen.Text = lvwThongTinNhanVien.SelectedItems[0].SubItems[1].Text;
                if (lvwThongTinNhanVien.SelectedItems[0].SubItems[2].Text == "Nam") radNam.Checked = true;
                else if (lvwThongTinNhanVien.SelectedItems[0].SubItems[2].Text == "Nữ") radNu.Checked = true;
                dtpNgaySinh.Text = lvwThongTinNhanVien.SelectedItems[0].SubItems[3].Text;
                txtSDT.Text = lvwThongTinNhanVien.SelectedItems[0].SubItems[4].Text;
                txtEmail.Text = lvwThongTinNhanVien.SelectedItems[0].SubItems[5].Text;
                txtTaiKhoan.Text = lvwThongTinNhanVien.SelectedItems[0].SubItems[6].Text;
                txtMatKhau.Text = lvwThongTinNhanVien.SelectedItems[0].SubItems[7].Text;
                if (lvwThongTinNhanVien.SelectedItems[0].SubItems[8].Text == "Hoạt động")
                    chkTrangThai.Checked = true;
                else chkTrangThai.Checked = false;
                cboLoaiNhanViên.Text = lvwThongTinNhanVien.SelectedItems[0].SubItems[9].Text;
                cboChucNang.Text = lvwThongTinNhanVien.SelectedItems[0].SubItems[10].Text;
            }
        }

        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            btnThem.Text = "Thêm";
            btnThem.Image = null;
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            btnThem.Text = " ";
            String Icon = @"D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\WinformC--RauMaDetox\UI\code\Login_RauMa\QL_NhanVien\QL_NhanVien\Icon\icons8_plus_48px.png";
            btnThem.Image = Image.FromFile(Icon);
        }

        private void btnSua_MouseHover(object sender, EventArgs e)
        {
            btnSua.Text = "Sửa";
            btnSua.Image = null;
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.Text = " ";
            String Icon = @"D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\WinformC--RauMaDetox\UI\code\Login_RauMa\QL_NhanVien\QL_NhanVien\Icon\Sua.PNG";
            btnSua.Image = Image.FromFile(Icon);
        }

        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            btnXoa.Text = "Xóa";
            btnXoa.Image = null;
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            btnXoa.Text = " ";
            String Icon = @"D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\WinformC--RauMaDetox\UI\code\Login_RauMa\QL_NhanVien\QL_NhanVien\Icon\Xoa1.png";
            btnXoa.Image = Image.FromFile(Icon);
        }

        private void btnLamMoi_MouseHover(object sender, EventArgs e)
        {
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Image = null;
        }

        private void btnLamMoi_MouseLeave(object sender, EventArgs e)
        {
            btnLamMoi.Text = " ";
            String Icon = @"D:\HỌC TẬP\ĐỒ ÁN LẬP TRÌNH WINDOWS\WinformC--RauMaDetox\WinformC--RauMaDetox\UI\code\Login_RauMa\QL_NhanVien\QL_NhanVien\Icon\LamMoi3.png";
            btnLamMoi.Image = Image.FromFile(Icon);
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
            }
            else
            {
                MessageBox.Show("Hãy chọn dòng xóa", "Thông báo", MessageBoxButtons.OK);
            }
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
