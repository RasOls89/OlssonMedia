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
        public DbSet<Album> Albums { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasKey(b => b.UserId);
            modelBuilder.Entity<User>().Property(b => b.UserId).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(b => b.UserName);
            modelBuilder.Entity<User>().Property(b => b.Password);
            modelBuilder.Entity<User>().Property(b => b.FirstName);
            modelBuilder.Entity<User>().Property(b => b.LastName);
            modelBuilder.Entity<User>().Property(b => b.FullName);
            modelBuilder.Entity<User>().Property(b => b.AcessRights);
            modelBuilder.Entity<User>().Property(b => b.Added);
            modelBuilder.Entity<User>().Property(b => b.AddedBy);
            modelBuilder.Entity<User>().Property(b => b.Updated);
            modelBuilder.Entity<User>().Property(b => b.UpdatedBy);
            modelBuilder.Entity<User>().Property(b => b.ReasonForUpdating);
            modelBuilder.Entity<User>().HasData(new User { UserId = 1, UserName = "Admin", Password = "SysAdmin1", FirstName = "John", LastName = "Doe", FullName = "John Doe", AcessRights = "Admin", Added = new DateTime(1989, 11, 22), AddedBy = "System", Updated = new DateTime(2019, 08, 17), UpdatedBy = "System", ReasonForUpdating = "Marrige" });

            modelBuilder.Entity<Actor>().HasKey(b => b.ActorId);
            modelBuilder.Entity<Actor>().Property(b => b.ActorId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Actor>().Property(b => b.ActorName);
            modelBuilder.Entity<Actor>().Property(b => b.Sex);
            modelBuilder.Entity<Actor>().Property(b => b.Movies);
            modelBuilder.Entity<Actor>().Property(b => b.Added);
            modelBuilder.Entity<Actor>().Property(b => b.AddedBy);
            modelBuilder.Entity<Actor>().Property(b => b.Updated);
            modelBuilder.Entity<Actor>().Property(b => b.UpdatedBy);
            modelBuilder.Entity<Actor>().Property(b => b.ReasonForUpdating);
            ///Many-to-many
            modelBuilder.Entity<Actor>().HasMany(b => b.Movies).WithMany(b => b.Actors);

            modelBuilder.Entity<Movie>().HasKey(b => b.MovieId);
            modelBuilder.Entity<Movie>().Property(b => b.MovieId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Movie>().Property(b => b.MovieTitle);
            modelBuilder.Entity<Movie>().Property(b => b.Director);
            modelBuilder.Entity<Movie>().Property(b => b.Actors);
            modelBuilder.Entity<Movie>().Property(b => b.Genre);
            modelBuilder.Entity<Movie>().Property(b => b.StillOwn);
            modelBuilder.Entity<Movie>().Property(b => b.Added);
            modelBuilder.Entity<Movie>().Property(b => b.AddedBy);
            modelBuilder.Entity<Movie>().Property(b => b.Updated);
            modelBuilder.Entity<Movie>().Property(b => b.UpdatedBy);
            modelBuilder.Entity<Movie>().Property(b => b.ReasonForUpdating);
           

            modelBuilder.Entity<Band>().HasKey(b => b.BandId);
            modelBuilder.Entity<Band>().Property(b => b.BandId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Band>().Property(b => b.BandName);
            modelBuilder.Entity<Band>().Property(b => b.Formed);
            modelBuilder.Entity<Band>().Property(b => b.IsActive);
            modelBuilder.Entity<Band>().Property(b => b.Albums);
            modelBuilder.Entity<Band>().Property(b => b.Added);
            modelBuilder.Entity<Band>().Property(b => b.AddedBy);
            modelBuilder.Entity<Band>().Property(b => b.Updated);
            modelBuilder.Entity<Band>().Property(b => b.UpdatedBy);
            modelBuilder.Entity<Band>().Property(b => b.ReasonForUpdating);
         

            modelBuilder.Entity<Album>().HasKey(b => b.AlbumId);
            modelBuilder.Entity<Album>().Property(b => b.AlbumId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Album>().Property(b => b.BandName);
            modelBuilder.Entity<Album>().Property(b => b.AlbumTitle);
            modelBuilder.Entity<Album>().Property(b => b.Format);
            modelBuilder.Entity<Album>().Property(b => b.Genre);
            modelBuilder.Entity<Album>().Property(b => b.Year);
            modelBuilder.Entity<Album>().Property(b => b.StillOwn);
            modelBuilder.Entity<Album>().Property(b => b.Added);
            modelBuilder.Entity<Album>().Property(b => b.AddedBy);
            modelBuilder.Entity<Album>().Property(b => b.Updated);
            modelBuilder.Entity<Album>().Property(b => b.UpdatedBy);
            modelBuilder.Entity<Album>().Property(b => b.ReasonForUpdating);
            modelBuilder.Entity<Album>().HasOne<Band>(b => b.Band).WithMany(b => b.Albums).HasForeignKey(b => b.BandName);

           
        }
    }
}