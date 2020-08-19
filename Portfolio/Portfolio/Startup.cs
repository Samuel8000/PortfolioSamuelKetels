using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Portfolio.Core.Modelhelpers;
using Portfolio.Data;
using Portfolio.Utility;

namespace Portfolio
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
            services.AddRazorPages().AddMvcOptions(o => o.Filters.Add(new AuthorizeFilter()));

            services.AddDbContextPool<PortfolioDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("PortfolioDb"));
            });

            //Data Classes

            services.AddScoped<ISkillData, SqlSkillData>();
            services.AddScoped<ICertificateData, SqlCertificateData>();
            services.AddScoped<IContactData, SqlContactData>();
            services.AddScoped<IProjectData, SqlProjectData>();
            services.AddScoped<IAboutMeData, SqlAboutMe>();
            services.AddScoped<IUserData, SqlUserData>();
            services.AddScoped<ISkillPathData, SqlSkillPathData>();

            //Utilities

            services.AddScoped<IFileUploader, FileUploader>();
            services.AddSingleton<IPasswordHasher, PasswordHasher>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
