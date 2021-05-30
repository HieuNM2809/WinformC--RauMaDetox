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


        ql_raumaEntities2 qlrauma = new ql_raumaEntities2();

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
                Hinhsp=u.Hinh
            }).ToList();
            return lssanpham;
        }
        
        public List<DTO_sanpham> lstViewSP()
        {
            List<DTO_sanpham> lssanpham = new List<DTO_sanpham>();
            lssanpham = qlrauma.SanPhams.Where(v => v.TrangThai == 1).Select(u => new DTO_sanpham
            {
                Masp = u.MaSp,
                Tensp = u.TenSp,
                MaLoaisp = u.MaLoaiSp,
                Giasp = (int)u.GiaTien,
                Mota = u.MoTa,
                Hinhsp = u.Hinh
            }).ToList();
            return lssanpham;
        }

        public bool ThemSP(DTO_sanpham sp)
        {
            int temp = qlrauma.THEMSP(sp.Masp, sp.Tensp, sp.MaLoaisp, sp.Giasp, sp.Mota, sp.Hinhsp);
            qlrauma.SaveChanges();
            return true;
        }
        public bool SuaSP(DTO_sanpham sp)
        {

            try
            {
                int temp = qlrauma.SUASP(sp.Masp, sp.Tensp, sp.MaLoaisp, sp.Giasp, sp.Mota, sp.Hinhsp);
                qlrauma.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string max()
        {
            string a = "RM01";
            return a;
        }
        public bool xoaSP(DTO_sanpham sp)
        {
            try
            {
                int temp = qlrauma.XOASP(sp.Masp);
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
