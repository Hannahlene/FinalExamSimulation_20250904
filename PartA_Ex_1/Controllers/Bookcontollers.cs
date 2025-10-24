using Microsoft.AspNetCore.Mvc;
using FinalExamSimulation_20250904.PartA_Ex_1.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace FinalExamSimulation_20250904.PartA_Ex_1.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>
            {
                new Book { Title = "C# Basics", Author = "John Doe", Price = 25.0f },
                new Book { Title = "ASP.NET Core", Author = "Jane Smith", Price = 30.0f },
                new Book { Title = "OOP Concepts", Author = "Alex Brown", Price = 20.0f }
            };

            return View(books);
        }

        public IActionResult Discount()
        {
            return Discount(10); // default 10%
        }

        [HttpPost]
        public IActionResult Discount(float percent)
        {
            var books = new List<Book>
            {
                new Book { Title = "C# Basics", Author = "John Doe", Price = 25.0f },
                new Book { Title = "ASP.NET Core", Author = "Jane Smith", Price = 30.0f },
                new Book { Title = "OOP Concepts", Author = "Alex Brown", Price = 20.0f }
            };

            foreach (var book in books)
            {
                float oldPrice = book.Price;
                book.Price -= (book.Price * percent / 100);
                Debug.WriteLine($"Book: {book.Title} | Old: {oldPrice} | New: {book.Price}");
            }

            ViewBag.DiscountPercent = percent;
            return View("Index", books);
        }
    }
}