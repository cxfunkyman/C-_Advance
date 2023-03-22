using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class BookList
    {
        public void add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    //simple way of doing the process but has performance penalties
 
    /*   public class ObjectList
    {
        public void add(Object value) 
        { 

        }
        public object this[int index] 
        {
            get { throw new NotImplementedException(); }
        }
    }*/

    //Use of generics, better performance and usabilities
    //use differents generic list types

    public class GenericDictionary<TKey, TValue>
    {
        public void add(TKey key, TValue value) 
        {
        
        }
    }

    public class GenericList<T>
    {
        public void add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
