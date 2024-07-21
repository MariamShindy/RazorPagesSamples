using Microsoft.AspNetCore.Mvc;
using SampleRazorPages.Models;

namespace SampleRazorPages.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<Project>()
            {
                new Project { Id = 1, Name = "Project1", Description = "Description1", Priority = 1, Budget = 1000.00M  },
                new Project { Id = 2, Name = "Project2", Description = "Description2", Priority = 2, Budget = 2000.00M },
                new Project { Id = 3, Name = "Project3", Description = "Description3", Priority = 3, Budget = 3000.00M  }
            });
        }
    }
}
