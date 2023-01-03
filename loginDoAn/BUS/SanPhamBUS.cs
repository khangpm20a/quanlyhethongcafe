using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BUS
{
   public class SanPhamBUS
    {
        SanPhamDAO _SanPhamDAO = new SanPhamDAO();
        public List<SanPhamDTO> LaySanPham()
        {
            return _SanPhamDAO.LaySanPham();
        }
        public bool XoaSanPham(SanPhamDTO sanPhamDTO)
        {
            return _SanPhamDAO.XoaSanPham(sanPhamDTO);
        }
        public bool ThemSanPham(SanPhamDTO sanPhamDTO)
        {
            return _SanPhamDAO.ThemSanPham(sanPhamDTO);
        }
        public bool SuaSP(SanPhamDTO sanPhamDTO)
        {
            return _SanPhamDAO.SuaSP(sanPhamDTO);
        }
    }
}
