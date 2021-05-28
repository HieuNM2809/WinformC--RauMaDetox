using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool KiemTraID(string IDNV)
        {
            return _NhanVienDAO.KiemTraNhanVien(IDNV);
        }

        public bool CapNhatNV(NhanVienDTO nv)
        {
            return _NhanVienDAO.CapNhatNV(nv);
        }

        public string MAXID()
        {
            return _NhanVienDAO.MAXIDNV();
        }

        public bool KTDinhDangEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            return match.Success;
        }
    }
}
