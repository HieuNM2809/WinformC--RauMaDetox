using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public string id { get; set; }
        public string tensp { get; set; }
        public int soluong { get; set; }
        public DateTime ngaylap { get; set; }
        public float dongia { get; set; }
        public float tongtien { get; set; }
        public int trangthai { get; set; }
    }
}
