using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_loaisp
    {
        ql_raumaEntities1 qlrauma = new ql_raumaEntities1();
        public List<DTO_loaisp> LayDSloaisp()
        {
            List<DTO_loaisp> dsloaisp = new List<DTO_loaisp>();
            dsloaisp = qlrauma.LoaiSPs.Where(v => v.TrangThai==1).Select(u => new DTO_loaisp
            {
                Maloaisp = u.MaLoaiSp,
                Loaisp = u.LoaiSP1

            }).ToList();
            return dsloaisp;
        }
        public bool themloai(DTO_loaisp lsp)
        {
            LoaiSP LSP = new LoaiSP();
            LSP.MaLoaiSp = lsp.Maloaisp;
            LSP.LoaiSP1 = lsp.Loaisp;
            LSP.TrangThai = 1;
           LoaiSP lsanpham = qlrauma.LoaiSPs.Add(LSP) ;
            qlrauma.SaveChanges();
            return lsanpham.MaLoaiSp != "";
        }
        public bool sualoai(DTO_loaisp lsp)
        {

            try
            {
                LoaiSP loaisanpham = qlrauma.LoaiSPs.SingleOrDefault(u => u.MaLoaiSp == lsp.Maloaisp && u.TrangThai == 1);
                loaisanpham.LoaiSP1 = lsp.Loaisp;
                qlrauma.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaloai(DTO_loaisp lsp)
        {

            try
            {
                LoaiSP loaisanpham = qlrauma.LoaiSPs.SingleOrDefault(u => u.MaLoaiSp == lsp.Maloaisp && u.TrangThai == 1);
                loaisanpham.TrangThai = 0;
                qlrauma.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }


}
    

