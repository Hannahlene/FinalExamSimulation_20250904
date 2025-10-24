using Microsoft.AspNetCore.Mvc;
using FinalExamSimulation_20250904.PartA_Ex_2.Models;

namespace FinalExamSimulation_20250904.PartA_Ex_2.Controllers
{
    public class GradingController : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student { Name = "John" };
            Postgraduate p = new Postgraduate { Name = "Anna" };

            ViewBag.Results = new List<string>
            {
                $"{s.Name}: {s.GetGrade(55)}",   // Pass
                $"{p.Name}: {p.GetGrade(55)}"    // Fail
            };

            return View();
        }
    }
}