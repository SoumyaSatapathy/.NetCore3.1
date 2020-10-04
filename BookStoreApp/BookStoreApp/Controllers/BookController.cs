using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Models;
using BookStoreApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Controllers
{
    public class BookController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        //public List<BookModel> GetallBooks()
        //{
        //    return _bookRepository.GetAllBooks();
        //}
        public ViewResult GetallBooks()
        {
            var data = _bookRepository.GetAllBooks();

            return View(data);
        }
        public ViewResult GetBook(int id,string name)
        {
            var data = _bookRepository.GetBookById(id);
            return View(data);
        }
        public List<BookModel> SearchBook(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}