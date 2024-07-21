using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleRazorPages.Models;

namespace SampleRazorPages.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {

            return View(new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Mariam", LastName = "Shindy", Position = ".NET intern", HireDate = new DateTime(2023, 1, 1) },
                new Employee { Id = 2, FirstName = "Jana", LastName = "Ashraf", Position = ".NET intern", HireDate = new DateTime(2022, 2, 1) },
                new Employee { Id = 3, FirstName = "Moaaz", LastName = "Tarek", Position = ".NET intern", HireDate = new DateTime(2024, 3, 1) }
            });
        }


    }
}
