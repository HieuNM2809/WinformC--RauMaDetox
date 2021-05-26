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
    public partial class from_Setting : Form
    {
        public from_Setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog(); //Khởi tạo đối tượng ColorDialog 
            if (dlg.ShowDialog() == DialogResult.OK) //Nếu nhấp vào nút OK trên hộp thoại
            {
                string str = null; //Khai báo biến str
                str = dlg.Color.Name; //Trả lại tên của màu đã lựa chọn
                tbx_maumau.BackColor = dlg.Color; //Hiển thị lên MessageBox
            }
        }
    }
}
