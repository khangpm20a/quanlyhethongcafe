using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public int ID { get; set; }
        public string MaNV { get; set; }
        public string HoNV { get; set; }
        public string TenLotNV { get; set; }
        public string TenNV { get; set; }
        public string HinhNV { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string CaLam { get; set; }
        public bool? TrangThai { get; set; }
        

    }
}
