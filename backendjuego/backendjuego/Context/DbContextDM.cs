using Microsoft.EntityFrameworkCore;
using backendjuego.Model;


namespace backendjuego.Context
{
    public class DbContextDM : DbContext
    {
        public DbContextDM(DbContextOptions<DbContextDM> options) : base(options) { }


        public DbSet<Users> Users { get; set; }
        public DbSet<Usertype> UserTypes { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<PuntosPersons> PuntosPersons { get; set; }
   
                protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Documents>()
            .HasKey(u => u.DocumentId);
            
            modelBuilder.Entity<Users>()
                .HasKey(u => u.UserId);

            modelBuilder.Entity<Usertype>()
               .HasKey(u => u.UserTipeId);

            modelBuilder.Entity<PuntosPersons>()
                .HasKey(u => u.PersonId);

            //ignorar la propoiedad acumular puntos
            modelBuilder.Entity<PuntosPersons>()
                .Ignore(u => u.AcumuladorPuntos);
        }
    }
}
