using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_loaisp
    {
        ql_raumaEntities2 qlrauma = new ql_raumaEntities2();
        public List<DTO_loaisp> LayDSloaisp()
        {
            List<DTO_loaisp> dsloaisp = new List<DTO_loaisp>();
            dsloaisp = qlrauma.LoaiSPs.Where(v => v.TrangThai==1).Select(u => new DTO_loaisp
            {
                Maloaisp = u.MaLoaiSp,
                Loaisp = u.LoaiSP1

            }).ToList();
            return dsloaisp;
        }
    }


}
    

