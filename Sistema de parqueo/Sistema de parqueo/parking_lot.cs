//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_de_parqueo
{
    using System;
    using System.Collections.Generic;
    
    public partial class parking_lot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public parking_lot()
        {
            this.parking_slot = new HashSet<parking_slot>();
        }
    
        public int id_parking_lot { get; set; }
        public string is_parking_lot_full { get; set; }
        public int numbers_of_slots { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<parking_slot> parking_slot { get; set; }
    }
}