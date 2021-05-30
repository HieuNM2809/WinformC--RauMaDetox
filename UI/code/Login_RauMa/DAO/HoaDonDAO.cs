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

        private ql_raumaEntities2 qlrauma = new ql_raumaEntities2();
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
        public bool themHD(HoaDonDTO hd)
        {
            int temp = qlrauma.THEMHD(hd.id, hd.idnhanvien, hd.ngaylaphoadon);
            qlrauma.SaveChanges();
            return true;
        }
        public bool themtien(int tongtien,int soluong,string id)
        {
            int temp = qlrauma.nhapct(id, tongtien, soluong);
            qlrauma.SaveChanges();
            return true;
        }
        public bool CapnhatHD(HoaDonDTO hd)
        {
            //int temp = qlrauma.CAPNHATHD(hd.id, hd.idnhanvien, hd.ngaylaphoadon);
            qlrauma.SaveChanges();
            return true;
        }
        public bool XoaHD(string id)
        {
            int temp = qlrauma.XOAHD(id);
            qlrauma.SaveChanges();
            return true;
        }
    } 
}
