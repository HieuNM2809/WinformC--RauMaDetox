using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_loaisp
    {
        private DAO_loaisp _dsloaisp = new DAO_loaisp();
            public List<DTO_loaisp> LayDSloaisp()
        {

            return _dsloaisp.LayDSloaisp();
        }
        public bool ThemLSP(DTO_loaisp lsp)
        {
            return _dsloaisp.themloai(lsp);
        }
     public bool SuaLSP(DTO_loaisp lsp)
        {
            return _dsloaisp.sualoai(lsp);
        }
        public bool xoaLSP(DTO_loaisp lsp)
        {
            return _dsloaisp.xoaloai(lsp);
        }
    }

    
}
