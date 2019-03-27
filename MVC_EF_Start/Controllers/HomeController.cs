using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_EF_Start.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //add dashboard view
        public IActionResult Dashboard()
        {
            return View();
        }
        //add portfolio
        public IActionResult PortfolioOptions()
        {
            return View();
        }
        //add about page
        public IActionResult About()
        {
            return View();
        }
        //add login page
        public IActionResult Login()
        {
            return View();
        }
        //add signup page
        public IActionResult Signup()
        {
            return View();
        }

        /* Saves the 5 day prices in database */
        public IActionResult PopulatePrices()
        {
                    
            return View("Prices");
        }
    }
}