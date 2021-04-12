using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhanVien
{
    
    public partial class FrmThem : Form
    {
        
        public FrmThem()
        {
            InitializeComponent();
            
        }
        
        private void btnDongY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã thêm thành công", "thông báo");
            this.Close();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã hủy", "thông báo");
            this.Close();
        }
    
    }
}
