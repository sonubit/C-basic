using System;
using System.Linq;

namespace FirstLinq
{
    class AggregationFunction
    {
        int[] num = { 1, 8, 3, 2, 3, 7, 9, 4, 6 };
        
        public void numlist()
        {
            Console.WriteLine("aggreate function");
            Console.WriteLine("minimum number  = "+num.Min());
            Console.WriteLine("max number  = " + num.Max());
            Console.WriteLine("sum number  = " + num.Sum());
            Console.WriteLine("average  = " + num.Average());
            Console.WriteLine("using aggreate function *  = " + num.Aggregate((a,b)=>a*b));
            Console.WriteLine("using overloaded aggreate function * take one more parameter that called seed  = " + num.Aggregate(10,(a,b)=>a*b));
        }
        string[] names = { "topa", "golu", "saddam", "motu", "an" };
        public void stringlist()
        {
            Console.WriteLine("aggreate function");
            Console.WriteLine("minimum number of name  = " + names.Min(x=> x.Length));
            Console.WriteLine("max number of name  = " + names.Max(x=>x.Length));
            Console.WriteLine("all string array list convert into one string using aggreate function ");
            Console.WriteLine(names.Aggregate((a,b) => a +","+b));
        }
    }
}
