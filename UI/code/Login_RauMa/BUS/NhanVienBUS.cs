using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO _NhanVienDAO = new NhanVienDAO();

        public List<NhanVienDAO> LayDSSNhanVien()
        {
            return _NhanVienDAO.LayDSNhanVien();
        }
    }
}
