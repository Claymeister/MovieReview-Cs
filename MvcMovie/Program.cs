using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using Microsoft.AspNetCore.Identity;
using MvcMovie.Models;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<MvcMovieContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMovieContext")));

        //builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        builder.Services.AddDefaultIdentity<MvcMovieUser>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequiredLength = 8;

            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
            //options.SignIn.RequireConfirmedAccount = true;
        })
        .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<MvcMovieContext>();

        builder.Services.AddScoped<MvcMovieUserManager>();
        builder.Services.AddControllersWithViews();
        builder.Services.AddRazorPages();

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;

            SeedData.Initialize(services);
        }
        using (var scope = app.Services.CreateScope()) 
        {
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var roles = new[] { "Admin", "Mod", "Member" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
        using (var scope = app.Services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<MvcMovieUser>>();

            string email = "admin@mail.com";
            if(await userManager.FindByEmailAsync(email) == null)
            {
                var user = new MvcMovieUser();
                user.UserName = email;
                user.Email = email;
                user.Nickname = "Administrator";
                string password = "Admin123!";
                await userManager.CreateAsync(user, password);

                await userManager.AddToRoleAsync(user, "Admin");
                await userManager.AddToRoleAsync(user, "Member");
            }
        }

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            //app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();

        app.Run();
    }
}