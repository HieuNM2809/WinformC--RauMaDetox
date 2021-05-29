using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        ql_raumaEntities2 qlrauma = new ql_raumaEntities2();
        int i;
        public List<ChiTietHoaDonDTO> layDSSP()
        {
            List<ChiTietHoaDonDTO> lssanpham = new List<ChiTietHoaDonDTO>();
            lssanpham = qlrauma.SanPhams.Where(v => v.TrangThai == 1).Select(u => new ChiTietHoaDonDTO
            {
                MaSp = u.MaSp,
                TenSp = u.TenSp,
            }).ToList();
            return lssanpham;
        }
        public List<ChiTietHoaDonDTO> HienThi()
        {
            List<ChiTietHoaDonDTO> lssanpham = new List<ChiTietHoaDonDTO>();
                lssanpham = qlrauma.CTHoaDons.Select(u => new ChiTietHoaDonDTO
                {
                    STT=u.STT,
                    IDHoaDon=u.HoaDon.IDHoaDon,
                    MaSp = u.MaSp,
                    TenSp = u.SanPham.TenSp,
                    SoLuong=(int)u.SoLuong,
                    DonGia= (int)u.SanPham.GiaTien,
                    TongTien= (int)u.TongTien
                }).ToList();
            return lssanpham;
        }
        public List<ChiTietHoaDonDTO> LayGia(string masanpham)
        {
            List<ChiTietHoaDonDTO> lssanpham = new List<ChiTietHoaDonDTO>();
            lssanpham = qlrauma.SanPhams.Where(v => v.MaSp == masanpham).Select(u => new ChiTietHoaDonDTO
            {
                DonGia=(int)u.GiaTien

            }).ToList();
            qlrauma.SaveChanges();
            return lssanpham;
        }
        public string MAX()
        {
            string a = "0";
            a = qlrauma.HoaDons.Max(c => c.IDHoaDon);
            return a;
        }

        public bool HienthiCTHoaDon (ChiTietHoaDonDTO cthd)
        {
            qlrauma.THEMCTHD(cthd.STT,cthd.IDHoaDon,cthd.MaSp,cthd.SoLuong, cthd.DonGia,cthd.TongTien);
            qlrauma.SaveChanges();
            return true;
            
        }
    }
}
