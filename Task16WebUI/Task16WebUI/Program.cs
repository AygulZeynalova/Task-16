using Microsoft.EntityFrameworkCore;
using Task16WebUI.Models.Contexts;

namespace Task16WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"), opt =>
                {
                    opt.MigrationsHistoryTable("MigrationHistory");
                });
            }
           );
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
                name:"default", 
                pattern:"{controller=home}/{action=index}/{id?}");

            app.Run();
        }
    }
}
