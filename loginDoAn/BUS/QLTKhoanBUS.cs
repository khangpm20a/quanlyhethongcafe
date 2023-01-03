using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class QLTKhoanBUS
    {
        QLTKhoanDAO _qltkhoanDao = new QLTKhoanDAO();
        public DataRow TruyVan(string TK)
        {
            return new QLTKhoanDAO().TruyVan(TK);
        }
        public List<QLTKhoanDTO> LayTKDN()
        {
            return _qltkhoanDao.LayTKDN();
        }

        public List<QuyenDTO> LayQuyen()
        {
            return _qltkhoanDao.LayQuyen();
        }

        public bool DangNhap(string tk, string mk)
        {
            return _qltkhoanDao.DangNhap(tk, mk);
        }

        public bool ThemTK(QLTKhoanDTO qLTT_DTO)
        {
            return _qltkhoanDao.ThemTK(qLTT_DTO);
        }
        public bool XoaTK(QLTKhoanDTO qLTT_DTO)
        {
            return _qltkhoanDao.XoaTK(qLTT_DTO);
        }

    }
}
