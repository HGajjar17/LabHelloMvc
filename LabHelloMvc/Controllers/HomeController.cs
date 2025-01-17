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
            Person Person1 = new Person()
            {
                PersonId = 1,
                FirstName = "Hiren",
                LastName = "Gajjar",
                PhoneNumber = 902222807,
                Email = "cs.hirengajjar@gmail.com"
            };

            //Person.Add(Person1);
            return View(Person1);
        }

        // Display a person by id - ../home/DisplayPerson/id

        public IActionResult DisplayPerson(int id)
        {
            // Create a new Person object
            Person Person1 = new Person()
            {
                PersonId = id,
                FirstName = "Rajendra",
                LastName = "Gajjar",
                PhoneNumber = 942830418,
                Email = "raj.mahindra@gmail.com"
            };

            return View(Person1);
        }

        // Privacy Page - ../Home/Privacy/
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
