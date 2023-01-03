using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAO
{
    public   class SanPhamDAO
    {
        QLCFFEntities _qLCFFEntities1 = new QLCFFEntities();
        public List<SanPhamDTO> LaySanPham()
        {
            return _qLCFFEntities1.SANPHAMs.Where(u=> u.TrangThai == true).Select(u => new SanPhamDTO
            {
                MaSP = (int)u.MaSP,
                TenSP = u.TenSP,
                Mota = u.Mota,
                MaNCC = u.MaNCC,
                DonViTinh = u.DonViTinh,
                SoLuong = (short)u.SoLuong,
                DonGia = u.DonGia.Value,
                TrangThai = u.TrangThai
            }).ToList();
        }
        public bool XoaSanPham(SanPhamDTO sanPhamDTO)
        {

            SANPHAM sANPHAM = _qLCFFEntities1.SANPHAMs.SingleOrDefault(u => u.MaSP == sanPhamDTO.MaSP);
            try
            {

                SANPHAM sANPHAM1 = _qLCFFEntities1.SANPHAMs.FirstOrDefault(u => u.MaSP == sanPhamDTO.MaSP);
                sANPHAM.TrangThai = false;

                _qLCFFEntities1.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool ThemSanPham(SanPhamDTO sanPhamDTO)
        {
            try
            {
                SANPHAM add = new SANPHAM
                {
                    MaSP = sanPhamDTO.MaSP,
                    TenSP = sanPhamDTO.TenSP,
                    MaNCC = sanPhamDTO.MaNCC,
                    DonViTinh = sanPhamDTO.DonViTinh,
                    SoLuong = sanPhamDTO.SoLuong,
                    DonGia = sanPhamDTO.DonGia,
                    TrangThai = true
                };
                _qLCFFEntities1.SANPHAMs.Add(add);
                _qLCFFEntities1.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaSP(SanPhamDTO sanphamDTO)
        {
            SANPHAM sANPHAM = _qLCFFEntities1.SANPHAMs.SingleOrDefault(u => u.MaSP == sanphamDTO.MaSP);
            if (sANPHAM == null) return false;
            else
            {
                sANPHAM.MaSP = sanphamDTO.MaSP;
                sANPHAM.TenSP = sanphamDTO.TenSP;
                sANPHAM.Mota = sanphamDTO.Mota;
                sANPHAM.MaNCC = sanphamDTO.MaNCC;
                sANPHAM.DonViTinh = sanphamDTO.DonViTinh;
                sANPHAM.SoLuong = sanphamDTO.SoLuong;
                sANPHAM.DonGia = sanphamDTO.DonGia;
            }
            _qLCFFEntities1.SaveChanges();
            return true;
        }
    }
}
