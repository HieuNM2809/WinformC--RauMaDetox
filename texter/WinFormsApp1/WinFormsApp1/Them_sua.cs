using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Them_sua : Form
    {
        public Them_sua()
        {
            InitializeComponent();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Them_sua_Load(object sender, EventArgs e)
        {
            tbx_tenmon.Text = sua_tenmon;
            tbx_gia.Text = sua_gia;
            tbx_loaisp.Text = sua_loaisp;
            tbx_masp.Text = sua_masp;
            tbx_Mota.Text = sua_mota;
        }
        public string sua_tenmon;
        public string sua_masp;
        public string sua_gia;
        public string sua_mota;
        public string sua_loaisp;
       
    }
}
