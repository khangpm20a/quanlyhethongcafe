using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string Mota { get; set; }
        public string MaNCC { get; set; }
        public string DonViTinh { get; set; }
        public short SoLuong { get; set; }
        public int DonGia { get; set; }
        public bool? TrangThai { get; set; }
   
    }
}
