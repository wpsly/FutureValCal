using FutureValCal.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValCal.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FutureVal = "";
            return View();
        }

        public IActionResult Index(FutureValModel futureValModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FutureVal = futureValModel.Calculate().ToString("C2");
            }
            else
            {
                ViewBag.FutureVal = "";
            }

            return View();
        }
    }
}
