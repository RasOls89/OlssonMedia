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

    }
}