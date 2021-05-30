using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {

        ql_raumaEntities2 qlrauma = new ql_raumaEntities2();
        public string MAXIDNV()
        {
            return qlrauma.NhanViens.Max(v => v.IDNV);
        }

        public List<NhanVienDTO> LayDSNhanVien()
        {
            List<NhanVienDTO> lsnhanvien = new List<NhanVienDTO>();

            lsnhanvien = qlrauma.NhanViens.Where(v => v.TrangThai == 1).Select(u => new NhanVienDTO
            {
                IDNV = u.IDNV,
                HoTen = u.HoTen,
                NgaySinh = u.NgaySinh.Value,
                GioiTinh = u.GioiTinh,
                ChucDanh = u.ChucDanh,
                LoaiNV = u.LoaiNV,
                TaiKhoan = u.TaiKhoan,
                MatKhau = u.MatKhau,
                SDT = u.SDT,
                Email = u.Email,
                Hinh = u.Hinh

            }).ToList();

            return lsnhanvien;
        }

        #region CHỨC NĂNG
        public bool ThemNV(NhanVienDTO nv)
        {
            try
            {
                int temp = qlrauma.ThemNV(nv.IDNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.ChucDanh, nv.LoaiNV, nv.SDT,
                            nv.TaiKhoan, nv.MatKhau, nv.Hinh, nv.Email);
                qlrauma.SaveChanges();

                return temp > 0;
            }
            catch(Exception e)
            {
                return false;
            }
          
        }

        public bool CapNhatNV(NhanVienDTO nv)
        {
          
            try
            {
                int temp = qlrauma.CapNhatNV(nv.IDNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.ChucDanh, nv.LoaiNV, nv.SDT, nv.TaiKhoan, nv.MatKhau, nv.Email, nv.Hinh);
                qlrauma.SaveChanges();

                return temp > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaNV(NhanVienDTO nv)
        {
            try
            {
                int temp = qlrauma.XaoNV(nv.IDNV);
                qlrauma.SaveChanges();

                return temp > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DoiMatKhau(NhanVienDTO nv)
        {
            try
            {
                qlrauma.DOIMATKHAU(nv.TaiKhoan, nv.MatKhau);
                qlrauma.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool DangKiTaiKhoan(NhanVienDTO nv)
        {
            try
            {
               
                NhanVien nhanVien = new NhanVien();
                nhanVien.IDNV = nv.IDNV;
                nhanVien.HoTen = nv.HoTen;
                nhanVien.NgaySinh = nv.NgaySinh;
                nhanVien.GioiTinh = nv.GioiTinh;
                nhanVien.ChucDanh = nv.ChucDanh;
                nhanVien.LoaiNV = nv.LoaiNV;
                nhanVien.TaiKhoan = nv.TaiKhoan;
                nhanVien.MatKhau = nv.MatKhau;
                nhanVien.SDT = nv.SDT;
                nhanVien.Email = nv.Email;
                nhanVien.Hinh = nv.Hinh;
                nhanVien.TrangThai = 1;

               NhanVien nhanvienEF =  qlrauma.NhanViens.Add(nhanVien);
                qlrauma.SaveChanges();

                return int.Parse(nhanvienEF.IDNV) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region KIỂM TRA
        public bool KiemTraTaiKhoan(string tk)
        {
           int i = qlrauma.NhanViens.Count(v => v.TaiKhoan == tk);
         
                return i >0;
        }

        public bool KiemTraNhanVien(string idnv)
        {
            int temp = qlrauma.NhanViens.Count(v => v.IDNV == idnv);
     
            return temp > 0;

        }

        public bool KiemTraMatKhau(string mk)
        {
            string maKhoaMatKhau = mk.MaHoaMD5();
            int i = qlrauma.NhanViens.Count(v => v.MatKhau == maKhoaMatKhau);
            qlrauma.SaveChanges();
            return i > 0;
        }

        public NhanVienDTO KTDangNhap(string taikhoan, string matkhau)
        {
            string maHoaMatKhau = matkhau.MaHoaMD5();

            NhanVien nv = qlrauma.NhanViens.SingleOrDefault(u => u.TaiKhoan == taikhoan  && u.MatKhau == maHoaMatKhau);

            if (nv == null) return null;

            NhanVienDTO nhanvienDTO = new NhanVienDTO
            {
                IDNV = nv.IDNV,
                HoTen = nv.HoTen,
                NgaySinh = nv.NgaySinh.Value,
                GioiTinh = nv.GioiTinh,
                ChucDanh = nv.ChucDanh,
                LoaiNV = nv.LoaiNV,
                TaiKhoan = nv.TaiKhoan,
                MatKhau = nv.MatKhau,
                SDT = nv.SDT,
                Email = nv.Email,
                Hinh = nv.Hinh,
            };

            return nhanvienDTO;
        }
        #endregion
  
        #region TÌM KIẾM
        public List<NhanVienDTO> TimKiemIDNV(string idnv)
        {
            List<NhanVienDTO> lsnhanvien = new List<NhanVienDTO>();

            lsnhanvien = qlrauma.NhanViens.Where(v => v.IDNV.Contains(idnv) ).Select(u => new NhanVienDTO
            {
                IDNV = u.IDNV,
                HoTen = u.HoTen,
                NgaySinh = u.NgaySinh.Value,
                GioiTinh = u.GioiTinh,
                ChucDanh = u.ChucDanh,
                LoaiNV = u.LoaiNV,
                TaiKhoan = u.TaiKhoan,
                MatKhau = u.MatKhau,
                SDT = u.SDT,
                Email = u.Email,
                Hinh = u.Hinh

            }).ToList();

            return lsnhanvien;
        }

        public List<NhanVienDTO> TimKiemHoTenNV(string hoten)
        {
            List<NhanVienDTO> lsnhanvien = new List<NhanVienDTO>();

            lsnhanvien = qlrauma.NhanViens.Where(v => v.HoTen.Contains(hoten)).Select(u => new NhanVienDTO
            {
                IDNV = u.IDNV,
                HoTen = u.HoTen,
                NgaySinh = u.NgaySinh.Value,
                GioiTinh = u.GioiTinh,
                ChucDanh = u.ChucDanh,
                LoaiNV = u.LoaiNV,
                TaiKhoan = u.TaiKhoan,
                MatKhau = u.MatKhau,
                SDT = u.SDT,
                Email = u.Email,
                Hinh = u.Hinh

            }).ToList();

            return lsnhanvien;
        }
        #endregion

        public List<NhanVienDTO> LayDSNhanVienTheoLoai(string text)
        {
            List<NhanVienDTO> lsnhanvien = new List<NhanVienDTO>();

            lsnhanvien = qlrauma.NhanViens.Where(v => v.TrangThai == 1 && v.LoaiNV == text).Select(u => new NhanVienDTO
            {
                IDNV = u.IDNV,
                HoTen = u.HoTen,
                NgaySinh = u.NgaySinh.Value,
                GioiTinh = u.GioiTinh,
                ChucDanh = u.ChucDanh,
                LoaiNV = u.LoaiNV,
                TaiKhoan = u.TaiKhoan,
                MatKhau = u.MatKhau,
                SDT = u.SDT,
                Email = u.Email,
                Hinh = u.Hinh

            }).ToList();

            return lsnhanvien;
        }
    }
}