using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.CompilerServices;
using 


namespace ConcoleTasks
{
     void Foo(object a)
    {
        Console.WriteLine("object");
    }
     void Foo(object a, object b)
    {
        Console.WriteLine("object, object");
    }
     void Foo(params object[] args)
    {
        Console.WriteLine("params object");
    }
     void Foo<T>(params T[] args)
    {
        Console.WriteLine("params t[]");
    }
    class Bar { }
    internal class Program
    {

        static void Main(string[] args)
        {
            Foo();
            Foo(null);
            Foo(new Bar());
            Foo(new Bar(), new Bar());
            Foo(new Bar(), new object());
        }

      
  
        
    }
}
