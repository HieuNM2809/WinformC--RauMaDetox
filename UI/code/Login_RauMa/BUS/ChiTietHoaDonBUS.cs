using System;
using DAO;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        int i;
        ChiTietHoaDonDAO hd = new ChiTietHoaDonDAO();
        ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();
        public List<ChiTietHoaDonDTO> LayDSSP()
        {
            return hd.layDSSP();
        }
        public List<ChiTietHoaDonDTO> LayGia(string masp)
        {
            return hd.LayGia(masp);
        }
        public List<ChiTietHoaDonDTO> hienthi()
        {
            return hd.HienThi();
        }
        public bool hienthicthd(ChiTietHoaDonDTO hoadon)
        {
            return hd.HienthiCTHoaDon(hoadon);
        }
        public int max()
        {
            return Convert.ToInt32(hd.MAX());
        }
    }
}
