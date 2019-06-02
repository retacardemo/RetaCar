using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentaTransport.DAL.DAOs;
using RentaTransport.DAL.DataContexts;
using RentaTransport.WebUI.Utils;
using System;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using RentaTransport.AdminUI.Utils;

namespace RentaTransport.WebUI
{
    public class Startup
    {
        public IConfiguration _configuration { get; }
        public Startup(IHostingEnvironment env)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            _configuration = builder.Build();
        }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<MainDataContext>(options =>
            {
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddDbContext<ApplicationDataContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<UserDao, RoleDao>()
                .AddRoles<RoleDao>()
                .AddRoleManager<RoleManager<RoleDao>>()
                .AddEntityFrameworkStores<ApplicationDataContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 6;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddAntiforgery();
            services.AddDirectoryBrowser();
            services.AddResponseCompression();

            services.AddAuthentication(options =>
                {
                    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
                    options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
                    options.DefaultSignInScheme = IdentityConstants.ApplicationScheme;
                })
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/en-US/account/login");
                    options.LogoutPath = new PathString("/en-US/account/logout");
                    options.AccessDeniedPath = new PathString("/en-US/account/accessdenied");
                    options.SlidingExpiration = true;
                    options.Cookie.HttpOnly = true;
                    options.Cookie.Expiration = TimeSpan.FromDays(1);
                    options.Cookie.SameSite = SameSiteMode.Strict;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                });

            services.AddAuthorization();
            services.AddSession();
            services.AddRouting();

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new CultureInfo[]
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("ru-RU"),
                    new CultureInfo("az-Latn-AZ"),
                };

                options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
                options.RequestCultureProviders.Insert(0, new RouteValueRequestCultureProvider(supportedCultures) { Options = options });
            });

            services.Configure<RouteOptions>(options =>
            {
                options.ConstraintMap.Add("culture", typeof(LanguageRouteConstraint));
            });

            services.AddMvc()
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver())
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddMvcLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            ServiceConfig.Register(services);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IOptions<RequestLocalizationOptions> reqLocalizationOptions)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseRequestLocalization(reqLocalizationOptions.Value);
            app.UseSession();
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseCookiePolicy();
            app.UseStatusCodePages();
            app.UseRequestLocalization();
            app.UseResponseCompression();

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller = Home}/{action = Index}/{id?}");

                routes.MapRoute(
                    name: "culture_default",
                    template: "{culture:culture}/{controller=Home}/{action=Index}/{id?}",
                    defaults: new { culture = "en-US" }
                );
            });
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute(name: "default", template: "{controller = Home}/{action = Index}/{id?}");
        }
    }
}
