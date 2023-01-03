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
    public partial class inDoanhThu : Form
    {


        public string Tennvvvv;
        public inDoanhThu(string TenNV)
        {
            InitializeComponent();
            Tennvvvv = TenNV;
        }

        private void inDoanhThu_Load(object sender, EventArgs e)
        {

            try
            {
                rptDoanhThu.LocalReport.ReportEmbeddedResource = "loginDoAn.ReportDoanhThu.rdlc";
                this.rptDoanhThu.LocalReport.DataSources.Add(new ReportDataSource("reportDoanhThu", new HoaDonBUS().LayHoaDon()));
                Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    //new Microsoft.Reporting.WinForms.ReportParameter("paMaHD",mahd),
                    //new Microsoft.Reporting.WinForms.ReportParameter("paNgayTao",ngaytao),
                    new Microsoft.Reporting.WinForms.ReportParameter("paNguoiLap",Tennvvvv)


                };
                rptDoanhThu.LocalReport.SetParameters(reports);
                this.rptDoanhThu.RefreshReport();
            }
            catch
            {
                return;
            }
        }
    }
}
