using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<char, string> myDictionary= new MyDictionary<char, string>('A',"Letter A",'B',"Letter B");
            myDictionary.AddEll();
            foreach (KeyValuePair<char,string> item in myDictionary.myDict)
            {
                Console.WriteLine($"{item.Key}   {item.Value}");
            }
            Console.ReadKey();
        }
    }
    class MyDictionary<TKey,TValue>
    {
        public Dictionary<TKey,TValue> myDict = new Dictionary<TKey, TValue>();
        public TKey firstArg { get; set; }
        public TValue firstValue { get; set; }
        public TKey secondArg { get; set; }
        public TValue secondValue { get; set; }
        public MyDictionary(TKey firstArg, TValue firstValue, TKey secondArg, TValue secondValue)
        {
            this.firstArg = firstArg;
            this.firstValue = firstValue;
            this.secondArg = secondArg;
            this.secondValue = secondValue;
        }
        public void AddEll()
        {
            myDict.Add(firstArg, firstValue);
            myDict.Add(secondArg, secondValue);
            Console.WriteLine($"Кількість єлементів myDict = {myDict.Count()}");
        }

        
    }
}
