//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PavileniDB.ModelDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShoppingMall
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShoppingMall()
        {
            this.Rent = new HashSet<Rent>();
        }
    
        public string Name { get; set; }
        public string Status { get; set; }
        public Nullable<int> CountPav { get; set; }
        public string City { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Ratio { get; set; }
        public Nullable<int> Floor { get; set; }
        public byte[] Picture { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }
    }
}
