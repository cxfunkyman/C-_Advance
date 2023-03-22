using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
            
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        { 
            get { return _value != null; }
        }
        public T GetValueOrDefaault() 
        {
            if(HasValue) 
            { 
                return (T)_value;
            }
            //if is not set, it's value is nulll, use default keyword
            return default(T);
        }
    }
}
