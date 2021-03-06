//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Imprumut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Imprumut()
        {
            this.Reviews = new HashSet<Review>();
        }
    
        public int ImprumutId { get; set; }
        public System.DateTime DataImprumut { get; set; }
        public System.DateTime DataScadenta { get; set; }
        public Nullable<System.DateTime> DataRestituire { get; set; }
        public int CarteId { get; set; }
        public int CititorId { get; set; }
    
        public virtual Carte Carte { get; set; }
        public virtual Cititor Cititor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
