using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PhanQuyenDAO
    {
        ql_raumaEntities2 qlrauma = new ql_raumaEntities2();
        public List<PhanQuyenDTO> LayDSPhanQuyen()
        {
            List<PhanQuyenDTO> lsphanquyen = new List<PhanQuyenDTO>();

            lsphanquyen = qlrauma.PhanQuyens.Select(u => new PhanQuyenDTO
            {
                IDQuyen = u.IDquyen,
                LoaiQuyen = u.LoaiQuyen

            }).ToList();

            return lsphanquyen;
        }
    }
}
