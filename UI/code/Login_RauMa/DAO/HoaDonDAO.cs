using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class HoaDonDAO
    {
        
        ql_raumaEntities qlrauma = new ql_raumaEntities();
        public List<HoaDonDTO> LayDSHD()
        {
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            lstHoaDon = qlrauma.HoaDons.Where(v => v.TrangThai == 1)
                .Select(u => new HoaDonDTO
                {
                    id = u.IDHoaDon,
                    idnhanvien = u.IDNV,
                    ngaylaphoadon = u.NgayLapHoaDon.Value
                }
                ).ToList();
            return lstHoaDon;
        }
        public bool ThemHoaDon(HoaDonDTO hd)
        {
            HoaDon hoadon = new HoaDon
            {
                IDHoaDon = hd.id,
                IDNV = hd.idnhanvien,
                NgayLapHoaDon = hd.ngaylaphoadon,
                TrangThai = 1
            };
            
            HoaDon hoadonEF = qlrauma.HoaDons.Add(hoadon);
            qlrauma.SaveChanges();
            return hoadonEF.IDHoaDon != null;
        }
    }
}
