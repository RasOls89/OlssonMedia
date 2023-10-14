using Microsoft.EntityFrameworkCore;
using Models;

namespace DataLayer.Internals
{
    public class MediaDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Database=OlssonMediaApp");
                base.OnConfiguring(optionBuilder);
            }
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Actor>().HasKey(b => b.ActorId);
            modelBuilder.Entity<Actor>().Property(b => b.ActorId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Actor>().Property(b => b.ActorName);
            modelBuilder.Entity<Actor>().Property(b => b.Sex);
            modelBuilder.Entity<Actor>().Property(b => b.Movies);
            modelBuilder.Entity<Actor>().Property(b => b.ActorAdded);
            modelBuilder.Entity<Actor>().Property(b => b.AddedBy);
            modelBuilder.Entity<Actor>().Property(b => b.ActorUpdated);
            modelBuilder.Entity<Actor>().Property(b => b.UpdatedBy);
            ///Many-to-many
            modelBuilder.Entity<Actor>().HasMany(b => b.Movies).WithMany(b => b.Actors);

            modelBuilder.Entity<Band>().HasKey(b => b.BandId);
            modelBuilder.Entity<Band>().Property(b => b.BandId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Band>().Property(b => b.BandName);
            
        }
    }
}