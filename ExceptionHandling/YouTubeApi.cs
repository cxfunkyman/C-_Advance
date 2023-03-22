using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                /*
                 * Access Youtube web service
                 * Read the data
                 * Create a list of video objects
                 */
                throw new Exception("Oops some low level YouTube error.");
            }
            catch (Exception ex) 
            {
                throw new YouTubeException("Could not fetch the video from Youtube", ex);
            }

            return new List<Video>();
        }
    }
}
