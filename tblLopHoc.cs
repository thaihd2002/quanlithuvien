//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySinhVienCshape
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblLopHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLopHoc()
        {
            this.tblSinhVien = new HashSet<tblSinhVien>();
        }
    
        public Nullable<System.DateTime> ngaytao { get; set; }
        public string nguoitao { get; set; }
        public Nullable<System.DateTime> ngaycapnhat { get; set; }
        public string nguoicapnhat { get; set; }
        public string malophoc { get; set; }
        public string tenlophoc { get; set; }
        public string khoahoc { get; set; }
        public string hedaotao { get; set; }
        public Nullable<int> namnhaphoc { get; set; }
        public string makhoa { get; set; }
        public string magiaovien { get; set; }
    
        public virtual tblGiaoVien tblGiaoVien { get; set; }
        public virtual tblKhoa tblKhoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSinhVien> tblSinhVien { get; set; }
    }
}
