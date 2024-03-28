namespace kursovay
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("contra")]
    public partial class contra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contra()
        {
            med_card_contra = new HashSet<med_card_contra>();
        }

        [Key]
        public int ID_contra { get; set; }

        [StringLength(50)]
        public string banned_pill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<med_card_contra> med_card_contra { get; set; }
    }
}
