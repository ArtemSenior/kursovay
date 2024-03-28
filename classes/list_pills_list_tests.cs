namespace kursovay
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class list_pills_list_tests
    {
        [Key]
        public int ID_list_pills_list_tests { get; set; }

        public int? ID_list_pills { get; set; }

        public int? ID_list_tests { get; set; }

        public virtual list_pills list_pills { get; set; }

        public virtual list_tests list_tests { get; set; }
    }
}
