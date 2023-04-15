using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;    // add this
using ASPNET_FP.Models;
using ASPNET_FP.Data;
using ASPNET_FP.Models;

namespace ASPNET_FP
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddMemoryCache();
            services.AddSession();

            //services.AddControllersWithViews().AddNewtonsoftJson();

            services.AddDbContext<MyLesseeDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MyLesseeDBContext")));

            // add this
            services.AddIdentity<Account, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<MyLesseeDBContext>()
              .AddDefaultTokenProviders();
            services.AddScoped<UserManager<Account>>();
        }

        // Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app)
        //{
        //    app.UseDeveloperExceptionPage();
        //    app.UseHttpsRedirection();
        //    app.UseStaticFiles();

        //    app.UseRouting();

        //    app.UseAuthentication();   // add this
        //    app.UseAuthorization();    // add this

        //    app.UseSession();

        //    app.UseEndpoints(endpoints =>
        //    {
        //        // route for Admin area
        //        endpoints.MapAreaControllerRoute(
        //            name: "admin",
        //            areaName: "Admin",
        //            pattern: "Admin/{controller=Book}/{action=Index}/{id?}");

        //        // route for paging, sorting, and filtering
        //        endpoints.MapControllerRoute(
        //            name: "",
        //            pattern: "{controller}/{action}/page/{pagenumber}/size/{pagesize}/sort/{sortfield}/{sortdirection}/filter/{author}/{genre}/{price}");

        //        // route for paging and sorting only
        //        endpoints.MapControllerRoute(
        //            name: "",
        //            pattern: "{controller}/{action}/page/{pagenumber}/size/{pagesize}/sort/{sortfield}/{sortdirection}");

        //        // default route
        //        endpoints.MapControllerRoute(
        //            name: "default",
        //            pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");
        //    });
        //}
    }
}
