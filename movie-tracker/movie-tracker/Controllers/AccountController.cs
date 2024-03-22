using Microsoft.AspNetCore.Mvc;
using movie_tracker.Models;
using System;

namespace movie_tracker.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _dbContext;

        public AccountController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Check credentials against database
                var user = _dbContext.Users.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);
                if (user != null)
                {
                    // Authentication successful, redirect to dashboard or desired page
                    return RedirectToAction("Index", "Movie");
                }
                else
                {
                    // Authentication failed, return to login page with error message
                    ModelState.AddModelError(string.Empty, "Invalid username or password");
                }
            }
            return View(model);
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Create new user entity
                var user = new User
                {
                    Username = model.Username,
                    Password = model.Password,
                    Email = model.Email, // Set Email property
                                         // Set other properties as needed
                };

                // Add user to the database
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();

                // Redirect to login page upon successful registration
                return RedirectToAction("Login");
            }
            return View(model);
        }
    }
}