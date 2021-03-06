using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using App.Models;
using App.Services;
using App.Repository.IBooking;
using App.Repository.IBranch;
using App.Repository.IBookingRepository;
using App.Repository.IBranchRepository;
using Microsoft.AspNetCore.Mvc;

namespace App
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

            services.AddOptions();
            var mailsetting = Configuration.GetSection("MailSettings");
            services.Configure<MailSettings>(mailsetting);
            services.AddSingleton<IEmailSender, SendMailService>();

            services.AddSingleton<IdentityErrorDescriber, AppIdentityErrorDescriber>();
            services.AddScoped<IBooking, IBookingRepository>();
            services.AddScoped<IBranch, IBranchRepository>();
            services.AddRazorPages()
                .AddMvcOptions(options =>
                {
                    options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(
                        _ => "The field is required.");

                    options.ModelBindingMessageProvider.SetValueIsInvalidAccessor(
                        _ => "The field is required.");

                });
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddDbContext<AppDbContext>(options =>
            {
                string connectString = Configuration.GetConnectionString("AppMvcConnectionString");
                options.UseSqlServer(connectString);
            });
            // Dang ky Identity
            services.AddIdentity<AppUser, IdentityRole>()
                    .AddEntityFrameworkStores<AppDbContext>()
                    .AddDefaultTokenProviders();
            // Truy c???p IdentityOptions
            services.Configure<IdentityOptions>(options =>
            {
                // Thi???t l???p v??? Password
                options.Password.RequireDigit = false; // Kh??ng b???t ph???i c?? s???
                options.Password.RequireLowercase = false; // Kh??ng b???t ph???i c?? ch??? th?????ng
                options.Password.RequireNonAlphanumeric = false; // Kh??ng b???t k?? t??? ?????c bi???t
                options.Password.RequireUppercase = false; // Kh??ng b???t bu???c ch??? in
                options.Password.RequiredLength = 3; // S??? k?? t??? t???i thi???u c???a password
                options.Password.RequiredUniqueChars = 1; // S??? k?? t??? ri??ng bi???t

                // C???u h??nh Lockout - kh??a user
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Kh??a 5 ph??t
                options.Lockout.MaxFailedAccessAttempts = 3; // Th???t b???i 3 l??? th?? kh??a
                options.Lockout.AllowedForNewUsers = true;

                // C???u h??nh v??? User.
                options.User.AllowedUserNameCharacters = // c??c k?? t??? ?????t t??n user
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;  // Email l?? duy nh???t


                // C???u h??nh ????ng nh???p.
                options.SignIn.RequireConfirmedEmail = false;            // C???u h??nh x??c th???c ?????a ch??? email (email ph???i t???n t???i)
                options.SignIn.RequireConfirmedPhoneNumber = false;     // X??c th???c s??? ??i???n tho???i
                options.SignIn.RequireConfirmedAccount = false;

            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/login/";
                options.LogoutPath = "/logout/";
                options.AccessDeniedPath = "/khongduoctruycap.html";
            });

            services.AddAuthentication()
                    .AddGoogle(options =>
                    {
                        var gconfig = Configuration.GetSection("Authentication:Google");
                        options.ClientId = gconfig["ClientId"];
                        options.ClientSecret = gconfig["ClientSecret"];
                        // https://localhost:5001/signin-google
                        options.CallbackPath = "/dang-nhap-tu-google";
                    })
                    .AddFacebook(options =>
                    {
                        var fconfig = Configuration.GetSection("Authentication:Facebook");
                        options.AppId = fconfig["AppId"];
                        options.AppSecret = fconfig["AppSecret"];
                        options.CallbackPath = "/dang-nhap-tu-facebook";
                    })
                    // .AddTwitter()
                    // .AddMicrosoftAccount()
                    ;
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
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                // endpoints.MapAreaControllerRoute(
                //     name: "admin",
                //     pattern: "{controller}/{action=Index}/{id?}",
                //     areaName: "AdminManage"
                // );

                endpoints.MapRazorPages();
            });
        }
    }
}
