using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            var projects = new List<Project>()
            {
                new Project { ProjectId = 1, Name = "First 1", Description = "First Project" },
                new Project { ProjectId = 2, Name = "First 2", Description = "Second Project" }
            };

            return View(projects);
        }

        public IActionResult Create()
        {
           
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

    }
}
