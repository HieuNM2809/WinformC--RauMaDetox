using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
