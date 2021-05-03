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

namespace DashBoar
{
    public partial class FrmDangKiTaiKhoan : Form
    {
        //string strConnection = @"Data Source=DESKTOP-KLO6537\SQLEXPRESS;Initial Catalog=ql_rauma;Integrated Security=True";
        public FrmDangKiTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ////tao doi tuong ket noi
            //SqlConnection conn = new SqlConnection(strConnection);

            ////mo ket noi
            //conn.Open();

            ////Câu truy vấn thêm đối tượng sinh viên mới
            //string sqlFomat = "INSERT INTO CT_PhanQuyen(ID_NV, TaiKhoan, MatKhau, LoaiQuyen) VALUES ('{0}', N'{1}', '{2}', '{3}', '{4}')";

            ////Hoàn thiện câu truy vấn
            //string sql = string.Format(sqlFomat, txtMaNhanVien.Text, txtDangNhap.Text, txtMatKhau.Text, cbbChứcDanh.Text);

            ////tạo đối tượng thực thi
            //SqlCommand cmd = new SqlCommand(sql, conn);

            //int count = cmd.ExecuteNonQuery();

            //if (count > 0)
            //{
            //    // Thêm thành công
            //    MessageBox.Show("Thêm thành công", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    // Thêm thất bại
            //    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}



        }


    }
}
