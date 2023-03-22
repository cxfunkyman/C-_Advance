/* Extension Methods
 * Allow usto add methods to an existing class without
 *  • Changing its source code
 *  • Creating a new class that inherits from it
 */

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args) 
        {
            string post = "This is supposed to be a very long long blog post submited and posted";

            // To create an extension method, you need to create a static class for convention
            //
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
        }
    }

}
