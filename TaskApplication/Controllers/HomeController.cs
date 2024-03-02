using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TaskApplication.Models;

namespace TaskApplication.Controllers
{
    public class HomeController : Controller
    {

        private ITaskRepository _repo;

        public HomeController(ITaskRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FillTaskApplication()
        {
            return View("TaskApplication");
        }

        [HttpPost]
        public IActionResult FillTaskApplication(Models.Task response)
        {
            if (ModelState.IsValid)
            {
                _repo.AddTask(response);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Categories = _repo.Categories.ToList();

                return View("TaskApplication", response);
            }
        }
    }
}
