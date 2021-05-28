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
     
    }

    
}
