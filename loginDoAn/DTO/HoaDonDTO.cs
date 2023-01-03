using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public string TenNV { get; set; }
        public string TenKH { get; set; }
        public string MaNV { get; set; }
        public int MaKH { get; set; }
        public string NoiDung { get; set; }
        public int ChiecKhau { get; set; }
        public Decimal? ThanhTien { get; set; }
        public Decimal? TongTien { get; set; }
        public DateTime NgayLapHD { get; set; }
        public bool? TrangThai { get; set; }
    }
}
