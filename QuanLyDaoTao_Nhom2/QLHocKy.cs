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
    
    public partial class QLHocKy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QLHocKy()
        {
            this.QLLiches = new HashSet<QLLich>();
            this.QLLopMons = new HashSet<QLLopMon>();
        }
    
        public string MaHocKy { get; set; }
        public string TenHocKy { get; set; }
        public System.DateTime NgayBatDau { get; set; }
        public System.DateTime NgayKetThuc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QLLich> QLLiches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QLLopMon> QLLopMons { get; set; }
    }
}
