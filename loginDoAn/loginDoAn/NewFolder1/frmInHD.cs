using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Microsoft.Reporting.WinForms;

namespace loginDoAn.NewFolder1
{
    public partial class frmInHD : Form
    {
        public string mahd;
        public string ngaytao;
        public string tennv;
        public frmInHD(string MaHD,string NgayTao,string Tennv)
        {
            InitializeComponent();
            mahd = MaHD;
            ngaytao = NgayTao;
            tennv = Tennv;
        }

        private void frmInHD_Load(object sender, EventArgs e)
        {
            try
            {
                repHD.LocalReport.ReportEmbeddedResource = "loginDoAn.ReportHoaDon.rdlc";
                this.repHD.LocalReport.DataSources.Add(new ReportDataSource ("DataHD", new ThemHDBUS().ReportHD(mahd)));
                Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("paMaHD",mahd),
                    new Microsoft.Reporting.WinForms.ReportParameter("paNgayTao",ngaytao),
                    new Microsoft.Reporting.WinForms.ReportParameter("paTenNV",tennv)


                };
                repHD.LocalReport.SetParameters(reports);
                this.repHD.RefreshReport();
            }
            catch
            {
                return;
            }
        }
    }
}
