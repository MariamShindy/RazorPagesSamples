using Microsoft.AspNetCore.Mvc;
using SampleRazorPages.Models;

namespace SampleRazorPages.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<Department>()
            {
                new Department { Id = 1, Name = "Department1",  },
                new Department { Id = 2, Name = "Department2",  },
                new Department { Id = 3, Name = "Department3"   }
            });
        }
    }
}
