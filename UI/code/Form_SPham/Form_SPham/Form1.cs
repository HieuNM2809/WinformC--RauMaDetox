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
        private string connectionString = @"Data Source=.;Initial Catalog=ql_rauma;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            form_Them_sua form = new form_Them_sua();
            form.ShowDialog();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_dsSanPham.DataSource = GetAllSanPham().Tables[0];
        }
        DataSet GetAllSanPham() 
        {
            DataSet data = new DataSet();
            String QLSanPham = "SELECT * FROM SanPham";
            using (SqlConnection connection= new SqlConnection(connectionString) )
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(QLSanPham, connection);
                adapter.Fill(data);
                connection.Close(); 
            }
            return data;
        }
    }
}
