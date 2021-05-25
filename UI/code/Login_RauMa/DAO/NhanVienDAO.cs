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
        private static string _connecstring = @"Data Source=RAUMA;Initial Catalog=ql_rauma;Integrated Security=True";

        private SqlConnection _conn = new SqlConnection(_connecstring);

        ql_raumaEntities1 qlrauma = new ql_raumaEntities1();

        public List<NhanVienDTO> LayDSNhanVien()
        {
            ////List<NhanVienDTO> lstNhanVien = new List<NhanVienDTO>();

            //_conn.Open();

            //string sql = "SELECT * FROM NhanVien WHERE TrangThai = 1";

            //SqlCommand cmd = new SqlCommand(sql, _conn);

            //SqlDataReader sdr = cmd.ExecuteReader();

            //if (sdr.HasRows)
            //{
            //    while (sdr.Read())
            //    {
            //        NhanVienDTO nv = new NhanVienDTO
            //        {
            //            ID_NV = sdr.GetString(0),
            //            HoTen = sdr.GetString(1),
            //            NgaySinh = sdr.GetDateTime(2),
            //            GioiTinh = sdr.GetString(3),
            //            ChucDanh = sdr.GetString(4),
            //            LoaiNV = sdr.GetString(5),
            //            SDT = sdr.GetString(6),
            //            TaiKhoan = sdr.GetString(7),
            //            MatKhau = sdr.GetString(8),
            //            Email = sdr.GetString(9),
            //        };

            //        lstNhanVien.Add(nv);
            //    }
            //}

            //_conn.Close();

            List<NhanVienDTO> lsnhanvien = new List<NhanVienDTO>();

            lsnhanvien = qlrauma.NhanViens.Where(v => v.TrangThai == 1).Select(u => new NhanVienDTO
            {
                IDNV = u.IDNV,
                HoTen = u.HoTen,
                NgaySinh = u.NgaySinh.Value,
                GioiTinh = u.GioiTinh,
                ChucDanh = u.ChucDanh,
                LoaiNV = u.LoaiNV,
                TaiKhoan = u.TaiKhoan,
                MatKhau = u.MatKhau,
                SDT = u.SDT,
                Email = u.Email

            }).ToList();

            return lsnhanvien;
        }

        public bool KiemTraNhanVien(string IDNV)
        {
            _conn.Open();

            string sqlFormat = "SELECT COUNT(*) FROM NhanVien WHERE IDNV = '{0}'";

            string sql = string.Format(sqlFormat, IDNV);

            SqlCommand cmd = new SqlCommand(sql, _conn);

           object value = cmd.ExecuteScalar();

            _conn.Close();

            return Convert.ToInt32(value) > 0;
        }
        public bool ThemNV(NhanVienDTO nv)
        {
            //string sqlInsert = "Insert into NhanVien(ID_NV, HoTen, NgaySinh, GioiTinh, ChucDanh, LoaiNV, SDT, TaiKhoan, MatKhau, Email, TrangThai) VALUES (@ID_NV,@HoTen,@NgaySinh,@GioiTinh,@ChucDanh,@LoaiNV,@SDT,@TaiKhoan,@MatKhau,@Email,1)";

            //_conn.Open();
            //List<SqlParameter> lstParameter = new List<SqlParameter>();
            //lstParameter.Add(new SqlParameter("@ID_NV", nv.IDNV));
            //lstParameter.Add(new SqlParameter("@HoTen", nv.HoTen));
            //lstParameter.Add(new SqlParameter("@NgaySinh", nv.NgaySinh));
            //lstParameter.Add(new SqlParameter("@GioiTinh", nv.GioiTinh));
            //lstParameter.Add(new SqlParameter("@ChucDanh", nv.ChucDanh));
            //lstParameter.Add(new SqlParameter("@LoaiNV", nv.LoaiNV));
            //lstParameter.Add(new SqlParameter("@SDT", nv.SDT));
            //lstParameter.Add(new SqlParameter("@TaiKhoan", nv.TaiKhoan));
            //lstParameter.Add(new SqlParameter("@MatKhau", nv.MatKhau));
            //lstParameter.Add(new SqlParameter("@Email", nv.Email));

            //SqlCommand cmd = new SqlCommand(sqlInsert, _conn);

            //cmd.Parameters.AddRange(lstParameter.ToArray());

            //int result = cmd.ExecuteNonQuery();

            //_conn.Close();

            //return result > 0;
            NhanVien nhanvien = new NhanVien();

            nhanvien.IDNV = nv.IDNV;
            nhanvien.HoTen = nv.HoTen;
            nhanvien.NgaySinh = nv.NgaySinh;
            nhanvien.GioiTinh = nv.GioiTinh;
            nhanvien.ChucDanh = nv.ChucDanh;
            nhanvien.LoaiNV = nv.LoaiNV;
            nhanvien.TaiKhoan = nv.TaiKhoan;
            nhanvien.MatKhau = nv.MatKhau;
            nhanvien.SDT = nv.SDT;
            nhanvien.Email = nv.Email;
            nhanvien.TrangThai = 1;

            NhanVien nhanvienEF = qlrauma.NhanViens.Add(nhanvien);
            qlrauma.SaveChanges();

            return true;
        }

        public bool CapNhatNV(NhanVienDTO nv)
        {
          
            try
            {
                NhanVien nhanvien = qlrauma.NhanViens.SingleOrDefault(u => u.IDNV == nv.IDNV && u.TrangThai == 1);
                nhanvien.HoTen = nv.HoTen;
                nhanvien.NgaySinh = nv.NgaySinh;
                nhanvien.GioiTinh = nv.GioiTinh;
                nhanvien.ChucDanh = nv.ChucDanh;
                nhanvien.LoaiNV = nv.LoaiNV;
                nhanvien.TaiKhoan = nv.TaiKhoan;
                nhanvien.MatKhau = nv.MatKhau;
                nhanvien.SDT = nv.SDT;
                nhanvien.Email = nv.Email;

               


                qlrauma.SaveChanges();

                return true ;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaNV(NhanVienDTO nv)
        {
            try
            {
                //NhanVien nhanvien = qlrauma.NhanViens.SingleOrDefault(u => u.IDNV == nv.IDNV && u.TrangThai == 1);
                //nhanvien.TrangThai = 0;

                

                qlrauma.SaveChanges();

                return true;
            }
            catch( Exception)
            {
                return false;
            }
        }

        public bool DoiMatKhau(NhanVienDTO nv)
        {
            try
            {
                NhanVien nhanVien = qlrauma.NhanViens.SingleOrDefault(u => u.TaiKhoan  == nv.TaiKhoan && u.TrangThai == 1);
                nhanVien.MatKhau = nhanVien.MatKhau;
                qlrauma.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool KiemTraTaiKhoan(string TK)
        {
            _conn.Open();

            string sqlFormat = "SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = '{0}'";

            string sql = string.Format(sqlFormat, TK);

            SqlCommand cmd = new SqlCommand(sql, _conn);

            object value = cmd.ExecuteScalar();

            _conn.Close();

            return Convert.ToInt32(value) > 0;
        }

        public bool KiemTraMatKhau(string MK)
        {
            _conn.Open();

            string sqlFormat = "SELECT COUNT(*) FROM NhanVien WHERE MatKhau = '{0}'";

            string sql = string.Format(sqlFormat, MK);

            SqlCommand cmd = new SqlCommand(sql, _conn);

            object value = cmd.ExecuteScalar();

            _conn.Close();

            return Convert.ToInt32(value) > 0;
        }

        public bool DangKiTaiKhoan(NhanVienDTO nv)
        {
            try
            {
                NhanVien nhanvien = qlrauma.NhanViens.SingleOrDefault(u => u.IDNV == nv.IDNV && u.TrangThai == 1);
                nhanvien.TaiKhoan = nv.TaiKhoan;
                nhanvien.MatKhau = nv.MatKhau;

                qlrauma.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}