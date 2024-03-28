namespace kursovay
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class istoria_priemov
    {
        [Key]
        public int ID_istoria_priemov { get; set; }

        [StringLength(50)]
        public string disease { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_priem { get; set; }

        [StringLength(50)]
        public string time { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public int? ID_med_card { get; set; }

        public int? ID_healing { get; set; }

        public int? ID_doctor { get; set; }

        public virtual doctor doctor { get; set; }

        public virtual lechenie healing { get; set; }

        public virtual med_card med_card { get; set; }
    }
}
