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
        private static string _connectionString = @"Data Source=DESKTOP-KLO6537\SQLEXPRESS;Initial Catalog=ql_rauma;Integrated Security=True";

        private SqlConnection _conn = new SqlConnection(_connectionString);

        public List<NhanVienDTO> LayDSNhanVien()
        {
            List<NhanVienDTO> lstSinhVien = new List<NhanVienDTO>();

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

                    lstSinhVien.Add(nv);
                }
            }

            _conn.Close();

            return lstSinhVien;
        }

        
    }
}
