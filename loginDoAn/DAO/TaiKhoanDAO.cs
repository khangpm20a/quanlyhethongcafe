using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        QLCFFEntities doAnCFEntities = new QLCFFEntities();

        public List<TaiKhoanDTO> LayDSNhanVien()
        {
            return doAnCFEntities.NHANVIENs.Where(u=>u.TrangThai ==true).Select(u => new TaiKhoanDTO
            {
                MaNV = u.MaNV,
                HoNV = u.HoNV,
                TenLotNV = u.TenLotNV,
                TenNV = u.TenNV,
                HinhNV = u.HinhNV,
                SDT = u.SDT,
                GioiTinh = u.GioiTinh,
                DiaChi = u.DiaChi,
                NgaySinh = (DateTime)u.NgaySinh,
                CaLam = u.CaLam,
                TrangThai = u.TrangThai
            }).ToList();
        }

        public bool ThemNV(TaiKhoanDTO _taiKhoanDTO)
        {
            try
            {
                NHANVIEN add = new NHANVIEN
                {

                    MaNV = _taiKhoanDTO.MaNV,
                    HoNV = _taiKhoanDTO.HoNV,
                    TenLotNV = _taiKhoanDTO.TenLotNV,
                    TenNV = _taiKhoanDTO.TenNV,
                    HinhNV = _taiKhoanDTO.HinhNV,
                    SDT = _taiKhoanDTO.SDT,
                    GioiTinh = _taiKhoanDTO.GioiTinh,
                    DiaChi = _taiKhoanDTO.DiaChi,
                    NgaySinh = (DateTime)_taiKhoanDTO.NgaySinh,
                    Email = _taiKhoanDTO.Email,
                    CaLam = _taiKhoanDTO.CaLam,
                    TrangThai = true
                };
                doAnCFEntities.NHANVIENs.Add(add);
                doAnCFEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool XoaNV(TaiKhoanDTO _taiKhoanDTO)
        {
            NHANVIEN pHANQUYEN = doAnCFEntities.NHANVIENs.SingleOrDefault(u => u.MaNV == _taiKhoanDTO.MaNV);
            try
            {

                NHANVIEN pHANQUYEN1 = doAnCFEntities.NHANVIENs.FirstOrDefault(u => u.MaNV == _taiKhoanDTO.MaNV);
                pHANQUYEN.TrangThai = false;

                doAnCFEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool SuaNV(TaiKhoanDTO _taiKhoanDTO)
        {
            NHANVIEN nHANVIEN = doAnCFEntities.NHANVIENs.SingleOrDefault(u => u.MaNV == _taiKhoanDTO.MaNV);
            if (nHANVIEN == null)
            {
                return false;
            }
            else
            {
                nHANVIEN.HoNV = _taiKhoanDTO.HoNV;
                nHANVIEN.TenLotNV = _taiKhoanDTO.TenLotNV;
                nHANVIEN.TenNV = _taiKhoanDTO.TenNV;
                nHANVIEN.SDT = _taiKhoanDTO.SDT;
                nHANVIEN.GioiTinh = _taiKhoanDTO.GioiTinh;
                nHANVIEN.DiaChi = _taiKhoanDTO.DiaChi;
                nHANVIEN.NgaySinh = _taiKhoanDTO.NgaySinh;
                nHANVIEN.CaLam = _taiKhoanDTO.CaLam;
            }
            doAnCFEntities.SaveChanges();
            return true;
        }

        public void LayNV(TaiKhoanDTO _taikhoanDTO, int manv)
        {
            NHANVIEN nHANVIEN = doAnCFEntities.NHANVIENs.FirstOrDefault(u => u.MaNV == manv.ToString());
            _taikhoanDTO.HoNV = nHANVIEN.HoNV;
            _taikhoanDTO.TenLotNV = nHANVIEN.TenLotNV;
            _taikhoanDTO.TenNV = nHANVIEN.TenNV;
            _taikhoanDTO.HinhNV = nHANVIEN.HinhNV;
            _taikhoanDTO.SDT = nHANVIEN.SDT;
            _taikhoanDTO.GioiTinh = nHANVIEN.GioiTinh;
            _taikhoanDTO.DiaChi = nHANVIEN.DiaChi;
            _taikhoanDTO.NgaySinh = (DateTime)nHANVIEN.NgaySinh;
            _taikhoanDTO.CaLam = nHANVIEN.CaLam;
        }
        public bool KTTK(string tentk)
        {
            PHANQUYEN tk = doAnCFEntities.PHANQUYENs.FirstOrDefault(u => u.TenTK == tentk);
            if (tk != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
