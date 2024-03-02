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
            ViewBag.Categories = _repo.Categories.OrderBy(x => x.CategoryID).ToList();
            ViewBag.Q1 = _repo.Tasks.Where(x => x.Quadrant == 1 & x.CompletionStatus == false).ToList();
            ViewBag.Q2 = _repo.Tasks.Where(x => x.Quadrant == 2 & x.CompletionStatus == false).ToList();
            ViewBag.Q3 = _repo.Tasks.Where(x => x.Quadrant == 3 & x.CompletionStatus == false).ToList();
            ViewBag.Q4 = _repo.Tasks.Where(x => x.Quadrant == 4 & x.CompletionStatus == false).ToList();

            //var tasks = _repo.Tasks.Where(x => x.CompletionStatus == false).OrderBy(x => x.TaskID).ToList();

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
