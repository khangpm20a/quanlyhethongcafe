using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhapKhoDAO
    {
        QLCFFEntities _qLCFFEntities = new QLCFFEntities();
        public List<NhapKhoDTO> DanhSachKho()
        {
            return _qLCFFEntities.NHAPKHOes.Select(u => new NhapKhoDTO
            {
                MaPhieu = u.MaPhieu,
                MaNV = u.MaNV,
                TenNV = u.TenNV,
                MaNCC = u.MaNCC,
                TenNL = u.TenNL,
                DonViTinh = u.DonViTinh,
                SoLuong = (int)u.SoLuong,
                DonGia = (u.DonGia),
                ThanhTien = (u.ThanhTien),


            }).ToList();


        }
        public bool NhapKho(NhapKhoDTO nhapKhoDTO)
        {
            try
            {
                NHAPKHO add = new NHAPKHO
                {
                    MaPhieu = nhapKhoDTO.MaPhieu,
                    TenNV = nhapKhoDTO.TenNV,
                    MaNV = nhapKhoDTO.MaNV,
                    MaNCC = nhapKhoDTO.MaNCC,
                    TenNL = nhapKhoDTO.TenNL,
                    DonViTinh = nhapKhoDTO.DonViTinh,
                    SoLuong = nhapKhoDTO.SoLuong,
                    DonGia = nhapKhoDTO.DonGia,
                    ThanhTien = nhapKhoDTO.ThanhTien
                };
                _qLCFFEntities.NHAPKHOes.Add(add);
                _qLCFFEntities.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }


        }

        public List<NhapKhoDTO> Report(string Maphieuu)
        {
            return _qLCFFEntities.NHAPKHOes.Where(u => u.MaPhieu == Maphieuu).Select(u => new NhapKhoDTO
            {
                MaPhieu = u.MaPhieu,
                MaNV = u.MaNV,
                TenNV = u.TenNV,
                MaNCC = u.MaNCC,
                TenNL = u.TenNL,
                DonViTinh = u.DonViTinh,
                SoLuong = (int)u.SoLuong,
                DonGia = (u.DonGia),
                ThanhTien = (u.ThanhTien),


            }).ToList();


        }
    }
}
