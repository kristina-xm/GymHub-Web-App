namespace GymHub.Web
{
    using GymHub.Data;
    using GymHub.Data.Models;
    using GymHub.Services.Data;
    using GymHub.Services.Data.Interfaces;
    using GymHub.Web.Areas.Admin.Controllers;
    using GymHub.Web.Areas.Admin.Services;
    using GymHub.Web.Areas.Admin.Services.Interfaces;
    using GymHub.Web.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using static GymHub.Common.GeneralApplicationConstants;
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<GymHubDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();


            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
                options.Password.RequireLowercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
                options.Password.RequireUppercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
                options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
                options.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
            })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<GymHubDbContext>();
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<ITrainerService, TrainerService>();
            builder.Services.AddScoped<IGroupActivityService, GroupActivityService>();
            builder.Services.AddScoped<IIndividualTrainingService, IndividualTrainingService>();
            builder.Services.AddScoped<ITraineeService, TraineeService>();
            builder.Services.AddScoped<IAllUsersService, AllUsersService>();

            builder.Services
               .AddControllersWithViews()
               .AddMvcOptions(options =>
               {
                   options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
               });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error/500");
                app.UseStatusCodePagesWithRedirects("/Home/Error?statuscode={0}");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            if (app.Environment.IsDevelopment())
            {
                app.SeedAdministrator(AdminUser.AdminEmail);
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "areas",
                        pattern: "/{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
            });

            app.Run();
        }
    }
}