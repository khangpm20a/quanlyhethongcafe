using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class BangHangDAO
    {
        QLCFFEntities _qLCFFEntities = new QLCFFEntities();
        public List<BangHangDTO> LaySapPham()
        {
            return _qLCFFEntities.SANPHAMs.Where(u=> u.TrangThai == true).Select(u => new BangHangDTO
            {
                MaSP = (int)u.MaSP,
                TenSp = u.TenSP,
                SoLuong = (short)u.SoLuong,
                DonGia = u.DonGia.Value.ToString(),
                TrangThai = u.TrangThai
                //trangThai =u.TrangThai.Value ? "Ngưng sử dụng " : "Đang sử dụng"
            }).ToList();
        }

        //public bool ThemHoaDon(BangHangDTO bangHangDTO)
        //{
        //    try
        //    {
        //        HOADON add = new HOADON
        //        {
        //            MaHD = int.Parse(bangHangDTO.MaHD),
        //            MaNV= bangHangDTO.MaNV,
        //            NoiDung = bangHangDTO.NoiDung,
        //            ChietKhau =float.Parse(bangHangDTO.ChiecKhau),
        //            ThanhTien = double.Parse(bangHangDTO.ThanhTien),
        //            TongTien = double.Parse(bangHangDTO.TongTien)
        //        };
        //        _qLCFFEntities.HOADONs.Add(add);
        //        _qLCFFEntities.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }

        //}
    }
}
