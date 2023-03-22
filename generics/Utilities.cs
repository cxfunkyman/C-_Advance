using System;


//5 types of constraint
/* -----------------------
 * where T : IComparable
 * where T : Product
 * where T : Struct
 * where T : class
 * where T : new() //object that has a default constructor
   ----------------------- */
namespace Generics
{
    //Is not necesary to start with a generic class to use generic
    /*public class Utilities
    {
        //Normal version
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //Generic version, with applied constraint
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

    }*/

    //another example starting with generic class
    public class Utilities<T> where T : IComparable, new()
    {
        //Generic version, with applied constraint
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(Task value)
        {
            //To instantiate T you need a constractor, because we don't know the data type
            //and set another constraint
            var obj = new T();

        }
    }
}
