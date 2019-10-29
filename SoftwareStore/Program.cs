using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SoftwareStore.Data;
using SoftwareStore.Infrastructure;
using SoftwareStore.Models;
using SoftwareStore.Models.Concrete.Identity;

namespace SoftwareStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //disable scope checking
            var host = CreateWebHostBuilder(args).Build();
            //var accessToken = (new AzureServiceTokenProvider()).GetAccessTokenAsync("https://database.windows.net").Result;
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                   
                    SeedData.EnsurePopulated(context, userManager);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
