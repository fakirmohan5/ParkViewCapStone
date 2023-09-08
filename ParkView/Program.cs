using Microsoft.EntityFrameworkCore;
using ParkView.Data;
using ParkView.Models.Domain;
using Microsoft.AspNetCore.Identity;

using System.Text.Json.Serialization;

namespace ParkView
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddScoped<IHotel, HotelRepo>();
            builder.Services.AddScoped<IRoom, RoomRepo>();
            builder.Services.AddScoped<IBooking, BookingRepo>();
            builder.Services.AddRazorPages();


			// Add services to the container.
			builder.Services.AddControllersWithViews()
                .AddJsonOptions(options =>
                {

                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                }); 


            builder.Services.AddDbContext<ParkViewDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ParkViewConnectionString")));

            builder.Services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ParkViewDbContext>();

            //GOOGLE Authentication

            builder.Services.AddAuthentication().AddGoogle(googleoptions =>
            {
                googleoptions.ClientId = builder.Configuration["Authentication:Google:ClientId"];
                googleoptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];

            });





            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
			app.MapRazorPages();
               app.UseAuthentication();;

			app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            //ROLE BASED



            using (var scope = app.Services.CreateScope())
            {
                //seeding
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var roles = new[] { "Admin", "Member" };
                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role))
                        await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            using (var scope = app.Services.CreateScope())
            {
                //seeding
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                string email = "admin@admin.com";
                string password = "Password@1234";
                if (await userManager.FindByEmailAsync(email) == null)
                {
                    var user = new IdentityUser();
                    user.UserName = email;
                    user.Email = email;

                    await userManager.CreateAsync(user, password);
                    await userManager.AddToRoleAsync(user, "Admin");

                }
            }




            app.Run();
        }
    }
}