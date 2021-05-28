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
            // Đổ dữ liệu vào combobox
            cbbLoaiNhanVien.SelectedIndex = 0;

        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            clChucDanh.DataSource = _phanQuyenBUS.LayDSPhanQuyen();
            clChucDanh.DisplayMember = "LoaiQuyen";
            clChucDanh.ValueMember = "IDQuyen";

            clLoaiNV.DataSource = _nhanvienBUS.LayDSNhanVien();
            clLoaiNV.DisplayMember = "LoaiNV";
            clLoaiNV.ValueMember = "LoaiNV";


            cbbChucDanh.DataSource = _phanQuyenBUS.LayDSPhanQuyen();
            cbbChucDanh.DisplayMember = "LoaiQuyen";
            cbbChucDanh.ValueMember = "IDQuyen";
            //LayHinh();


            dgvThongTinNhanVien.DataSource = _nhanvienBUS.LayDSNhanVien();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ( String.IsNullOrEmpty(txtHoTen.Text) || String.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtTaiKhoan.Text) 
                || String.IsNullOrEmpty(txtMatKhau.Text) || dtpNgaySinh.Value >= DateTime.Now)
            {
                MessageBox.Show(Constants.ERR_REQUIRED, Constants.MESSAGE_TITLE);

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

                    //SaveImage(picNhanVien.Image);
                   
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

            NhanVienDTO nv = new NhanVienDTO
            {
                IDNV = txtID.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = ChonGioiTinh(),
                ChucDanh = cbbChucDanh.Text,
                LoaiNV = cbbLoaiNhanVien.Text,
                SDT = txtSDT.Text,
                TaiKhoan = txtTaiKhoan.Text,
                MatKhau = txtMatKhau.Text,
                Email = txtEmail.Text

            };
            if (_nhanvienBUS.CapNhatNV(nv))
            {
                MessageBox.Show(Constants.UPDATE_SUCESS, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmThongTinNhanVien_Load(sender, e);
            }
            else MessageBox.Show(Constants.UPDATE_FAIL, Constants.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvThongTinNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvThongTinNhanVien.Rows[dgvThongTinNhanVien.CurrentCell.RowIndex];
            int hang = e.RowIndex;
            try
            {
                txtID.Text = dgvThongTinNhanVien.Rows[hang].Cells[0].Value.ToString();
                txtHoTen.Text = dgvThongTinNhanVien.Rows[hang].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvThongTinNhanVien.Rows[hang].Cells[2].Value.ToString();
                if (dgvThongTinNhanVien.Rows[hang].Cells[3].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
                cbbChucDanh.Text = dgvThongTinNhanVien.Rows[hang].Cells[4].Value.ToString();
                cbbLoaiNhanVien.Text = dgvThongTinNhanVien.Rows[hang].Cells[5].Value.ToString();
                txtSDT.Text = dgvThongTinNhanVien.Rows[hang].Cells[6].Value.ToString();
                txtTaiKhoan.Text = dgvThongTinNhanVien.Rows[hang].Cells[7].Value.ToString();
                txtMatKhau.Text = dgvThongTinNhanVien.Rows[hang].Cells[8].Value.ToString();
                txtEmail.Text = dgvThongTinNhanVien.Rows[hang].Cells[9].Value.ToString();
                string path = string.Format(@"{0}\..\..\imgNhanVien\{1}", Environment.CurrentDirectory,
                    dgvThongTinNhanVien.Rows[hang].Cells[10].Value.ToString());
                picNhanVien.Image = Image.FromFile(path);

            }
            catch
            {

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
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
            txtID.Text = (_nhanvienBUS.MAXID() + (int)1);
            frmThongTinNhanVien_Load(sender, e);


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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(radHoTen.Checked == true )
            {
               dgvThongTinNhanVien.DataSource = _nhanvienBUS.TimKiemIDNV(txtTimKiem.Text);
                return;
            }
            if(radID.Checked == true )
            {
                dgvThongTinNhanVien.DataSource = _nhanvienBUS.TimKiemIDNV(txtTimKiem.Text);
                return;
            }    
        }
    }
}

