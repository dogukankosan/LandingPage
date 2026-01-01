using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MarmaraHijyen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // MVC
            builder.Services.AddControllersWithViews();

            // HttpClient (IP Geolocation vs.)
            builder.Services.AddHttpClient();

            WebApplication app = builder.Build();

            // ❌ DEV ortamında HSTS + HTTPS redirect KAPALI
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error/500");
                app.UseHsts();
            }
            else
            {
                app.UseDeveloperExceptionPage(); // DEV için detaylı hata
            }

            // ❌ DEV ortamında HTTPS redirect kapalı
            // app.UseHttpsRedirection();

            // Static files
            app.UseStaticFiles();

            // Routing
            app.UseRouting();

            // ❌ DEV ortamında security header'lar opsiyonel
            // (istersen açık bırakabilirsin ama şart değil)
            app.Use(async (context, next) =>
            {
                context.Response.Headers["X-Content-Type-Options"] = "nosniff";
                context.Response.Headers["X-Frame-Options"] = "SAMEORIGIN";
                context.Response.Headers["Referrer-Policy"] = "strict-origin-when-cross-origin";
                await next();
            });

            app.UseAuthorization();

            // Status codes (404, 403 vs.)
            app.UseStatusCodePagesWithReExecute("/Error/{0}");

            // 🌍 LOCALIZED ROUTE
            app.MapControllerRoute(
                name: "localized",
                pattern: "{culture:regex(^(en|zh|ru|ar)$)}/{controller=Home}/{action=Index}/{id?}");

            // 🇹🇷 DEFAULT (TR)
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
