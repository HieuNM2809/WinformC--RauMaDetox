using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DashBoar
{
    
    public partial class QL_SanPham : Form
    {     
        private BUS_sanpham _sanpham= new BUS_sanpham();
        private BUS_loaisp _dsloai = new BUS_loaisp();
        public QL_SanPham()
        {
            InitializeComponent();
            cbb_loai.DataSource= _dsloai.LayDSloaisp();
            cbb_loai.DisplayMember= "MaLoaiSp";
            cbb_loai.ValueMember = "MaLoaiSp";
            cbb_xoa_loai.DataSource = _dsloai.LayDSloaisp();
            cbb_xoa_loai.DisplayMember = "MaLoaiSp";
            cbb_xoa_loai.ValueMember = "MaLoaiSp";
        }
        //////////////////////////////////////// xử lý dữ liệu vào datagitview///////////////////////////////////////////

        private void QL_SanPham_Load(object sender, EventArgs e, string a)
        {
            DTGV_xem.DataSource = _sanpham.LayDSsanpham(a);
            dtgv_xoa.DataSource = _sanpham.LayDSsanpham(a);
            dtgv_loaisp.DataSource = _dsloai.LayDSloaisp();
        }
       private void QL_SanPham_Load_1(object sender, EventArgs e)
        {
            string a = "001";
            QL_SanPham_Load(sender, e, a);
            
           
        }
   //////////////////////////////////////////////////////// các button thoát//////////////////////////////////////////////////////////
        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_loaisp_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /////////////////////////////////////////////////////////xử lý tap xem////////////////////////////////////////////////////
        private void DTGV_xem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.DTGV_xem.Rows[e.RowIndex];
                lbl_mamon.Text = row.Cells[0].Value.ToString();
                lbl_tenmon.Text = row.Cells[1].Value.ToString();
                lbl_loai.Text = row.Cells[2].Value.ToString();
                lbl_gia.Text = row.Cells[3].Value.ToString();
                lbl_mota.Text = row.Cells[4].Value.ToString();
                lbl_trangthai.Text = row.Cells[6].Value.ToString();

            }
        }

        private void rb_nuoc_CheckedChanged(object sender, EventArgs e)
        {
            string a = "001";
            
            QL_SanPham_Load(sender, e, a);
        }

        private void rb_topping_CheckedChanged(object sender, EventArgs e)
        {
            string a = "002";
            
            QL_SanPham_Load(sender, e, a);
        }
 
       ////////////////////////////////// xử lý tap thêm//////////////////////////////////////////////////////////////////
        
        private void btn_Themanh_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tbx_mamon.Text == "" || tbx_tenmon.Text == "" || tbx_gia.Text == "" || cbb_loai.Text == "" || rtb_mota.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");


            }
            else
            {
            
                {
                    DTO_sanpham spham = new DTO_sanpham();
                    {
                        spham.Masp = tbx_mamon.Text;
                        spham.Tensp = tbx_tenmon.Text;
                        spham.Giasp = Convert.ToInt32(tbx_gia.Text);
                        spham.Mota = rtb_mota.Text;
                        spham.MaLoaisp = cbb_loai.Text;

                    };
                    if (_sanpham.ThemSP(spham))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        QL_SanPham_Load_1(sender, e);
                    }
                    else MessageBox.Show("Thêm Thất bại", "Thông báo");
                }
            }
            
        } 
        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            tbx_mamon.Text = "";
            tbx_tenmon.Text = "";
            tbx_gia.Text = "";
            cbb_loai.SelectedIndex = 0;
            rtb_mota.Text = "";
            
        }
//xử lý ảnh
     

      
       //////////////////////////////////////////////////////tap sua///////////////////////////////////////////////////
        private void btn_sua_Click(object sender, EventArgs e)
        {
            DTO_sanpham sanpham = new DTO_sanpham();

            sanpham.Masp = tbx_xoa_mamon.Text;
            sanpham.Tensp = tbx_xoa_tenmon.Text;
            sanpham.Giasp = Convert.ToInt32(tbx_xoa_gia.Text);
            sanpham.Mota = tbx_xoa_mota.Text;
            sanpham.MaLoaisp = cbb_xoa_loai.Text;
            sanpham.Trangthaisp =true;
            if (_sanpham.SuaSP (sanpham))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QL_SanPham_Load_1(sender, e);
            }
            else MessageBox.Show("Cập nhật thât bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void tp_view_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_nhaplai_Click(object sender, EventArgs e)
        {
            tbx_xoa_gia.Text = "";
            tbx_xoa_mamon.Text = "";
            tbx_xoa_mota.Text = "";
            tbx_xoa_tenmon.Text = "";        
        }

        private void dtgv_xoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DTGV_xem.Rows[e.RowIndex];
            tbx_xoa_mamon.Text = row.Cells[0].Value.ToString();
            tbx_xoa_tenmon.Text = row.Cells[1].Value.ToString();
            cbb_xoa_loai.Text = row.Cells[2].Value.ToString();
            tbx_xoa_gia.Text = row.Cells[3].Value.ToString();
            tbx_xoa_mota.Text = row.Cells[4].Value.ToString();
        }

        private void rdb_xoa_nuoc_CheckedChanged(object sender, EventArgs e)
        {
            string a = "001";
            QL_SanPham_Load(sender, e, a);
        }

        private void rdb_xoa_topping_CheckedChanged(object sender, EventArgs e)
        {
            string a = "002"; 
            QL_SanPham_Load(sender, e, a);
        }
    }
}

