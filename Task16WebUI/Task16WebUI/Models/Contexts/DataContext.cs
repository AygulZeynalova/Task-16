using Microsoft.EntityFrameworkCore;
using Task16WebUI.Models.Entities;

namespace Task16WebUI.Models.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<ContactPost> ContactPosts{ get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
