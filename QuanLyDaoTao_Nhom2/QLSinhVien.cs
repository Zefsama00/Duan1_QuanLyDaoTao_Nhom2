//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDaoTao_Nhom2
{
    using System;
    using System.Collections.Generic;
    
    public partial class QLSinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QLSinhVien()
        {
            this.QLDiems = new HashSet<QLDiem>();
            this.QLNganhs = new HashSet<QLNganh>();
        }
    
        public string MaSV { get; set; }
        public string HoTenSV { get; set; }
        public string GioiTinhSV { get; set; }
        public Nullable<System.DateTime> NgaySinhSV { get; set; }
        public string DiaChiSV { get; set; }
        public string SoDienThoaiSV { get; set; }
        public string EmailSV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QLDiem> QLDiems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QLNganh> QLNganhs { get; set; }
    }
}
