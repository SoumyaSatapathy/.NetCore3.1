using BookStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Soumya"},
                new BookModel(){Id=2,Title="C#",Author="Prasant"},
                new BookModel(){Id=3,Title="Core",Author="Kabita"},
                new BookModel(){Id=4,Title="ASP",Author="Litu"},
                new BookModel(){Id=5,Title="Java",Author="Monu"}
            };
        }
    }
}
