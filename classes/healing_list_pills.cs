namespace kursovay
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class healing_list_pills
    {
        [Key]
        public int ID_healing_list_pills { get; set; }

        public int? ID_list_pills { get; set; }

        public int? ID_healing { get; set; }

        public virtual lechenie healing { get; set; }

        public virtual list_pills list_pills { get; set; }
    }
}
