using BlogProject_5175_06062022.DAL.Context;
using BlogProject_5175_06062022.DAL.Repositories.Concrete;
using BlogProject_5175_06062022.DAL.Repositories.Interfaces.Concrete;
using BlogProject_5175_06062022.WEB.Models.Mappers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            /*1*/
            services.AddDbContext<ProjectContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionTWO"));
                options.UseLazyLoadingProxies(true);
                //options.EnableSensitiveDataLogging(true);
               });

            /*2*/
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ProjectContext>();

            services.ConfigureApplicationCookie(a =>
            {
                a.LoginPath = new PathString("/Home/Login");  // buradan gelenden cookie baþlat
                a.ExpireTimeSpan = TimeSpan.FromDays(1);
                a.Cookie = new CookieBuilder { Name = "KullaniciCokie", SecurePolicy = CookieSecurePolicy.Always };
            });


            /*3*/
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ILikeRepository, LikeRepository>();
            services.AddScoped<IUserFollowedCategory, UserFollowedCategoryRepository>();
            services.AddScoped<IArticleCategoryRepository, ArticleCategoryRepository>();

            services.AddAutoMapper(typeof(Mapping));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); // kimlik doðrulama
            app.UseAuthorization(); // Yetkilendirme

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "Area", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
