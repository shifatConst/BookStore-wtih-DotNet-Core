using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName )
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "MVC", Author = "Shifat", Description= "This is the description of MVC book", Category= "Programming ", Language="English", TotalPages= 134 },
                new BookModel(){Id = 2, Title = "React", Author = "Shifat", Description= "This is the description of React book", Category= "Framwork", Language="English", TotalPages= 120 },
                new BookModel(){Id = 3, Title = "C#", Author = "Rifat", Description= "This is the description of C# book", Category= "Language", Language="Bangla", TotalPages= 55 },
                new BookModel(){Id = 4, Title = "JAVA", Author = "Reza", Description= "This is the description of JAVA book", Category= "Language", Language="Hindi", TotalPages= 98 },
                new BookModel(){Id = 5, Title = "NODE", Author = "Mohian", Description= "This is the description of NODE book", Category= "Runtime", Language="English", TotalPages= 100 },
                new BookModel(){Id = 6, Title = "AI", Author = "Farabi", Description= "This is the description of Farabi book", Category= "Programming", Language="English", TotalPages= 134 },
            };
        }
    }
}
