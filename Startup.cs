using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.IdentityAuth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using eCommerce_backend.Data;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace eCommerce_backend
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
            services.AddDbContext<IdentityContext>(options => options.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));
            services.AddDbContext<ECommerceContext>(options => options.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));
            // For Identity
            // Adding Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            // Adding Jwt Bearer
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["JWT: ValidAudience"],
                    ValidIssuer = Configuration["JWT: ValidIssuer"],
                    RequireExpirationTime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT: SecretKey"])),
                    ValidateIssuerSigningKey = true,
                };
            });
            services.AddIdentity<ApplicationUser, ApplicationRole>()
            .AddEntityFrameworkStores<IdentityContext>()
            .AddDefaultTokenProviders();
            services.AddCors();
            services.AddControllers().AddNewtonsoftJson();
            /*AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            });
            options =>
            {
                options.OutputFormatters.RemoveType<SystemTextJsonOutputFormatter>();
                options.OutputFormatters.Add(new SystemTextJsonOutputFormatter(new JsonSerializerOptions(JsonSerializerDefaults.Web)
                {
                    ReferenceHandler = ReferenceHandler.Preserve,
                }));
            });*/

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Brand}/{action=Index}/{id?}");
            });
        }
    }
}
