using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoar
{
    public partial class Them_sua : Form
    {
        public Them_sua()
        {
            InitializeComponent();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            tbx_gia.Text = "";
            tbx_mamon.Text = "";
            tbx_mota.Text = "";
            tbx_tenmon.Text = "";
            cbb_loai.Text = "";
            ptb_taianh.BackgroundImage = null;
        }

        private void btn_taianh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Hinh Anh|*.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr != System.Windows.Forms.DialogResult.Cancel) //co chon file
            {
                byte[] byteHA = File.ReadAllBytes(ofd.FileName);
                MemoryStream ms = new MemoryStream(byteHA);
                ptb_taianh.BackgroundImage = Image.FromStream(ms);
            }
            else
            {
                ptb_taianh.BackgroundImage = null;
            }
        }
    }
}
