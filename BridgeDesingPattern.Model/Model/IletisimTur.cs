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
    
    public partial class IletisimTur
    {
        public IletisimTur()
        {
            this.CalisanIletisim = new HashSet<CalisanIletisim>();
            this.FirmaIletisim = new HashSet<FirmaIletisim>();
            this.KullaniciIletisim = new HashSet<KullaniciIletisim>();
        }
    
        public int IletisimTuruID { get; set; }
        public string Ad { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<CalisanIletisim> CalisanIletisim { get; set; }
        public virtual ICollection<FirmaIletisim> FirmaIletisim { get; set; }
        public virtual ICollection<KullaniciIletisim> KullaniciIletisim { get; set; }
    }
}
