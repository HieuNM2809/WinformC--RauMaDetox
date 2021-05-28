using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DoiMatKhauBUS
    {
        private NhanVienDAO _nhanVienDAO = new NhanVienDAO();

        public bool DoiMatKhau(NhanVienDTO dmk)
        {
            return _nhanVienDAO.DoiMatKhau(dmk);
        }

        public bool KiemTraTK(string TK)
        {
            return _nhanVienDAO.KiemTraTaiKhoan(TK);
        }

        public bool KiemTraMK(string MK)
        {
            return _nhanVienDAO.KiemTraMatKhau(MK);
        }
    }
}
