using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Microsoft.Reporting.WinForms;

namespace DashBoar
{
    public partial class frmXemBaoCao : Form
    {
        
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        NhanVienBUS nv = new NhanVienBUS();
        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {

            this.rptvXBC.RefreshReport();


        }

        public void XemDanhSachNhanVien()
        {
            List<NhanVienDTO> lsnv = new List<NhanVienDTO>();
            lsnv = nv.LayDSNhanVien();

            rptvXBC.LocalReport.ReportEmbeddedResource = "DashBoar.rptDSNV.rdlc";
            rptvXBC.LocalReport.DataSources.Add(new ReportDataSource("DSNV", lsnv));
            rptvXBC.RefreshReport();
        }

        public void XemDSNVTheoLoai(string lnv)
        {
            List<NhanVienDTO> lsnv = new List<NhanVienDTO>();
            lsnv = nv.LayDSNhanVienTheoLoai(lnv);

            rptvXBC.LocalReport.ReportEmbeddedResource = "DashBoar.rptDSNVTheoLoai.rdlc";
            rptvXBC.LocalReport.DataSources.Add(new ReportDataSource("DSNVTheoLoai", lsnv));
            rptvXBC.LocalReport.SetParameters(new ReportParameter("paLoaiNV", lnv));
            rptvXBC.RefreshReport();
        }

        //public void XemDSSVTheoNhomLop()
        //{
        //    List<LopDTO> l = new List<LopDTO>();
        //    l = _LBUS.LayDSLop();
        //    rptvXBC.LocalReport.ReportEmbeddedResource = "demoMoHinh3Lop.rptDSSVTheoNhomLop.rdlc";
        //    rptvXBC.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", l));
        //    rptvXBC.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
        //    rptvXBC.RefreshReport();
        //}


        public void XemDSNVTheoNhom()
        {
            List<NhanVienDTO> lsnv = new List<NhanVienDTO>();
            lsnv = nv.LayDSNhanVien();
            rptvXBC.LocalReport.ReportEmbeddedResource = "DashBoar.rptDSNVTheoNhom.rdlc";
            rptvXBC.LocalReport.DataSources.Add(new ReportDataSource("DSNVTheoNhom", lsnv));
            rptvXBC.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            rptvXBC.RefreshReport();
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            string lnv = e.Parameters["paLoaiNV"].Values[0].ToString();
            List<NhanVienDTO> lsnv = new List<NhanVienDTO>();
            lsnv = nv.LayDSNhanVienTheoLoai(lnv);
            e.DataSources.Add(new ReportDataSource("DSNVTheoNhom", lsnv));
        }
    }
}
