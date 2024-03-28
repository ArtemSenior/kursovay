namespace kursovay
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("doctor")]
    public partial class doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doctor()
        {
            istoria_priemov = new HashSet<istoria_priemov>();
        }

        [Key]
        public int ID_doctor { get; set; }

        [StringLength(50)]
        public string surname { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string middle_name { get; set; }

        public int? cabinet { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_birth { get; set; }

        [StringLength(15)]
        public string work_number { get; set; }

        [StringLength(50)]
        public string specialization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<istoria_priemov> istoria_priemov { get; set; }
    }
}
