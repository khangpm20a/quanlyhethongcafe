using Microsoft.Reporting.WinForms;
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

namespace loginDoAn
{
    public partial class inSanPham : Form
    {
        public string Tennvvvv;
        public inSanPham(string TenNV)
        {
            InitializeComponent();
            Tennvvvv = TenNV;
        }

        private void inSanPham_Load(object sender, EventArgs e)
        {

            try
            {
                rptSanPham.LocalReport.ReportEmbeddedResource = "loginDoAn.ReportSanPham.rdlc";
                this.rptSanPham.LocalReport.DataSources.Add(new ReportDataSource("DataSanPham", new SanPhamBUS().LaySanPham()));
                Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    //new Microsoft.Reporting.WinForms.ReportParameter("paMaHD",mahd),
                    //new Microsoft.Reporting.WinForms.ReportParameter("paNgayTao",ngaytao),
                    new Microsoft.Reporting.WinForms.ReportParameter("paNguoiLap",Tennvvvv)


                };
                rptSanPham.LocalReport.SetParameters(reports);
                this.rptSanPham.RefreshReport();
            }
            catch
            {
                return;
            }
        }

        private void rptSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
