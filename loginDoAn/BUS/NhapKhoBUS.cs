using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BUS
{
    public class NhapKhoBUS
    {
        NhapKhoDAO _NhapKhoDAO = new NhapKhoDAO();
        public List<NhapKhoDTO> DanhSachKho() => _NhapKhoDAO.DanhSachKho();
        public bool NhapKho(NhapKhoDTO Them)
        {
            return _NhapKhoDAO.NhapKho(Them);
        }

        public List<NhapKhoDTO> Reportt(string MaPhieu) => _NhapKhoDAO.Report(MaPhieu);

    }
}
