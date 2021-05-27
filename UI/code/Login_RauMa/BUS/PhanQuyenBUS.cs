using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    
    public class PhanQuyenBUS
    {
        private PhanQuyenDAO _pqDAO = new PhanQuyenDAO();

        public List<PhanQuyenDTO> LayDSPhanQuyen()
        {
            return _pqDAO.LayDSPhanQuyen();
        }
    }
}
