using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreTrainingProject.Models;

namespace NetCoreTrainingProject.Controllers
{
    public class BookController : Controller
    {
        List<Book> _books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Author = "Моби Дик",
                ISBN = "9785367014853",
                Title = "Герман Мелвилл"
            },
            new Book
            {
                Id = 2,
                Author = "Жюль Верн",
                ISBN = "9785992226133",
                Title = "Вокруг света за 80 дней"
            }
        };


        // GET: /book/
        public IActionResult Index()
        {
            return View(_books);
        }

        // GET: /book/details/{id}
        public IActionResult Details(int id)
        {
            Book book = _books.FirstOrDefault(x => x.Id == id);
            
            if (book == null)
                return NotFound();

            return View(book);
        }
    }
}