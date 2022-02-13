using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            string[] lList = new string[] { "Odessa", "Lviv", "Dnipro", "Kyiv" };
            myList.AddMethod(lList);
            Console.WriteLine();
            foreach (var item in myList.arraList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Другий єл. arraList = {myList[2]}");
            Console.ReadKey();
        }
    }
    class MyList<T>
    {
        public List<T> arraList = new List<T>();
        public T this[int index]
        {
            get { return arraList[index]; }
        }
        public void AddMethod( T [] massive)
        {
           arraList.AddRange(massive);
            Console.WriteLine($"Кількість єлементів arrayList = {arraList.Count()}");
        }
       
    }
}
