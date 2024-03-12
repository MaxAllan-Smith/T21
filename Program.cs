using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using T21.Forms;
using T21_Library.DataAccess;
using T21_Library.Repositories;

namespace T21
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();

            InitializeDatabase();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                try
                {
                    var formMain = services.GetRequiredService<FormMain>();
                    Application.Run(formMain);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                // DbContext
                services.AddScoped<T21DbContext>();

                // Repositories
                services.AddScoped<UserRepository>();
                services.AddScoped<BranchRepository>();
                services.AddScoped<CompanyRepository>();
                services.AddScoped<SupplierRepository>();
                services.AddScoped<CurrencyCodeRepository>();
                services.AddScoped<VATCodeRepository>();
                services.AddScoped<SellingLevelRepository>();
                services.AddScoped<CustomerPaymentTermsRepository>();

                // Forms
                services.AddScoped<FormMain>();
                services.AddScoped<FormLogin>();
            });
        
        private static void InitializeDatabase()
        {
            Database.SetInitializer(new T21DbInitializer());

            using (var context = new T21DbContext())
            {
                context.Database.Initialize(force: true);
            }
        }
    }
}
