﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class HoaDonBUS
    {
        private HoaDonDAO hd = new HoaDonDAO();
        public List<HoaDonDTO> laydshd()
        {
            return hd.LayDSHD();
        }
        public bool themHD(HoaDonDTO hoadon)
        {
            return hd.themHD(hoadon);
        }
        public bool CapnhatHD(HoaDonDTO hoadon)
        {
            return hd.CapnhatHD(hoadon);
        }
        public bool them(string id, int tong, int so)
        {
            return hd.themtien(tong, so, id);
        }
    }
}
