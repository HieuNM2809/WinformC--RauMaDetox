using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
   public class DAO_sanpham
    {
        //CHỈNH LẠI TƯƠNG TÁC BẰNG ENTYTIES NHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        


        public List<DTO_sanpham> LayDSSanpham()
        {
            List<DTO_sanpham> lstsanpham = new List<DTO_sanpham>();

            _conn.Open();

            string sql = "SELECT a.Masp,a.Tensp,a.GiaTien,b.tenloaiSp,a.TrangThai,a.Mota FROM sanpham a,phanloaisp b WHERE a.Maloaisp=b.maloaisp and a.TrangThai = 1";

            SqlCommand cmd = new SqlCommand(sql, _conn);

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    DTO_sanpham sp = new DTO_sanpham
                    {
                        Masp = sdr.GetString(0),
                        Tensp = sdr.GetString(1),
                       Giasp=sdr.GetInt32(2),
                        Loaisp = sdr.GetString(3),
                        Trangthaisp=sdr.GetBoolean(4),
                        Mota=sdr.GetString(5),

                    };

                    lstsanpham.Add(sp);
                }
            }

            _conn.Close();

            return lstsanpham;
        }
        public bool KiemTraMaSP(string mssp)
        {
            _conn.Open();

            string sqlFormat = "SELECT COUNT(*) FROM phanloaisp WHERE Trangthai=1";
            string sql = string.Format(sqlFormat, mssp);

            SqlCommand cmd = new SqlCommand(sql, _conn);

            object value = cmd.ExecuteScalar();

            _conn.Close();

            return Convert.ToInt32(value) > 0;
        }
        public List<DTO_sanpham> laytheoloai(string a)
        {
            List<DTO_sanpham> Laytheoloai = new List<DTO_sanpham>();
            _conn.Open();
            string sqltheoloai="";
            if (a=="001")
            {
                sqltheoloai = "SELECT a.Masp,a.Tensp,a.Giatien,b.Tenloaisp,a.Trangthai, a.Mota FROM SanPham a, phanloaisp b WHERE a.MaLoaiSp = b.MaLoaiSp and a.Trangthai = 1 and a.maloaisp = 001  group by a.Masp,a.Tensp,a.Giatien,b.Tenloaisp,a.Trangthai, a.Mota";
            }
            else
            {
                sqltheoloai= "SELECT a.Masp,a.Tensp,a.Giatien,b.Tenloaisp,a.Trangthai, a.Mota FROM SanPham a, phanloaisp b WHERE a.MaLoaiSp = b.MaLoaiSp and a.Trangthai = 1 and a.maloaisp = 002  group by a.Masp,a.Tensp,a.Giatien,b.Tenloaisp,a.Trangthai, a.Mota";
            }
            SqlCommand cmd = new SqlCommand(sqltheoloai, _conn);

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    DTO_sanpham sp = new DTO_sanpham
                    {
                        Masp = sdr.GetString(0),
                        Tensp = sdr.GetString(1),
                        Giasp = sdr.GetInt32(2),
                        Loaisp = sdr.GetString(3),
                        Trangthaisp = sdr.GetBoolean(4),
                        Mota = sdr.GetString(5),

                    };

                    Laytheoloai.Add(sp);
                }
            }

            _conn.Close();
            return Laytheoloai;
        }
        public bool ThemSP(DTO_sanpham sp)
        {
            string sqlInsert = "INSERT INTO Sanpham(Masp,Tensp,giatien,MaLoaiSp,MoTa,TrangThai) VALUES (@Masp,@Tensp,@giatien,@MaLoaiSp,@MoTa,1)";

            _conn.Open();
            List<SqlParameter> lstsp = new List<SqlParameter>();
            lstsp.Add(new SqlParameter("@Masp", sp.Masp));
            lstsp.Add(new SqlParameter("@Tensp", sp.Tensp));
            lstsp.Add(new SqlParameter("@Giatien", sp.Giasp));
            lstsp.Add(new SqlParameter("@Maloaisp", sp.Loaisp));
            lstsp.Add(new SqlParameter("@Mota", sp.Mota));
            lstsp.Add(new SqlParameter("@Trangthai", 1));
            SqlCommand cmd = new SqlCommand(sqlInsert, _conn);

            cmd.Parameters.AddRange(lstsp.ToArray());

            int result = cmd.ExecuteNonQuery();

            _conn.Close();

            return result > 0;
        }

    }

}
