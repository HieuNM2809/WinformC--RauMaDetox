﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO _NhanVienDAO = new NhanVienDAO();

        public List<NhanVienDTO> LayDSNhanVien()
        {
            return _NhanVienDAO.LayDSNhanVien();
        }

        public bool KiemTraNhanVien(string IDNV)
        {
            return _NhanVienDAO.KiemTraNhanVien(IDNV);
        }

        public bool ThemNV(NhanVienDTO nv)
        {
            return _NhanVienDAO.ThemNV(nv);
        }

        public bool CapNhatNV(NhanVienDTO nv)
        {
            return _NhanVienDAO.CapNhatNV(nv);
        }

        public bool XoaNV(NhanVienDTO nv)
        {
            return _NhanVienDAO.XoaNV(nv);
        }

        public bool KTDinhDangEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            return match.Success;
        }

        public string MAXID()
        {
            return _NhanVienDAO.MAXIDNV();
        }

        public NhanVienDTO KTDangNhap(string taikhoan, string matkhau)
        {
            return _NhanVienDAO.KTDangNhap(taikhoan, matkhau);
        }
        public List<NhanVienDTO> TimKiemIDNV(string idnv)
        {
            return _NhanVienDAO.TimKiemIDNV(idnv);
        }

        public List<NhanVienDTO> TimKiemHoTenNV(string hoten)
        {
            return _NhanVienDAO.TimKiemHoTenNV(hoten);
        }
        public bool KiemTraTK(string tk)
        {
            return _NhanVienDAO.KiemTraTaiKhoan(tk);
        }
    }
}

