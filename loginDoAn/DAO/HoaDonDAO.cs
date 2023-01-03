using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class HoaDonDAO
    {
        QLCFFEntities doAnCFEntities = new QLCFFEntities();

        public List<HoaDonDTO> LayHoaDon()
        {
            return doAnCFEntities.HOADONs.Select(u => new HoaDonDTO
            {
                MaHD = u.MaHD,
                TenNV = u.TenNV,
                MaNV = u.MaNV,
           //     MaKH = (int)u.MaKH,
             //   NoiDung = u.NoiDung,
              //  ChiecKhau = (int)u.ChietKhau,
                ThanhTien = u.ThanhTien,
                TongTien = u.TongTien,
                NgayLapHD = (DateTime)u.NgayLapHD,
                TrangThai = u.TrangThai
            }).ToList();
        }
        public bool ThemHD(HoaDonDTO hoaDonDTO)
        {
            try
            {
                HOADON add = new HOADON
                {
                    MaHD = hoaDonDTO.MaHD,
                    TenNV = hoaDonDTO.TenNV,
                    MaNV = hoaDonDTO.MaNV,
               //     MaKH = hoaDonDTO.MaKH,
                 //   NoiDung = hoaDonDTO.NoiDung,
                  //  ChietKhau = (float)(hoaDonDTO.ChiecKhau),
                    ThanhTien = hoaDonDTO.ThanhTien,
                    TongTien = hoaDonDTO.TongTien,
                    NgayLapHD = hoaDonDTO.NgayLapHD,
                    TrangThai = true
                };
                doAnCFEntities.HOADONs.Add(add);
                doAnCFEntities.SaveChanges();
                return true;

            }catch
            {
                return false;
            }

        }


    }
}
