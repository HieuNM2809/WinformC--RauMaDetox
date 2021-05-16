using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    class HoaDonDAO
    {
        
        ql_raumaEntities qlrauma = new ql_raumaEntities();
        public List<HoaDonDTO> LayDSHD()
        {
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            lstHoaDon = qlrauma.HoaDons.SqlQuery("")
            return lstHoaDon;
        }
    }
}
