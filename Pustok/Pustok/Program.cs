using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pustok.Database;
using Pustok.Services.Abstracts;
using Pustok.Services.Concretes;

namespace Pustok
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Services
            builder.Services
                .AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            builder.Services
                .AddDbContext<PustokDbContext>(o =>
                {
                    var connectionString = "Server=localhost;Port=5432;Database=Pustok;User Id=postgres;Password=postgres;";

                    o.UseNpgsql(connectionString);
                })
                .AddSingleton<IFileService, ServerFileService>();


            var app = builder.Build();

            //Middleware
            app.UseStaticFiles();

            app.MapControllerRoute("default", "{controller=Home}/{action=Index}");

            app.Run();
        }
    }
}