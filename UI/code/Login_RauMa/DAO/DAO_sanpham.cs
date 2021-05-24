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


        ql_raumaEntities1 qlrauma = new ql_raumaEntities1();

        public List<DTO_sanpham> LayDSSanpham()
        {
            List<DTO_sanpham> lssanpham = new List<DTO_sanpham>();
            lssanpham = qlrauma.SanPhams.Where(v => v.TrangThai == 1).Select(u => new DTO_sanpham

            {
                Masp = u.MaSp,
                Tensp = u.TenSp,
                MaLoaisp = u.MaLoaiSp,
                Giasp = (int)u.GiaTien,
                
                Mota = u.MoTa,
                Trangthaisp = true


            }).ToList();
            return lssanpham;
        }

        //    List<DTO_sanpham> lstsanpham = new List<DTO_sanpham>();

        //    _conn.Open();

        //    string sql = "SELECT a.Masp,a.Tensp,a.GiaTien,b.tenloaiSp,a.TrangThai,a.Mota FROM sanpham a,phanloaisp b WHERE a.Maloaisp=b.maloaisp and a.TrangThai = 1";

        //    SqlCommand cmd = new SqlCommand(sql, _conn);

        //    SqlDataReader sdr = cmd.ExecuteReader();

        //    if (sdr.HasRows)
        //    {
        //        while (sdr.Read())
        //        {
        //            DTO_sanpham sp = new DTO_sanpham
        //            {
        //                Masp = sdr.GetString(0),
        //                Tensp = sdr.GetString(1),
        //               Giasp=sdr.GetInt32(2),
        //                Loaisp = sdr.GetString(3),
        //                Trangthaisp=sdr.GetBoolean(4),
        //                Mota=sdr.GetString(5),

        //            };

        //            lstsanpham.Add(sp);
        //        }
        //    }

        //    _conn.Close();

        //    return lstsanpham;
        //}
        //    public bool KiemTraMaSP(string mssp)
        //    {
        //        _conn.Open();

        //        string sqlFormat = "SELECT COUNT(*) FROM phanloaisp WHERE Trangthai=1";
        //        string sql = string.Format(sqlFormat, mssp);

        //        SqlCommand cmd = new SqlCommand(sql, _conn);

        //        object value = cmd.ExecuteScalar();

        //        _conn.Close();

        //        return Convert.ToInt32(value) > 0;
        //    }
        //    public List<DTO_sanpham> laytheoloai(string a)
        //    {
        //        List<DTO_sanpham> Laytheoloai = new List<DTO_sanpham>();
        //        _conn.Open();
        //        string sqltheoloai="";
        //        if (a=="001")
        //        {
        //            sqltheoloai = "SELECT a.Masp,a.Tensp,a.Giatien,b.Tenloaisp,a.Trangthai, a.Mota FROM SanPham a, phanloaisp b WHERE a.MaLoaiSp = b.MaLoaiSp and a.Trangthai = 1 and a.maloaisp = 001  group by a.Masp,a.Tensp,a.Giatien,b.Tenloaisp,a.Trangthai, a.Mota";
        //        }
        //        else
        //        {
        //            sqltheoloai= "SELECT a.Masp,a.Tensp,a.Giatien,b.Tenloaisp,a.Trangthai, a.Mota FROM SanPham a, phanloaisp b WHERE a.MaLoaiSp = b.MaLoaiSp and a.Trangthai = 1 and a.maloaisp = 002  group by a.Masp,a.Tensp,a.Giatien,b.Tenloaisp,a.Trangthai, a.Mota";
        //        }
        //        SqlCommand cmd = new SqlCommand(sqltheoloai, _conn);

        //        SqlDataReader sdr = cmd.ExecuteReader();

        //        if (sdr.HasRows)
        //        {
        //            while (sdr.Read())
        //            {
        //                DTO_sanpham sp = new DTO_sanpham
        //                {
        //                    Masp = sdr.GetString(0),
        //                    Tensp = sdr.GetString(1),
        //                    Giasp = sdr.GetInt32(2),
        //                    Loaisp = sdr.GetString(3),
        //                    Trangthaisp = sdr.GetBoolean(4),
        //                    Mota = sdr.GetString(5),

        //                };

        //                Laytheoloai.Add(sp);
        //            }
        //        }

        //        _conn.Close();
        //        return Laytheoloai;
        //    }
        public bool ThemSP(DTO_sanpham sp)
        {
            SanPham SP = new SanPham();
            SP.MaSp = sp.Masp;
            SP.MaLoaiSp = sp.MaLoaisp;
            SP.GiaTien = sp.Giasp;
            SP.MoTa = sp.Mota;
            SP.TenSp = sp.Tensp;
            SP.TrangThai = 1;
            SanPham sanphamEF = qlrauma.SanPhams.Add(SP);
            qlrauma.SaveChanges();
            return sanphamEF.MaSp != "" ;
        }
        public bool SuaSP(DTO_sanpham sp)
        {
            try
            {
                SanPham SP = qlrauma.SanPhams.SingleOrDefault(u => u.MaSp == sp.Masp && u.TenSp == sp.Tensp && u.MaLoaiSp == sp.MaLoaisp
                  && u.MoTa == sp.Mota && u.TrangThai == 1);
                SP.MaSp = sp.Masp;
                SP.TenSp = sp.Tensp;
                SP.MaLoaiSp = sp.MaLoaisp;
                SP.GiaTien = sp.Giasp;
                SP.TrangThai = 1;
                qlrauma.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool xoaSP(DTO_sanpham sp)
        {
            try
            {
                SanPham SP = qlrauma.SanPhams.SingleOrDefault(u => u.MaSp == sp.Masp && u.TenSp == sp.Tensp && u.MaLoaiSp == sp.MaLoaisp
                  && u.MoTa == sp.Mota && u.TrangThai == 1);
                SP.MaSp = sp.Masp;
                SP.TenSp = sp.Tensp;
                SP.MaLoaiSp = sp.MaLoaisp;
                SP.GiaTien = sp.Giasp;
                SP.TrangThai = 0;
                qlrauma.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }

}
