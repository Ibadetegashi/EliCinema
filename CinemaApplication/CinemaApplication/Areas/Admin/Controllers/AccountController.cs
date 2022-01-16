using CinemaApplication.Data;
using CinemaApplication.Data.Static;
using CinemaApplication.Models;
using CinemaApplication.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CinemaApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles=UserRoles.Both)]

    public class AccountController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }


        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }
       
        public IActionResult Register() => View(new RegisterVM());
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);

            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
          

            if (user != null)
            {
                var admin = await _userManager.IsInRoleAsync(user, "Admin");
                var super = await _userManager.IsInRoleAsync(user, UserRoles.Super);
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded )
                    {
                        if (admin)
                        {

                            return RedirectToAction("Index", "Movies", new { area = "Admin" });
                        }else if (super)
                        {
                            return RedirectToAction("Users", "Account", new { area = "Admin" });

                        }
                        return RedirectToAction("Index", "Movies");
                    }
                   
                }
                TempData["Error"] = "Wrong credentials. Please, try again!";
                return View(loginVM);
            }

            TempData["Error"] = "Wrong credentials. Please, try again!";
            return View(loginVM);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            var user = await _userManager.FindByEmailAsync(registerVM.EmailAddress);
            if (user != null)
            {
                TempData["Error"] = "This email address is already in use";
                return View(registerVM);
            }

            var newUser = new ApplicationUser()
            {
                FullName = registerVM.FullName,
                Email = registerVM.EmailAddress,
                UserName = registerVM.EmailAddress
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);

            if (newUserResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.Admin);
            TempData["Success"] = " Admin Created";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Movies");
        }

        public IActionResult AccessDenied(string ReturnUrl)
        {
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {

            
            ApplicationUser user = await _context.Users.FindAsync(id);
            var orders = await _context.Orders.Where(n => n.UserId==id).ToListAsync();
            var admin = await _userManager.IsInRoleAsync(user, "Admin");
            


            
            if (orders.Count!=0)
            {


                TempData["Error"] = "The user has orders !";
            }
            //else if (admin)
            //{
            //    TempData["Error"] = "The user is admin!";
            //}
           
            else
            {
                
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();

                TempData["Success"] = "The user has been deleted!";
            }
           

            return RedirectToAction("Users");
        }

        public async Task<IActionResult> MakeAdmin(string id) 
        {
            ApplicationUser user = await _context.Users.FindAsync(id);
            var admin = await _userManager.IsInRoleAsync(user, "Admin");

         
                await _userManager.AddToRoleAsync(user, UserRoles.Admin);
                TempData["Success"] = user.FullName+ " now is Admin!";
            
            //else
            //{
            //    TempData["Error"] = "The user is already admin!";
            //}

            return RedirectToAction("Users");
        }
        public async Task<IActionResult> MakeUser(string id)
        {
            ApplicationUser user = await _context.Users.FindAsync(id);
                      
                await _userManager.RemoveFromRoleAsync(user, UserRoles.Admin);
            
                TempData["Success"] = user.FullName+" now is just User!";
                     
            return RedirectToAction("Users");
        }

        public async Task<IActionResult> CheckRole(string id)
        {
            ApplicationUser user = await _context.Users.FindAsync(id);
            var admin = await _userManager.IsInRoleAsync(user, "Admin");
           
            if (admin)
            {
                TempData["Info"] = "The user is Admin!";

            }
            else
            {
                TempData["Info"] = "The user is just User!";

            }

            return RedirectToAction("Users");

        }



    }


}
