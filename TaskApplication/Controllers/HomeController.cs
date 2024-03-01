using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskApplication.Models;

namespace TaskApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
