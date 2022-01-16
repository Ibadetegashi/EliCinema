using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CinemaApplication.Models.Users;

namespace CinemaApplication.Models.Users
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var users = GetUsers();
            
            ViewData["Users"] = users;

            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            // Ketu do te behet insertimi ne databaze
            // Mirepo per kete faze mjafton vetem me e renderu User objektin ne browser

            return View(user);
        }

        public IActionResult Details(int id)
        {
            var users = GetUsers();

            var user = users.Where(u => u.Id == id).First();

            ViewData["User"] = user;

            return View();
        }

        private List<User> GetUsers()
        {
            var users = new List<User>();

            users.Add(new Models.Users.User
            {
                Id = 1,
                FirstName = "Ibadete",
                LastName = "Gashi",
                IsAdmin = false
            });

            users.Add(new Models.Users.User
            {
                Id = 2,
                FirstName = "Erza",
                LastName = "Shatri",
                IsAdmin = false
            });

            users.Add(new Models.Users.User
            {
                Id = 3,
                FirstName = "Lis",
                LastName = "Paliqko",
                IsAdmin = true
            });

            users.Add(new Models.Users.User
            {
                Id = 4,
                FirstName = "Xhelal",
                LastName = "Jashari",
                IsAdmin = false
            });

            return users;
        }
    }
}