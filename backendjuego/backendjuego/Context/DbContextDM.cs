using Microsoft.EntityFrameworkCore;
using backendjuego.Model;


namespace backendjuego.Context
{
    public class DbContextDM : DbContext
    {
        public DbContextDM(DbContextOptions<DbContextDM> options) : base(options) { }


        public DbSet<Persons> Persons { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Usertype> UserTypes { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<Historics> Historics { get; set; }
        public DbSet<DocumentsHistorics> DocumentsHistorics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Documents>()
            .HasKey(u => u.DocumentId);

            modelBuilder.Entity<Historics>()
            .HasKey(u => u.HistoricId);

            modelBuilder.Entity<Persons>()
            .HasKey(u => u.PersonId);

            modelBuilder.Entity<Users>()
                .HasKey(u => u.UserId);



            // Relación Many-to-Many Document-Historic
            modelBuilder.Entity<DocumentsHistorics>()
                .HasKey(dh => new { dh.DocumentId, dh.HistoricId });

            modelBuilder.Entity<DocumentsHistorics>()
                .HasOne(dh => dh.Documents)
                .WithMany(d => d.DocumentsHistorics)
                .HasForeignKey(dh => dh.DocumentId);

            modelBuilder.Entity<DocumentsHistorics>()
                .HasOne(dh => dh.Historics)
                .WithMany(h => h.DocumentsHistorics)
                .HasForeignKey(dh => dh.HistoricId);
        }
    }
}
