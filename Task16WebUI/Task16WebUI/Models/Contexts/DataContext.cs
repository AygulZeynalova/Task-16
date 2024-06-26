using Microsoft.EntityFrameworkCore;

namespace Task16WebUI.Models.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
