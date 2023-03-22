using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_new
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO.Net Step by Step", Price = 5 },
                new Book() {Title = "ASP.NET MVC", Price = 9.99f },
                new Book() {Title = "ASP.NET Web API", Price = 12 },
                new Book() {Title = "C# Advance Topics", Price = 7 },
                new Book() {Title = "LinQ to Database Basic", Price = 9 },
                new Book() {Title = "LinQ to Database Basic", Price = 11.52f },
                new Book() {Title = "PHP Basic", Price = 16 },
                new Book() {Title = "Java for Dummies", Price = 27 },
                new Book() {Title = "JavaScript Intermediate", Price = 21 },
                new Book() {Title = "LinQ to Data Sets (ADO.NET) Basic", Price = 33 },
                new Book() {Title = "LinQ to Objects Basic", Price = 39 }
            };
        }
    }
}
