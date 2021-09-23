using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string MyProperty { get; set; }
        [ViewData]
        public string Title { get; set; }

        [ViewData]
        public BookModel Book{ get; set; }
        public ViewResult Index()
        {
            MyProperty = "SHIFAT";
            Title = "Home";
            Book = new BookModel() { Title = "System Design", Author = "Rony" };
            return View();
        }

        public ViewResult AboutUs()
        {
            Title = "About Us";
            return View();
        }

        public ViewResult ContactUs()
        {
            Title = "Contact Us";
            return View();
        }
    }
}
