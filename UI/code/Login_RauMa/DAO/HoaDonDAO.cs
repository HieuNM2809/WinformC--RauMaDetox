using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HoaDonDAO
    {

        private ql_raumaEntities1 qlrauma = new ql_raumaEntities1();
        public List<HoaDonDTO> LayDSHD()
        {
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            lstHoaDon = qlrauma.HoaDons.Where(v => v.TrangThai == 1).
                Select(
                u => new HoaDonDTO
                {
                    id = u.IDHoaDon,
                    idnhanvien = u.IDNV,
                    ngaylaphoadon = u.NgayLapHoaDon.Value,
                    trangthai = 1
                }
                ).ToList();
            return lstHoaDon;
        }
        
        public bool CapnhatHD(HoaDonDTO hd)
        {
            /*nt temp = qlrauma.CAPNHATHD(hd.id, hd.idnhanvien, hd.ngaylaphoadon);*/
            qlrauma.SaveChanges();
            return true;
        }
        public bool XoaHD(HoaDonDTO hd)
        {
            //int temp = qlrauma.XOAHD(hd.id);
            qlrauma.SaveChanges();
            return true;
        }
    } 
}
