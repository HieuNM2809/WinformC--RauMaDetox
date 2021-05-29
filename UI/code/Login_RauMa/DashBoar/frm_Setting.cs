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
    public partial class frm_Setting : Form
    {
        public frm_Setting()
        {
            InitializeComponent();
        }

        private void btn_chonmau_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog(); //Khởi tạo đối tượng ColorDialog 
           

            if (dlg.ShowDialog() == DialogResult.OK) //Nếu nhấp vào nút OK trên hộp thoại
            {
                string str = null; //Khai báo biến str
                tbx_maumau.BackColor = dlg.Color;
                 str= dlg.Color.Name;
            }
        }

        private void btn_ketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void lol(object Form)
        {
            frmDashboar db = Form as frmDashboar;
            if (cbb_tyle.Text == "1600x900")
            {
                db.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            }
            else
            {
                db.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            db.Show();
        }
        public void btn_xacnhan_Click(object sender, EventArgs e)
        {
            frmDashboar dc = new frmDashboar();
            lol(dc);
        }

    }
}
