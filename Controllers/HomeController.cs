using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcWebSite.Models;

namespace MvcWebSite.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
             HomeModel home = new HomeModel();

            home.Nome = "Kayo Leanndro";
            home.Email = "kayoleannd222@gmail.com";

            return View(home);
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
