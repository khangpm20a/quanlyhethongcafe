using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
   public class HoaDonBUS
    {
        HoaDonDAO _HoaDonDAO = new HoaDonDAO();
        public List<HoaDonDTO> LayHoaDon()
        {
            return _HoaDonDAO.LayHoaDon();
        }
        public bool ThemHoaDon(HoaDonDTO Them)
        {
            return _HoaDonDAO.ThemHD(Them);
        }
    }
}

