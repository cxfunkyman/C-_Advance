/* What is LinQ?
 *   • Stands for: Language INtegrated Query
 *   • Gives you the capability to query objects
 *  
 *  You can Query:
 *   • Objects in memory, ex Collections (LinQ to Objects)  
 *   • Databases (LinQ to Entities)
 *   • XML (LinQ to XML)
 *   • ADO.NET Data Sets (LinQ to Data Sets)
 */

using System.Linq;

namespace LinQ_new
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // list books cheaper than $10 without using LinQ:
            /* var cheapBooks = new List<Book>();
             foreach (var book in books)
             {
                 if (book.Price < 10)
                     cheapBooks.Add(book);
             }*/

            // LinQ Query Operators
            /* var cheperBooks = 
                                from b in books
                                where b.Price < 10 
                                orderby b.Title 
                                select b.Title; */

            // list books cheaper than $10 using LinQ
            /*var cheapBooks = books
                                    .Where(b => b.Price < 10)
                                    .OrderBy(b => b.Title)
                                    .Select(b => b.Title);


            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
                //Console.WriteLine(book.Title + " $" + book.Price);
            }*/

            // LinQ Extensions
            /*
             * books.Where();
             * 
             * books.Single();
             * books.SingleOrDefault();
             * 
             * books.First();
             * books.FirstOrDefault();
             * 
             * books.Last();
             * books.LastOrDefault();
             * 
             * books.Skip(int).Take(int)
             * 
             * books.Max();
             * books.Min();
             * books.Count();
             * books.Sum();
             * books.Average(); 
             * */

            // Single: must exist one and only one that matches the query
            // if not the program crash:
            //----------------------------------------------------------
            // var book = books.Single(b => b.Title == "ASP.NET MVC");
            // Console.WriteLine(book.Title);

            // if we are notsure if the item exist use:
            //------------------------------------------------------------
            //var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            //Console.WriteLine(book == null);

            // First: take the first element of a collection:
            //------------------------------------------------------------
            //var book = books.First(b => b.Title == "LinQ to Database Basic");
            //Console.WriteLine(book.Title + " $" + book.Price);

            // if we are notsure if the item exist use:
            //------------------------------------------------------------
            //var book = books.FirstOrDefault(b => b.Title == "LinQ to Database Basic");
            //Console.WriteLine(book == null);

            // Last: take the first element of a collection:
            //------------------------------------------------------------
            //var book = books.Last(b => b.Title == "LinQ to Database Basic");
            //Console.WriteLine(book.Title + " $" + book.Price);

            // if we are notsure if the item exist use:
            //------------------------------------------------------------
            //var book = books.LastOrDefault(b => b.Title == "LinQ to Database Basic");
            //Console.WriteLine(book.Title + " $" + book.Price);
            //Console.WriteLine(book == null);

            // Skip and Take used for paging data
            //-------------------------------------------------------------
            /*var pagedBooks = books.Skip(5).Take(6);

            foreach (var pagedBook in pagedBooks) 
            {
                Console.WriteLine(pagedBook.Title + " $" + pagedBook.Price);
            }*/

            //Count: returns the number of items in the collection
            //----------------------------------------------------------
            //var countedBooks = books.Count();
            //Console.WriteLine(countedBooks);

            //Max: return the maximum value of the item type
            //Min: return the minimum value of the item type
            //Sum: return the sum value of the item type
            //-----------------------------------------------------------
            var maxPriceBooks = books.Max(b => b.Price);
            var minPriceBooks = books.Min(b => b.Price);
            var sumPriceBooks = books.Sum(b => b.Price);
            var averagePriceBooks = books.Average(b => b.Price);
            Console.WriteLine("Max price $" + maxPriceBooks);
            Console.WriteLine("Min price $" + minPriceBooks);
            Console.WriteLine("Sum price $" + sumPriceBooks);
            Console.WriteLine("Ave price $" + averagePriceBooks);

        }
    }
}

