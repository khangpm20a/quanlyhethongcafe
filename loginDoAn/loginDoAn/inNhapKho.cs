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
    public partial class inNhapKho : Form
    {
        public string Tennvvvv, Maphieeuu;
        public inNhapKho(string TenNV ,string MaPhieu)
        {
            InitializeComponent();
            Tennvvvv = TenNV;
            Maphieeuu = MaPhieu;
        }

        private void inNhapKho_Load(object sender, EventArgs e)
        {
            try
            {
                rptNhapKho.LocalReport.ReportEmbeddedResource = "loginDoAn.ReportPhieuNhapKho.rdlc";
                this.rptNhapKho.LocalReport.DataSources.Add(new ReportDataSource("DataNhapKho", new NhapKhoBUS().Reportt(Maphieeuu)));
                Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    //new Microsoft.Reporting.WinForms.ReportParameter("paMaHD",mahd),
                    new Microsoft.Reporting.WinForms.ReportParameter("paMaPhieu",Maphieeuu),
                    new Microsoft.Reporting.WinForms.ReportParameter("paNguoiLap",Tennvvvv)


                };
                rptNhapKho.LocalReport.SetParameters(reports);
                this.rptNhapKho.RefreshReport();
            }
            catch
            {
                return;
            }
        }
    }
}
