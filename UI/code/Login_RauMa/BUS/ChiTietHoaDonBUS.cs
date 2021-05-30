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
        public List<ChiTietHoaDonDTO> hienthi(string b)
        {
            return hd.HienThi(b);
        }
        public bool them(ChiTietHoaDonDTO hoadon)
        {
            return hd.Themcthd(hoadon);
        }
        public int max()
        {
            return Convert.ToInt32(hd.MAX());
        }
        public string laymasp(string a)
        {
            return hd.masp(a);
        }
        public bool loadlai(string a,string b)
        {
            return hd.xoact(a, b);
            
        }
    }
}
