using System;
using DTO;
using DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAO hd = new HoaDonDAO();
        public List<HoaDonDTO> laydshd()
        {
            return hd.LayDSHD();
        }
        public bool ThemHoaDon(HoaDonDTO hoadon)
        {
            return true;
        }
    }
}
