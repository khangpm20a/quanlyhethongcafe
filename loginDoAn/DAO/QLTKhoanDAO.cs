using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class QLTKhoanDAO
    {
        QLCFFEntities _qLCFFEntities = new QLCFFEntities();
        public DataRow TruyVan(string TK)
        {
            return new DATACon().Select("truyvan '" + TK + "'  ");
        }
        public List<QLTKhoanDTO> LayTKDN()
        {
            return _qLCFFEntities.PHANQUYENs.Where(u => u.TrangThai == true).Select(u => new QLTKhoanDTO
            {
                MaNV = u.MaNV,
                TenTK = u.TenTK,
                MatKhau = u.MatKhau,
                MaQuyen = (int)u.MaQuyen,
                TrangThai = u.TrangThai
                //trangThai =u.TrangThai.Value ? "Ngưng sử dụng " : "Đang sử dụng"
            }).ToList();
        }

        public List<QuyenDTO> LayQuyen()
        {
            return _qLCFFEntities.QUYENs.Select(u => new QuyenDTO
            {
                MaQuyen = u.MaQuyen.ToString(),
                TenQuyen = u.TenQuyen
            }).ToList();
        }

        public bool DangNhap(string tk, string mk)
        {


            try
            {
                PHANQUYEN _pq = _qLCFFEntities.PHANQUYENs.FirstOrDefault(u => u.TenTK == tk);
            if (_pq.TenTK == tk && _pq.MatKhau == mk)
            {
                return true;
            }
            else
                return false;
        }
            catch (Exception ex)
            {
                return false;
            }

}
        public bool ThemTK(QLTKhoanDTO qLTT_DTO)
        {
            try
            {
                PHANQUYEN add = new PHANQUYEN
                {
                    MaNV = qLTT_DTO.MaNV,
                    TenTK = qLTT_DTO.TenTK,
                    MatKhau = qLTT_DTO.MatKhau,
                    MaQuyen = int.Parse(qLTT_DTO.MaQuyen.ToString()),
                    TrangThai = true
                };
                _qLCFFEntities.PHANQUYENs.Add(add);
                _qLCFFEntities.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool XoaTK(QLTKhoanDTO qLTT_DTO)
        {
            PHANQUYEN pHANQUYEN = _qLCFFEntities.PHANQUYENs.SingleOrDefault(u => u.MaNV == qLTT_DTO.MaNV);
            try
            {

                PHANQUYEN pHANQUYEN1 = _qLCFFEntities.PHANQUYENs.FirstOrDefault(u => u.MaNV == qLTT_DTO.MaNV);
                pHANQUYEN.TrangThai = false;

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
