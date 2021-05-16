using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_sanpham
    {
        private DAO_sanpham  _dssp= new DAO_sanpham();

        public List<DTO_sanpham> LayDSsanpham()
        {

            return _dssp.LayDSSanpham();
        }
        //    public List<DTO_sanpham> laytheoloai(string a)
        //    {
        //        return _dssp.laytheoloai(a);
        //    }
        //    public bool KiemTraMaSP(string masp)
        //    {
        //        return _dssp.KiemTraMaSP(masp);
        //    }
        //    public bool ThemSP(DTO_sanpham sp)
        //    {
        //        return _dssp.ThemSP(sp);
        //    }
    }
}
