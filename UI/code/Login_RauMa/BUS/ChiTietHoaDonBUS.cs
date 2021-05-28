using System;
using DTO;
using DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO chitietHD = new ChiTietHoaDonDAO();
        public List<ChiTietHoaDonDTO> layDSSP()
        {
            return chitietHD.layDSSP();
        }
        public List<ChiTietHoaDonDTO> lstViewSP(string masanpham)
        {
            return chitietHD.LayGia(masanpham);
        }
       
    }
}
