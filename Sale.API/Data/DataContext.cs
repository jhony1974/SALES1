using Microsoft.EntityFrameworkCore;
using Sale.Shared.Entities;

namespace Sale.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<County> Counties { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<County>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
