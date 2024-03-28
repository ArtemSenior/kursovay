using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace kursovay
{
    public partial class Model1 : DbContext
    {
        public Model1(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<contra> contra { get; set; }
        public virtual DbSet<doctor> doctor { get; set; }
        public virtual DbSet<lechenie> healing { get; set; }
        public virtual DbSet<healing_list_pills> healing_list_pills { get; set; }
        public virtual DbSet<istoria_priemov> istoria_priemov { get; set; }
        public virtual DbSet<list_pills> list_pills { get; set; }
        public virtual DbSet<list_pills_list_tests> list_pills_list_tests { get; set; }
        public virtual DbSet<list_tests> list_tests { get; set; }
        public virtual DbSet<med_card> med_card { get; set; }
        public virtual DbSet<med_card_contra> med_card_contra { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<contra>()
                .Property(e => e.banned_pill)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.middle_name)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.work_number)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.specialization)
                .IsUnicode(false);

            modelBuilder.Entity<lechenie>()
                .Property(e => e.bed_rest)
                .IsUnicode(false);

            modelBuilder.Entity<istoria_priemov>()
                .Property(e => e.disease)
                .IsUnicode(false);

            modelBuilder.Entity<istoria_priemov>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<istoria_priemov>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<list_pills>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<list_pills>()
                .Property(e => e.opisanie)
                .IsUnicode(false);

            modelBuilder.Entity<list_tests>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<list_tests>()
                .Property(e => e.opisanie)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.middle_name)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.number_passport)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.seria_passport)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.snils)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.place_of_residence)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.settlenment)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<med_card>()
                .Property(e => e.profession)
                .IsUnicode(false);
        }
    }
}
