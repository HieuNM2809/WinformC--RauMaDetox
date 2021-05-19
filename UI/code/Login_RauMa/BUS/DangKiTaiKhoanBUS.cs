using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DangKiTaiKhoanBUS
    {
        private NhanVienDAO _NhanVienDAO = new NhanVienDAO();

        public bool DangKiTK(NhanVienDTO nv)
        {
            return _NhanVienDAO.DangKiTaiKhoan(nv);
        }

        public bool KiemTraTK(string TK)
        {
            return _NhanVienDAO.KiemTraTaiKhoan(TK);
        }

        public bool KiemTraMK(string MK)
        {
            return _NhanVienDAO.KiemTraMatKhau(MK);
        }
    }
}
