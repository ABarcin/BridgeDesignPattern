//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BridgeDesingPattern.Model.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class KurumsalKullanici
    {
        public int KurumsalKullaniciID { get; set; }
        public int KullaniciID { get; set; }
        public int FirmaID { get; set; }
        public Nullable<bool> OnayDurum { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Firma Firma { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
