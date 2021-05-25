using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_sanpham
    {

        private string masp;
        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        private string tensp;
        public string Tensp
        {
            get
            { return tensp; }
            set { tensp = value; }
        }
        private string maloaisp;
        public string MaLoaisp
        {
            get
            { return maloaisp; }
            set { maloaisp = value; }
        }
        private int giasp;
        public int Giasp
        {
            get
            { return giasp; }
            set { giasp = value; }
        }
        private string mota;
        public string Mota
        {
            get
            { return mota; }
            set { mota = value; }
        }
        private string hinhsp;
        public string Hinhsp
        {
            get
            { return hinhsp; }
            set { hinhsp = value; }
        }
        public DTO_sanpham()
        {

        }
        public DTO_sanpham(string masp, string tensp, string loaisp, int giasp, string mota,
            string hinhsp)
        {
            this.Masp = masp;
            this.Tensp = tensp;
            this.MaLoaisp = loaisp;
            this.Giasp = giasp;
            this.Mota = mota;
            this.Hinhsp = hinhsp;
        
        }
    }
}
