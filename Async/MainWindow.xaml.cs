using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
 *  Asynchronous Program Execution and Synchronous Program Execution
 *  
 *  Synchronous Program Execution
 *      • Program is executed line by line, one at a time
 *      • When a function is called, program execution has to wait until
 *        the function returns
 *  
 *  Asynchronous Program Execution
 *      • When a function is called, program execution continues to the
 *        next line,  WITHOUT waiting for the function to complete
 *      • Improves responsiveness
 *  
 *  When to use Asynchronous:
 *      • Accessing the web
 *      • Working with files and Databases
 *      • Working with images
 *      
 *  How?
 *      Traditional approaches:
 *          • Multi-threading
 *          • Callbacks
 *      
 *      New approach since NET 4.5 (Tasked wait asynchronous model):
 *          • Async / Await
 */

namespace Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //SyncDownloadHtml("http://msdn.microsoft.com");
            DownloadHtmlAsync("http://msdn.microsoft.com");

            //var html = GetHtml("http://msdn.microsoft.com");
            //MessageBox.Show(html.Substring(0, 10));             
            
            var html = await GetHtmlAsync("http://msdn.microsoft.com");
            MessageBox.Show(html.Substring(0, 10));
        }

        // Asynchronous version
        // use task with void methods, generic task with non void methods

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }


        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"D:\projects\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        // Synchronous version.
        public void SyncDownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"D:\projects\result.html"))
            {
                streamWriter.Write(html);
            }
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }
    }
}
