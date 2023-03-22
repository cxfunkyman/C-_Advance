using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * System.Action points to a method with no parameters and returns void
 * System.Func points to a method with parameters and return value
 */

namespace Delegates
{
    public class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
