using ZooKeeperApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ZooKeeperApplication.Data
{
    public class ZooContext : DbContext
    {
        public ZooContext(DbContextOptions<ZooContext> options) : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().ToTable("Animal");
      
        }
    }
}
