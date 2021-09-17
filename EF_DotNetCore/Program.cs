using EF_DotNetCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace EF_DotNetCore
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var Configuration = builder.Build();

            services.AddSingleton<IConfiguration>(Configuration)
                    .AddDbContext<AppDBContext>(opt => opt.UseInMemoryDatabase("InMem"))
                    .AddTransient<Migrations.Configuration>()
                    .AddTransient<Form1>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var DBPrep = serviceProvider.GetRequiredService<Migrations.Configuration>();
                DBPrep.SeedData();
            }
        }
    }
}
