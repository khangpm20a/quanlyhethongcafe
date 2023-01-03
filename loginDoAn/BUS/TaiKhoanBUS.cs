using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        public List<TaiKhoanDTO> LayDSNhanVien()
        {
            return taiKhoanDAO.LayDSNhanVien();
        }
        public bool ThemNV(TaiKhoanDTO taiKhoanDTO)
        {
            return taiKhoanDAO.ThemNV(taiKhoanDTO);
        }
        public bool SuaNV(TaiKhoanDTO taiKhoanDTO)
        {
            return taiKhoanDAO.SuaNV(taiKhoanDTO);
        }
        public bool XoaNV(TaiKhoanDTO taiKhoanDTO)
        {
            return taiKhoanDAO.XoaNV(taiKhoanDTO);
        }
        //public bool KTTenKH(string tentk)
        //{
            
        //}

        public void LayNV(TaiKhoanDTO _taikhoanDTO, int manv) => taiKhoanDAO.LayNV(_taikhoanDTO, manv);


    }
}
