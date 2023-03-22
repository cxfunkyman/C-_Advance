



namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args) 
        {
            try
            {
                var calc = new Calculator();
                var result = calc.Divide(5, 0);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Sorry, an unexpected error ocurred");
                Console.WriteLine("Division by Zero not accepted!!");
                //Console.WriteLine(ex);
            }
            finally 
            { 
                Console.WriteLine("Finally Block\n"); 
            }

            StreamReader streamReader = null;
            
            try
            {
                streamReader = new StreamReader(@"C:\file.zip");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error ocurred");
                //Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally Block\n");
                
                if (streamReader != null)
                streamReader.Dispose();
            }

            try
            {
                using (var strReader = new StreamReader(@"C:\file.zip"))
                {
                    var result = strReader.ReadToEnd();
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error ocurred\n");
                //Console.WriteLine(ex);
            }


            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Batman");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex);
            }

        }
    }
}
