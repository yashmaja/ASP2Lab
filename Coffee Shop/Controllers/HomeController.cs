using Coffee_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration(User u)
        {
            return View(u);
        }

        public IActionResult UserList()
        {
            List<User> result = null;
            using (UserContext context = new UserContext())
            {
                result = context.Users.ToList();
            }

            return View(result);
        }

        public IActionResult SaveUser(User u)
        {
            using (UserContext context = new UserContext())
            {
                context.Users.Add(u);
                context.SaveChanges();
            }

            return RedirectToAction("UserList");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
