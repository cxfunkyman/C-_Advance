// Dynamic Binding
/*
 *  Programming Languages are divided into:
 *      • Statically-type languages: C#, Java
 *      • Dynamically-typed languages: Ruby, JavaScript, Python
 *  
 *  Type Resolution
 *      • Static labguages: at compile-time
 *      • Dynimic languages: at run-time
 *      
 *  Benefits
 *      • Static languages: early feedback (compile-time)
 *      • Dynimic languages: easier and faster to code
 *  
 *  Reflection
 *      • A way to inspect the metadata about the type
 *      • and access properties and methods
 */
namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args) 
        {
            object obj = "HelloWorld";
            obj.GetHashCode();

            // With reflection the code will end up looking like this

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);
            //--------------------------------------------------------

            // Compile-time error example
            //object exelObject = "HelloWorld";
            //exelObject.Optimize();            
            
            dynamic exelObject = "HelloWorld";
            exelObject.Optimize();
            //--------------------------------------------------------

            dynamic name = "HelloWorld";
            name = 10;

            // With dynamic is conversions or casts
            // you get implicit conversion from and to the target type
            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;

            int i = 5;
            dynamic d = i;
            long k = d;


        }
    }
}

