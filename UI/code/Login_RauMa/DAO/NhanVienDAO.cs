using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        private static string _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ql_rauma;Integrated Security=True";

        private SqlConnection _conn = new SqlConnection(_connectionString);

        public List<NhanVienDTO> LayDSNhanVien()
        {
            List<NhanVienDTO> lstNhanVien = new List<NhanVienDTO>();

            _conn.Open();

            string sql = "SELECT * FROM NhanVien WHERE TrangThai = 1";

            SqlCommand cmd = new SqlCommand(sql, _conn);

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO
                    {
                        ID_NV = sdr.GetString(0),
                        HoTen = sdr.GetString(1),
                        NgaySinh = sdr.GetDateTime(2),
                        GioiTinh = sdr.GetString(3),
                        ChucDanh = sdr.GetString(4),
                        LoaiNV = sdr.GetString(5),
                        SDT = sdr.GetString(6),
                        TaiKhoan = sdr.GetString(7),
                        MatKhau = sdr.GetString(8),
                        Email = sdr.GetString(9),
                    };

                    lstNhanVien.Add(nv);
                }
            }

            _conn.Close();

            return lstNhanVien;
        }

        public bool KiemTraNhanVien(string MSSV)
        {
            _conn.Open();

            string sqlFormat = "SELECT COUNT(*) FROM NhanVien WHERE ID_NV = '{0}'";
            string sql = string.Format(sqlFormat, MSSV);

            SqlCommand cmd = new SqlCommand(sql, _conn);

            object value = cmd.ExecuteScalar();

            _conn.Close();

            return Convert.ToInt32(value) > 0;
        }
        public bool ThemNV(NhanVienDTO nv)
        {
            string sqlInsert = "Insert into NhanVien(ID_NV, HoTen, NgaySinh, GioiTinh, ChucDanh, LoaiNV, SDT, TaiKhoan, MatKhau, Email, TrangThai) VALUES (@ID_NV,@HoTen,@NgaySinh,@GioiTinh,@ChucDanh,@LoaiNV,@SDT,@TaiKhoan,@MatKhau,@Email,1)";

            _conn.Open();
            List<SqlParameter> lstParameter = new List<SqlParameter>();
            lstParameter.Add(new SqlParameter("@ID_NV", nv.ID_NV));
            lstParameter.Add(new SqlParameter("@HoTen", nv.HoTen));
            lstParameter.Add(new SqlParameter("@NgaySinh", nv.NgaySinh));
            lstParameter.Add(new SqlParameter("@GioiTinh", nv.GioiTinh));
            lstParameter.Add(new SqlParameter("@ChucDanh", nv.ChucDanh));
            lstParameter.Add(new SqlParameter("@LoaiNV", nv.LoaiNV));
            lstParameter.Add(new SqlParameter("@SDT", nv.SDT));
            lstParameter.Add(new SqlParameter("@TaiKhoan", nv.TaiKhoan));
            lstParameter.Add(new SqlParameter("@MatKhau", nv.MatKhau));
            lstParameter.Add(new SqlParameter("@Email", nv.Email));

            SqlCommand cmd = new SqlCommand(sqlInsert, _conn);

            cmd.Parameters.AddRange(lstParameter.ToArray());

            int result = cmd.ExecuteNonQuery();

            _conn.Close();

            return result > 0;
        }

        public bool CapNhatNV(NhanVienDTO nv)
        {
            string sqlUpdate = "Update SinhVien Set HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, ChucDanh = @ChucDanh," +
                " LoaiNv = @LoaiNV, SDT = @SDT, TaiKhoan = @TaiKhoan, MatKhau=@MatKhau, Email=@Email where ID_NV = @ID_NV";

            _conn.Open();
            List<SqlParameter> lstParameter = new List<SqlParameter>();
            lstParameter.Add(new SqlParameter("@ID_NV", nv.ID_NV));
            lstParameter.Add(new SqlParameter("@HoTen", nv.HoTen));
            lstParameter.Add(new SqlParameter("@NgaySinh", nv.NgaySinh));
            lstParameter.Add(new SqlParameter("@GioiTinh", nv.GioiTinh));
            lstParameter.Add(new SqlParameter("@ChucDanh", nv.ChucDanh));
            lstParameter.Add(new SqlParameter("@LoaiNV", nv.LoaiNV));
            lstParameter.Add(new SqlParameter("@SDT", nv.SDT));
            lstParameter.Add(new SqlParameter("@TaiKhoan", nv.TaiKhoan));
            lstParameter.Add(new SqlParameter("@MatKhau", nv.MatKhau));
            lstParameter.Add(new SqlParameter("@Email", nv.Email));

            SqlCommand cmd = new SqlCommand(sqlUpdate, _conn);
            cmd.Parameters.AddRange(lstParameter.ToArray());

            int result = cmd.ExecuteNonQuery();

            _conn.Close();

            return result > 0;
        }


    }
}
