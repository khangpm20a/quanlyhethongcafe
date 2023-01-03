using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class NhapKhoDTO
    {
        public string MaPhieu { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string MaNCC { get; set; }
        public string TenNL { get; set; }
        public string DonViTinh { get; set; }
        public decimal? DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal? ThanhTien { get; set; }

    }
}
