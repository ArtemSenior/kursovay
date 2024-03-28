namespace kursovay
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class med_card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public med_card()
        {
            istoria_priemov = new HashSet<istoria_priemov>();
            med_card_contra = new HashSet<med_card_contra>();
        }

        [Key]
        public int ID_med_card { get; set; }

        [StringLength(50)]
        public string surname { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string middle_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_birth { get; set; }

        [StringLength(15)]
        public string phone_number { get; set; }

        [StringLength(50)]
        public string number_passport { get; set; }

        [StringLength(50)]
        public string seria_passport { get; set; }

        [StringLength(50)]
        public string snils { get; set; }

        [StringLength(50)]
        public string place_of_residence { get; set; }

        [StringLength(50)]
        public string settlenment { get; set; }

        [StringLength(50)]
        public string street { get; set; }

        public int? number_house { get; set; }

        public int? number_room { get; set; }

        [StringLength(50)]
        public string profession { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<istoria_priemov> istoria_priemov { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<med_card_contra> med_card_contra { get; set; }
    }
}
