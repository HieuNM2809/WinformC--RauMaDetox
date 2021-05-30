using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DashBoar
{
    public partial class frmThongTinNhanVien : Form
    {
        private NhanVienBUS _nhanvienBUS = new NhanVienBUS();
        private PhanQuyenBUS _phanQuyenBUS = new PhanQuyenBUS();

        public frmThongTinNhanVien()
        {
            InitializeComponent();
            cbbLoaiNhanVien.SelectedIndex = 0;
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            clChucDanh.DataSource = _phanQuyenBUS.LayDSPhanQuyen();
            clChucDanh.DisplayMember = "LoaiQuyen";
            clChucDanh.ValueMember = "IDQuyen";

            cbbChucDanh.DataSource = _phanQuyenBUS.LayDSPhanQuyen();
            cbbChucDanh.DisplayMember = "LoaiQuyen";
            cbbChucDanh.ValueMember = "IDQuyen";
            
            dgvThongTinNhanVien.DataSource = _nhanvienBUS.LayDSNhanVien();

        }

        #region CHỨC NĂNG
        private void btnThem_Click(object sender, EventArgs e)
        {
            if ( String.IsNullOrEmpty(txtHoTen.Text) || String.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtTaiKhoan.Text) 
                || String.IsNullOrEmpty(txtMatKhau.Text) || dtpNgaySinh.Value >= DateTime.Now)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (_nhanvienBUS.KiemTraNhanVien(txtID.Text))
                {
                    MessageBox.Show(Constants.IDNV_EXIST, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (!_nhanvienBUS.KTDinhDangEmail(txtEmail.Text))
                    {
                        MessageBox.Show(Constants.ERR_MAIL_FORMAT, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if(_nhanvienBUS.KiemTraTK(txtTaiKhoan.Text))
                    {
                        MessageBox.Show(Constants.ACCOUNT_EXIST, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }    
                    NhanVienDTO nv = new NhanVienDTO();
                   
                    nv.IDNV = txtID.Text;
                    nv.HoTen = txtHoTen.Text;
                    nv.NgaySinh = dtpNgaySinh.Value;
                    nv.GioiTinh = ChonGioiTinh();
                    nv.ChucDanh = cbbChucDanh.Text;
                    nv.LoaiNV = cbbLoaiNhanVien.Text;
                    nv.SDT = txtSDT.Text;
                    nv.TaiKhoan = txtTaiKhoan.Text;
                    nv.MatKhau = txtMatKhau.Text.MaHoaMD5();
                    nv.Email = txtEmail.Text;
                    nv.Hinh = string.Format("{0}.jpg", txtID.Text);

                    SaveImage(picNhanVien.Image);

                    if (_nhanvienBUS.ThemNV(nv))
                    {   
                        frmThongTinNhanVien_Load(sender, e);
                        MessageBox.Show(Constants.ADD_SUCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show(Constants.ADD_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {   
            NhanVienDTO nv = new NhanVienDTO();
            nv.IDNV = txtID.Text;
            nv.HoTen = txtHoTen.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.GioiTinh = ChonGioiTinh();
            nv.ChucDanh = cbbChucDanh.Text;
            nv.LoaiNV = cbbLoaiNhanVien.Text;
            nv.SDT = txtSDT.Text;
            nv.TaiKhoan = txtTaiKhoan.Text;
            nv.MatKhau = txtMatKhau.Text.MaHoaMD5();
            nv.Email = txtEmail.Text;

            if (_nhanvienBUS.CapNhatNV(nv))
            {
                MessageBox.Show(Constants.UPDATE_SUCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmThongTinNhanVien_Load(sender, e);
            }
            else MessageBox.Show(Constants.UPDATE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            picNhanVien.Enabled = true;
            int i = 1;
            if (_nhanvienBUS.MAXID() == null) txtID.Text = i+"";

            else i = int.Parse(_nhanvienBUS.MAXID()) + 1; 
            foreach (Control ctrTTNV in this.grTTNV.Controls)
            {
                if (ctrTTNV is TextBox)
                {
                    ctrTTNV.Text = string.Empty;
                }
            }
            dtpNgaySinh.Value = DateTime.Now;
            chkTrangThai.CheckState = CheckState.Checked;
            cbbChucDanh.SelectedIndex = 0;
            cbbLoaiNhanVien.SelectedIndex = 0;
            picNhanVien.Image = null;
            txtID.Text = i + "";
            frmThongTinNhanVien_Load(sender, e);
            txtTaiKhoan.Enabled = true;
        }

        private void dgvThongTinNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

                txtID.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (dgvThongTinNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
                cbbChucDanh.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbbLoaiNhanVien.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSDT.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTaiKhoan.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtMatKhau.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtEmail.Text = dgvThongTinNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();

                string path = string.Format(@"{0}\..\..\imgNhanVien\{1}", Environment.CurrentDirectory,
                    dgvThongTinNhanVien.Rows[e.RowIndex].Cells[10].Value.ToString());

                picNhanVien.Image = Image.FromFile(path);
                picNhanVien.Enabled = false;
                txtTaiKhoan.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO
            {
                IDNV = txtID.Text,

            };
            if (_nhanvienBUS.XoaNV(nv))
            {
                MessageBox.Show(Constants.DELETE_SUCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmThongTinNhanVien_Load(sender, e);
            }
            else MessageBox.Show(Constants.DELETE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(radHoTen.Checked == true )
            {
               dgvThongTinNhanVien.DataSource = _nhanvienBUS.TimKiemHoTenNV(txtTimKiem.Text);
                return;
            }
            if(radID.Checked == true )
            {
                dgvThongTinNhanVien.DataSource = _nhanvienBUS.TimKiemIDNV(txtTimKiem.Text);
                return;
            }    
        }

        #endregion

        #region HÀM HỖ TRỢ
        private string ChonGioiTinh()
        {
            if (radNam.Checked == true) return radNam.Text;
            else return radNu.Text;
        }

        private void picNhanVien_Click(object sender, EventArgs e)
        {
            if(ofdimgNhanVien.ShowDialog() == DialogResult.OK)
            {
                picNhanVien.Image = Image.FromFile(ofdimgNhanVien.FileName);
            }    
        }
        
        private void SaveImage(Image image)
        {  
            Bitmap bmp = new Bitmap(image);
            string path = string.Format(@"{0}\..\..\imgNhanVien\{1}.jpg", Environment.CurrentDirectory, txtID.Text);

            bmp.Save(path, ImageFormat.Jpeg);
        }
        #endregion

        #region THÊM THÔNG TIN BUTTON
        private void mh(string text, Button btn)
        {
            btn.Image = null;
            btn.ForeColor = Color.FromArgb(39, 174, 96);
            btn.Text = text;
        }

        private void ml(Button btn, string tenhinh)
        {
            btn.Text = null;
            string path = string.Format(@"{0}\..\..\Icon\{1}.png", Environment.CurrentDirectory, tenhinh);
            btn.Image = Image.FromFile(path);
        }

        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            mh("Thêm", btnThem);
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            ml(btnThem, "plus");
        }

        private void btnSua_MouseHover(object sender, EventArgs e)
        {
            mh("Sửa", btnSua);
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            ml(btnSua, "chinhsua");
        }

        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            mh("Xóa", btnXoa);
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            ml(btnXoa, "delete");
        }
        private void btnLamMoi_MouseHover(object sender, EventArgs e)
        {
           mh("Làm mới", btnLamMoi);
        }

        private void btnLamMoi_MouseLeave(object sender, EventArgs e)
        {
            ml(btnLamMoi, "loop2");
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            mh("Thoát", btnThoat);
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
           ml(btnThoat, "no");
        }
        #endregion
    }
}

