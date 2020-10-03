using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello from Controller";
        //}
        public ViewResult Index()
        {
            var obj = new { Id = 1, Name = "Soumya" };
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
        
    }
}
