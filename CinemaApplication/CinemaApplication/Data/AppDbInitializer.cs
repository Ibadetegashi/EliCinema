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


                //context.Pages.AddRange(
                //    new Page
                //    {
                //        Title = "Home",
                //        Slug = "home",
                //        Content = "home page",
                //        Sorting = 0
                //    },
                //    new Page
                //    {
                //        Title = "About Us",
                //        Slug = "about-us",
                //        Content = "about us page",
                //        Sorting = 100
                //    },
                //    new Page
                //    {
                //        Title = "Services",
                //        Slug = "services",
                //        Content = "services page",
                //        Sorting = 100
                //    },
                //    new Page
                //    {
                //        Title = "Contact",
                //        Slug = "contact",
                //        Content = "contact page",
                //        Sorting = 100
                //    }
                //);
                //context.SaveChanges();
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
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
}
