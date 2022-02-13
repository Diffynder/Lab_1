using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vars = SomeClass<int>.FactoryMethod();
            Console.WriteLine(vars.Item1.GetType().Name);
        }
    }
    class SomeClass<T>
   where T : new()
    {
        public static (T, T) FactoryMethod()
        {
            return (new T(), new T());
        }
    }
}

