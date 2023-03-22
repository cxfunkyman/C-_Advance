//Delegates is a reference or pointer to a function
//Delegates is an object that knows howto call a method or group of methods, Areference to a function
//Why use it?
//allows us to create applications that are extensible and flexible. (eg Framworks)
//Alternative: Interfaces
//When to use?
//When an eventing desing pattern is used
//The caller doesn't need to access other properties or methods on the object implementing the method

using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;            
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");

        }
    }
}
