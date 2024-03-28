namespace kursovay
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("healing")]
    public partial class lechenie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lechenie()
        {
            healing_list_pills = new HashSet<healing_list_pills>();
            istoria_priemov = new HashSet<istoria_priemov>();
        }

        [Key]
        public int ID_healing { get; set; }

        [StringLength(50)]
        public string bed_rest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<healing_list_pills> healing_list_pills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<istoria_priemov> istoria_priemov { get; set; }
    }
}
