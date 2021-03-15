using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apteka.Forms;
using Apteka.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Apteka.Data.Repositories;



namespace Apteka
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        public static Form LoginForm { get; set; }
        public static string UserName { get; set; }
        public static string UserPosition { get; set; }
        public static int UserId { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new DataContext())
            {
                db.Database.Migrate();
            }
            using (var db1 = new DataContext1())
            {
                db1.Database.Migrate();
            }



            ConfigureServices();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm = new LoginForm();
            Application.Run(LoginForm);
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<DataContext>();
            services.AddDbContext<DataContext1>();
            services.AddScoped<IEmployeeRep1, EmployeeRep1>();
            services.AddScoped<IItemRep1, ItemRep1>();
            services.AddScoped<ISellingContentsRep1, SellingContentsRep1>();
            services.AddScoped<ISellingRep1, SellingRep1>();
            services.AddScoped<IEmployeeRep, EmployeeRep>();
            services.AddScoped<IItemRep, ItemRep>();
            services.AddScoped<ISellingContentsRep, SellingContentsRep>();
            services.AddScoped<ISellingRep, SellingRep>();
            //
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
