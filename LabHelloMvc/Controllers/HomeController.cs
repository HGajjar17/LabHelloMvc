using System.Diagnostics;
using LabHelloMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabHelloMvc.Controllers
{
    public class HomeController : Controller
    {
        // Constructor
        public HomeController()
        {
           
        }

        // Home page ../Home/Index
        public IActionResult Index()
        {
            // Create a new Person object
            //List<Person> people = new List<Person>();

            // Create person objects
            Person Person1 = new Person();
            {
                Person1.PersonId = 1;
                Person1.FirstName = "Hiren";
                Person1.LastName = "Gajjar";
                Person1.PhoneNumber = 902222807;
                Person1.Email = "cs.hirengajjar@gmail.com";
            }

            //Person.Add(Person1);
            return View(Person1);
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
