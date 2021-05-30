using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DashBoar
{
    public partial class FrmDangKiTaiKhoan : Form
    {
        private DangKiTaiKhoanBUS _DKTK = new DangKiTaiKhoanBUS();
        public FrmDangKiTaiKhoan()
        {
            InitializeComponent();
        }
        public void tienganh()
        {
            lbHoTenDK.Text = "Full name";
            lbMKDK.Text = "Password";
            lbNgaySinhDK.Text = "Birth day";
            lbNhapLaiMKDK.Text = "Confirm new password";
            lbSDT.Text = "Phone";
            lbTenTrungCapDK.Text = "User name";
            lbCongViecDK.Text = "Work";
            gB_hình.Text = "Picture";
            lbl_dktk.Text = "Register an account";
            btnThoat.Text = "Exit";
            btnXacNhan.Text = "Confirm";
        }
        public void tiengviet()
        {
            lbHoTenDK.Text = "Họ tên";
            lbMKDK.Text = "Mật khẩu";
            lbNgaySinhDK.Text = "Ngày sinh";
            lbNhapLaiMKDK.Text = "Xác nhận mật khẩu";
            lbSDT.Text = "SĐT";
            lbTenTrungCapDK.Text = "Tên đăng nhập";
            lbCongViecDK.Text = "Công việc";
            gB_hình.Text = "Hình ảnh";
            lbl_dktk.Text = "Đăng ký tài khoản";
            btnThoat.Text = "Thoát";
            btnXacNhan.Text = "Xác nhận";
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtNhaplaiMatKhau.Text)
                || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtTenTruyCap.Text) || picNV.Image == null )
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                    if (_DKTK.KiemTraTK(txtTenTruyCap.Text) == false)
                    {
                    if (txtMatKhau.Text != txtNhaplaiMatKhau.Text)
                    {
                        MessageBox.Show(Constants.PASSWORD_DIF, Constants.MESSAGE_TITLE, MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (!_DKTK.KTDinhDangEmail(txtEmail.Text))
                        {
                            MessageBox.Show(Constants.ERR_MAIL_FORMAT, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        NhanVienDTO nv = new NhanVienDTO();
                        int i = 1;
                        if (_DKTK.MAXID() == null) nv.IDNV = i + "";
                        else i = int.Parse(_DKTK.MAXID()) + 1;
                        nv.IDNV = i + "";
                        nv.HoTen = txtHoTen.Text;
                        nv.NgaySinh = dtpNgaySinh.Value;
                        nv.GioiTinh = ChonGioiTinh();
                        nv.ChucDanh = "Nhân Viên";
                        nv.SDT = txtSDT.Text;
                        nv.Email = txtEmail.Text;
                        nv.TaiKhoan = txtTenTruyCap.Text;
                        nv.LoaiNV = cbbLoaiNV.Text;
                        nv.MatKhau = txtMatKhau.Text.MaHoaMD5();
                        nv.Hinh = string.Format("{0}.jpg", i);
                        
                        picNV.Text = i + ".jpg";

                        SaveImage(picNV.Image);

                        if (_DKTK.DangKiTK(nv))
                        {
                            MessageBox.Show(Constants.ACCOUT_SUCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else MessageBox.Show(Constants.ACCOUT_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        
                    }
                    else MessageBox.Show(Constants.ACCOUNT_EXIST, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
        private void SaveImage(Image image)
        {
            int i = int.Parse(_DKTK.MAXID()) + 1;
            Bitmap bmp = new Bitmap(image);
            string path = string.Format(@"{0}\..\..\imgNhanVien\{1}.jpg", Environment.CurrentDirectory, i);
            bmp.Save(path, ImageFormat.Jpeg);
        }
        private void picNV_Click(object sender, EventArgs e)
        {
            if (ofdMoFile.ShowDialog() == DialogResult.OK)
            {
                picNV.Image = Image.FromFile(ofdMoFile.FileName);
            }
        }
        private string ChonGioiTinh()
        {
            if (radNam.Checked == true) return radNam.Text;
            else return radNu.Text;
        }
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void FrmDangKiTaiKhoan_Load(object sender, EventArgs e)
        {
            cbbLoaiNV.SelectedIndex = 0;
        }
    }
}
