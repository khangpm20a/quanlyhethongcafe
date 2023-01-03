using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using Guna.UI2.WinForms;

namespace BUS
{
    public class ThemHDBUS
    {
        public int ThemHD(string mahd, string macthd, string masp, string tensp,
            string soluong, string dongia)
        {
            return new ThemHDDAO().ThemHD(mahd, macthd, masp, tensp,
             soluong, dongia);
        }
        public void XemDSHD(System.Windows.Forms.DataGridView data, string id)
        {
            new ThemHDDAO().XemDSHD(data, id);
        }

        public DataTable ReportHD(string mahd)
        {
            return new ThemHDDAO().ReportHD(mahd);
        }

        public DataRow DonGia(string masp)
        {
            return new ThemHDDAO().DonGia(masp);
        }
        public int Sua(string macthd, string masp, string tensp,
            string soluong, string dongia)
        {
            return new ThemHDDAO().Sua(macthd, masp, tensp,
              soluong, dongia);
        }


    }
}
