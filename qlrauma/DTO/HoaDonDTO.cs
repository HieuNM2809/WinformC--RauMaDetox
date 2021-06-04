using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class HoaDonDTO
    {
        public string id { get; set; }
        public string idnhanvien { get; set; }
        public DateTime ngaylaphoadon { get; set; }
        public byte trangthai { get; set; }
        public Nullable<decimal> Tongtien { get; set; }
        public Nullable<int> Tongso { get; set; }
    }
}
