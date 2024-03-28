namespace kursovay
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class list_tests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public list_tests()
        {
            list_pills_list_tests = new HashSet<list_pills_list_tests>();
        }

        [Key]
        public int ID_list_tests { get; set; }

        [StringLength(300)]
        public string name { get; set; }

        [StringLength(300)]
        public string opisanie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<list_pills_list_tests> list_pills_list_tests { get; set; }
    }
}
