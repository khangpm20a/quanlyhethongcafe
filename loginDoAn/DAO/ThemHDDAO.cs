using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAO
{
    public class ThemHDDAO
    {

        public int ThemHD(string mahd, string macthd, string masp, string tensp,
            string soluong, string dongia)
        {
            var tong = int.Parse(dongia) * int.Parse(soluong);

            List<PRS> prs = new List<PRS>();
            prs.Add(new PRS() { Key = "@MaHD", Value = mahd });
            prs.Add(new PRS() { Key = "@MaCTHD", Value = macthd });
            prs.Add(new PRS() { Key = "@MaSP", Value = masp });
            prs.Add(new PRS() { Key = "@TenSP", Value = tensp });
            prs.Add(new PRS() { Key = "@SoLuong", Value = soluong });
            prs.Add(new PRS() { Key = "@DonGia", Value = dongia });
            prs.Add(new PRS() { Key = "@ThanhTien", Value = tong.ToString() });
            return new DATACon().Execute("InsertCT_HD", prs);
        }
        public void XemDSHD(System.Windows.Forms.DataGridView data, string mahd)
        {
            List<PRS> prs = new List<PRS>();
            prs.Add(new PRS() { Key = "@Key", Value = mahd });
            // data.DataSource= new DATACon().selectData("SelectAllHD '"+mahd+"' ");
            data.DataSource = new DATACon().selectData("SelectAllHD", prs);
        }


        public DataTable ReportHD(string mahd)
        {
            List<PRS> prs = new List<PRS>();
            prs.Add(new PRS() { Key = "@MaHD", Value = mahd });
            return new DATACon().selectData("[ReportHD]",prs);
        }


        public DataRow DonGia(string masp)
        {
            return new DATACon().Select("SelectDonGia '" + masp + "'  ");
        }
        public int Sua(string macthd, string masp, string tensp,
            string soluong, string dongia)
        {
              
            int result = 0;
            int re = 0;
            if (int.TryParse(dongia, out result)) ;
            if (int.TryParse(soluong, out re)) ;
            var tong =( re  * result);
            List<PRS> prs = new List<PRS>();
            prs.Add(new PRS() { Key = "@MaCTHD", Value = macthd });
            prs.Add(new PRS() { Key = "@MaSP", Value = masp });
            prs.Add(new PRS() { Key = "@TenSP", Value = tensp });
            prs.Add(new PRS() { Key = "@SoLuong", Value = soluong });
            prs.Add(new PRS() { Key = "@DonGia", Value = dongia });
            prs.Add(new PRS() { Key = "@ThanhTien", Value = tong.ToString() });
            return new DATACon().Execute("UpdateCT_HD", prs);
        }

    }
}
