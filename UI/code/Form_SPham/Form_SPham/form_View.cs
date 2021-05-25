using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_SPham
{

    public partial class form_View : Form
    {
     
        public form_View()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_Them_sua form = new form_Them_sua();
            form.ShowDialog();
        }
    }
}
