using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();
        public List<NhaCungCapDTO> DsNhaCC()
        {
            return nhaCungCapDAO.DsNhaCC();
        }
        public bool ThemNCC(NhaCungCapDTO nhaCungCapDTO)
        {
            return nhaCungCapDAO.ThemNCC(nhaCungCapDTO);
        }
        public bool SuaNCC(NhaCungCapDTO nhaCungCapDTO)
        {
            return nhaCungCapDAO.SuaNCC(nhaCungCapDTO);
        }
        public bool XoaNCC(NhaCungCapDTO nhaCungCapDTO)
        {
            return nhaCungCapDAO.XoaNCC(nhaCungCapDTO);
        }
    }
}
