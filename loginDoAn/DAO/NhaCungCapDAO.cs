using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public  class NhaCungCapDAO
    {
        QLCFFEntities _qLCFFEntities = new QLCFFEntities();
        public List<NhaCungCapDTO> DsNhaCC()
        {
            return _qLCFFEntities.NHACUNGCAPs.Select(u => new NhaCungCapDTO
            {
                MaNCC = u.MaNCC,
                TenNCC = u.TenNCC,
                SDT = u.SDT,
                DiaChi = u.DiaChi,

            }).ToList();
        }

        public bool ThemNCC(NhaCungCapDTO nhaCungCapDTO)
        {
            try
            {
                NHACUNGCAP add = new NHACUNGCAP
                {
                    MaNCC = nhaCungCapDTO.MaNCC,
                    TenNCC = nhaCungCapDTO.TenNCC,
                    SDT = nhaCungCapDTO.SDT,
                    DiaChi = nhaCungCapDTO.DiaChi,
                };
                _qLCFFEntities.NHACUNGCAPs.Add(add);
                _qLCFFEntities.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaNCC(NhaCungCapDTO nhaCungCapDTO)
        {
            NHACUNGCAP nHACUNGCAP = _qLCFFEntities.NHACUNGCAPs.SingleOrDefault(u => u.MaNCC == nhaCungCapDTO.MaNCC);
            if (nHACUNGCAP == null)
            {
                return false;
            }
            else
            {
                nHACUNGCAP.MaNCC = nhaCungCapDTO.MaNCC;
                nHACUNGCAP.TenNCC = nhaCungCapDTO.TenNCC;
                nHACUNGCAP.SDT = nhaCungCapDTO.SDT;
                nHACUNGCAP.DiaChi = nhaCungCapDTO.DiaChi;
            }
            _qLCFFEntities.SaveChanges();
            return true;
        }
        public bool XoaNCC(NhaCungCapDTO nhaCungCapDTO)
        {

            SANPHAM sANPHAM = _qLCFFEntities.SANPHAMs.SingleOrDefault(u => u.MaNCC == nhaCungCapDTO.MaNCC);
            try
            {

                SANPHAM sANPHAM1 = _qLCFFEntities.SANPHAMs.FirstOrDefault(u => u.MaNCC == nhaCungCapDTO.MaNCC);
                sANPHAM.TrangThai = false;

                _qLCFFEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

    }
}
