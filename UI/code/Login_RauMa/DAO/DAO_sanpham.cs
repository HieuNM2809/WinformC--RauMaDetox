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

        public List<DTO_sanpham> LayDSSanpham(string a)
        {
            List<DTO_sanpham> lssanpham = new List<DTO_sanpham>();
            lssanpham = qlrauma.SanPhams.Where(v => v.TrangThai==1).Where(l => l.MaLoaiSp == a).Select(u => new DTO_sanpham
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
               SanPham sanpham = qlrauma.SanPhams.SingleOrDefault(u => u.MaSp == sp.Masp && u.TrangThai == 1);
                sanpham.TenSp = sp.Tensp;
                sanpham.MaLoaiSp = sp.MaLoaisp;
                sanpham.GiaTien = sp.Giasp;
                sanpham.MoTa = sp.Mota;
                sanpham.Hinh = null;
                qlrauma.SaveChanges();

                return true;
            }
            catch (Exception)
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
                SP.TrangThai =0;
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
