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
                new BookModel(){Id=1,Title="MVC",Author="Soumya",Description="This is MVC",Category="WebApp",TotalPages=300,Language="English"},
                new BookModel(){Id=2,Title="C#",Author="Prasant",Description="This is C#",Category="Programming",TotalPages=500,Language="English"},
                new BookModel(){Id=3,Title="Core",Author="Kabita",Description="This is Core",Category="Framework",TotalPages=200,Language="English"},
                new BookModel(){Id=4,Title="ASP",Author="Litu",Description="This is ASP",Category="WebAppOld",TotalPages=300,Language="English"},
                new BookModel(){Id=5,Title="Java",Author="Monu",Description="This is Java",Category="Program",TotalPages=600,Language="English"}
            };
        }
    }
}
