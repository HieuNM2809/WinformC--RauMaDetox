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
        

        ql_raumaEntities1 qlrauma = new ql_raumaEntities1();

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
                Email = u.Email

            }).ToList();

            return lsnhanvien;
        }

        public bool KiemTraNhanVien(string idnv)
        {
            

            int temp = qlrauma.NhanViens.Count(v => v.IDNV == idnv);
            qlrauma.SaveChanges();
            return temp > 0;

        }
        public bool ThemNV(NhanVienDTO nv)
        {
            int temp = qlrauma.THEMNV(nv.IDNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.ChucDanh, nv.LoaiNV, nv.SDT, nv.TaiKhoan, nv.MatKhau, nv.Email);
            qlrauma.SaveChanges();

            return temp>0;
        }

        public bool CapNhatNV(NhanVienDTO nv)
        {
          
            try
            {
               int temp= qlrauma.CAPNHATNV(nv.IDNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.ChucDanh, nv.LoaiNV, nv.SDT, nv.TaiKhoan, nv.MatKhau, nv.Email);
                qlrauma.SaveChanges();
                return temp>0;
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
                int temp = qlrauma.XOANV(nv.IDNV);
                qlrauma.SaveChanges();

                return temp > 0;
            }
            catch( Exception)
            {
                return false;
            }
        }

        public bool DoiMatKhau(NhanVienDTO nv)
        {
            try
            {
                NhanVien nhanVien = qlrauma.NhanViens.SingleOrDefault(u => u.TaiKhoan  == nv.TaiKhoan);
                nhanVien.MatKhau = nhanVien.MatKhau;
                qlrauma.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool KiemTraTaiKhoan(string tk)
        {
           int i = qlrauma.NhanViens.Count(v => v.TaiKhoan == tk);
            qlrauma.SaveChanges();
                return i >0;
        }

        public bool KiemTraMatKhau(string mk)
        {
            int i = qlrauma.NhanViens.Count(v => v.MatKhau == mk);
            qlrauma.SaveChanges();
            return i > 0;
        }

        public bool DangKiTaiKhoan(NhanVienDTO nv)
        {
            try
            {
                NhanVien nhanvien = new NhanVien();

                nhanvien.IDNV = nv.IDNV;
                nhanvien.TaiKhoan = nv.TaiKhoan;
                nhanvien.MatKhau = nv.MatKhau;
                nhanvien.TrangThai = 1;

                NhanVien nhanvienEF = qlrauma.NhanViens.Add(nhanvien);
                qlrauma.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}