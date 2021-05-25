using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Form_SPham
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            form_Them_sua form = new form_Them_sua();
            form.ShowDialog();
        }

        private void tbx_search_Click(object sender, EventArgs e)
        {
            
            tbx_search.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            form_View form = new form_View();
            form.ShowDialog();
        }
    }
}
