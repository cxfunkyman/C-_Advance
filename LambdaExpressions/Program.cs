/*
 * Lambda Expressions:
 *  Is an anonymous method:
 *      • No access modifier
 *      • No Name
 *      • No return statement
 */

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args) 
        {
            // args => expression
            // args (goes to) expression

            // equivalent method Square
            // number => number * number
            /*
             * () => .....
             * 
             * one arg x =>
             * more than one arg (x, y, z) => .....
             */

//----------------------------------------------------------------------------------
            //Func<int, int> square = Square;
            /*    Func<int, int> square = number => number * number;

                Console.WriteLine(square(5)); */

           /* const int factor = 5;

            Func<int, int> multiplier = n => n * factor;
            var result = multiplier(10);

            Console.WriteLine(result); */

//----------------------------------------------------------------------------------
            // More practical and common use case of lambda expressions
            // Predicate is basically a delegate which point to a method
            // that gets the datatype in this case book, return a boolean
            // whether the requirements are met, example 'Find', 'FindAll'
            // 'FindIndex', 'FindLast', 'FindLastIndex'

            var books = new BookRepository().GetBooks();

            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks) 
            {
                Console.WriteLine(book.Title);
            }

            //Example of predicate

            /*static bool IsCheaperThan10Dollars(Book book)
            {
                return book.Price < 10;
            }*/

            // Change to lambda expression: book => book.Price < 10
        }

        // No need of this code if Lambda expressions are used it
      /*static int Square(int number) 
        {
            return number * number;
        }*/
    }
}