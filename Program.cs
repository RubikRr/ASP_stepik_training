using WomanShop.Interfaces;
using WomanShop.Storages;

namespace WomanShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddSingleton<IProductsStorage,InMemoryProductsStorage>();
            builder.Services.AddSingleton<ICartsStorage,InMemoryCartsStorage>();
            builder.Services.AddSingleton<IOrdersStorage, InMemoryOrdersStorage>();
            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }


            app.UseStaticFiles();

            app.UseRouting();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}