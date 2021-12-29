using CinemaApplication.Data;

using CinemaApplication.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApplication.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();
               

                    context.Pages.AddRange(
                        new Page
                        {
                            Title = "Home",
                            Slug = "home",
                            Content = "home page",
                            Sorting = 0
                        },
                        new Page
                        {
                            Title = "About Us",
                            Slug = "about-us",
                            Content = "about us page",
                            Sorting = 100
                        },
                        new Page
                        {
                            Title = "Services",
                            Slug = "services",
                            Content = "services page",
                            Sorting = 100
                        },
                        new Page
                        {
                            Title = "Contact",
                            Slug = "contact",
                            Content = "contact page",
                            Sorting = 100
                        }
                    );
                    context.SaveChanges();
                
            }




        }

        //public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {

        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        //        string adminUserEmail = "admin@etickets.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if(adminUser == null)
        //        {
        //            var newAdminUser = new ApplicationUser()
        //            {
        //                FullName = "Admin User",
        //                UserName = "admin-user",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }


        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new ApplicationUser()
        //            {
        //                FullName = "Application User",
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
        //    }
    }
    }
