using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BangHangBUS
    {
        BangHangDAO _bangHangDAO = new BangHangDAO();
        public List<BangHangDTO> LaySapPham()
        {
            return _bangHangDAO.LaySapPham();
        }
        //public bool ThemHoaDon(BangHangDTO Them)
        //{
        //    return _bangHangDAO.ThemHoaDon(Them);
        //}
    }
}
