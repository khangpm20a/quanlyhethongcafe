//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            this.DOANHTHUs = new HashSet<DOANHTHU>();
        }
    
        public int MaSP { get; set; }
        public Nullable<int> MaLoai { get; set; }
        public string TenSP { get; set; }
        public string Mota { get; set; }
        public string HinhSP { get; set; }
        public string MaNCC { get; set; }
        public string DonViTinh { get; set; }
        public Nullable<short> SoLuong { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOANHTHU> DOANHTHUs { get; set; }
        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}