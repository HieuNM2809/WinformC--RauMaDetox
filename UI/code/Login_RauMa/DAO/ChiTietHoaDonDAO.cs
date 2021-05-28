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

        public List<ChiTietHoaDonDTO> LayGia(string masanpham)
        {
            List<ChiTietHoaDonDTO> lssanpham = new List<ChiTietHoaDonDTO>();
            lssanpham = qlrauma.CTHoaDons.Where(v => v.MaSp == masanpham).Select(u => new ChiTietHoaDonDTO
            {
                IDHoaDon = u.HoaDon.IDHoaDon,
                STT = u.STT,
                DonGia = (decimal)u.SanPham.GiaTien,

            }).ToList();
            qlrauma.SaveChanges();
            return lssanpham;
        }
    }
}
