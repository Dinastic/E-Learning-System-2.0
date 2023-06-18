using E_Learning_System_2._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Learning_System_2._0.Controllers
{
    public class HomeController : Controller
    {
        ELearnDbContext eLearnDbContext = new ELearnDbContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            bool userExists = eLearnDbContext.Users.Any(m => m.Username == user.Username && m.Password == user.Password);
            User u = eLearnDbContext.Users.FirstOrDefault(m => m.Username == user.Username && m.Password == user.Password);

            if (userExists)
            {
                //Debugger
                System.Diagnostics.Debug.WriteLine(u.Username);
                
                if (u.Role == "Student")
                {
                    Student s = eLearnDbContext.Students.FirstOrDefault(y => y.Username == user.Username);

                    TempData["username"] = s.Username;
                    TempData["name"] = s.Name;
                    TempData["surname"] = s.Surname;

                    return RedirectToAction("Index", "Students");
                }
            }
            else
            {
                ViewBag.LoginStatus = 0;
            }
            return View(user);
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