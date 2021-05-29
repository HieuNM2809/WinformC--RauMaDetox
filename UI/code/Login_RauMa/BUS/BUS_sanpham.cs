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

        public List<DTO_sanpham> LayDSsanpham(string a)
        {

            return _dssp.LayDSSanpham(a);
        }
        
        public List<DTO_sanpham> lstViewSP()
        {

            return _dssp.lstViewSP();
        }

        public bool ThemSP(DTO_sanpham sp)
        {
            return _dssp.ThemSP(sp);
        }
        public bool SuaSP(DTO_sanpham sp)
        {
            return _dssp.SuaSP(sp);
        }
        public bool xoaSP(DTO_sanpham sp)
        {
            return _dssp.xoaSP(sp);
        }
       public int max()
        {
            string[] maSP = _dssp.max().Split('0');
            return Convert.ToInt32(maSP[1]);
        }
    }
}
