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


        ql_raumaEntities qlrauma = new ql_raumaEntities();

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
        
        public bool ThemSP(DTO_sanpham sp)
        {
            int temp = qlrauma.THEMSP(sp.Masp, sp.Tensp, sp.MaLoaisp, sp.Giasp, sp.Mota, sp.Hinhsp);
            qlrauma.SaveChanges();
            return temp > 0;
        }
        public bool SuaSP(DTO_sanpham sp)
        {

            try
            {
                int temp = qlrauma.SUASP(sp.Masp, sp.Tensp, sp.MaLoaisp, sp.Giasp, sp.Mota, sp.Hinhsp);
                qlrauma.SaveChanges();
                return temp>0;
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
                int temp = qlrauma.XOASP(sp.Masp);
                qlrauma.SaveChanges();
                return temp > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }

}
