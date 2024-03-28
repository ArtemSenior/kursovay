namespace kursovay
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class med_card_contra
    {
        [Key]
        public int ID_med_card_contra { get; set; }

        public int? ID_med_card { get; set; }

        public int? ID_contra { get; set; }

        public virtual contra contra { get; set; }

        public virtual med_card med_card { get; set; }
    }
}
