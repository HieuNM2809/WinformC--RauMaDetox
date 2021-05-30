using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace DashBoar
{
    public partial class frmBaoCao : Form
    {
        NhanVienBUS nv = new NhanVienBUS();
        public frmBaoCao()
        {
            InitializeComponent();
            cbbLoaiNV.ValueMember = "LoaiNV";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
                if (radDSNV.Checked == true)
                {
                    frmXemBaoCao frmBC = new frmXemBaoCao();
                    frmBC.XemDanhSachNhanVien();
                    frmBC.ShowDialog();
                }


                 if (radDSNVTL.Checked == true)
                 {
                    frmXemBaoCao frmBC = new frmXemBaoCao();
                    frmBC.XemDSNVTheoLoai(cbbLoaiNV.Text);
                    frmBC.ShowDialog();
                 }

                 if (radDSNVTN.Checked == true)
                 {
                    frmXemBaoCao frmBC = new frmXemBaoCao();
                    frmBC.XemDSNVTheoNhom();
                    frmBC.ShowDialog();
                  }
        }
    }
}
