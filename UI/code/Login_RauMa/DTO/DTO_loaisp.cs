using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_loaisp
    {
        private string maloaisp;
        public string Maloaisp
        {
            get
            { return maloaisp; }
            set { maloaisp = value; }
        }
        private string loaisp;
        public string Loaisp
        {
            get
            { return loaisp; }
            set { loaisp = value; }
        } 
        public DTO_loaisp()
        {
        }
        public DTO_loaisp (string maloaisp,string loaisp)
        {
            this.Maloaisp = maloaisp;
            this.Loaisp = loaisp;
            
        }
    }
}
