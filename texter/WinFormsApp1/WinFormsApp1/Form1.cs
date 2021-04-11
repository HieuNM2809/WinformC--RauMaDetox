using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lv_danhsachmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vitri=0;
            if (lv_danhsachmon.SelectedItems.Count > 0)
            {
                lbl_tenmon.Text = lv_danhsachmon.SelectedItems[0].SubItems[0].Text;
                 vitri = lv_danhsachmon.SelectedItems[0].ImageIndex;
                ptbx_anhto.BackgroundImage = lv_danhsachmon.SelectedItems[0].ImageList.Images[vitri];
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //tao form
            Them_sua them = new Them_sua();
            //hien th form
            them.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Them_sua sua = new Them_sua();
           
            sua.sua_tenmon = lbl_tenmon.Text;
            sua.sua_gia = lbl_gia.Text;
            sua.sua_masp = lbl_msp.Text;
            sua.sua_mota = lbl_mota.Text;
            sua.sua_loaisp = lbl_lsp.Text;
            sua.ShowDialog();
        }
    }
}
