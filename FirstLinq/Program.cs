using System;

namespace FirstLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderBy ob = new OrderBy();
            AggregationFunction a = new AggregationFunction();
            a.numlist();
            a.stringlist();
            First firstObject = new First();
            firstObject.number();
            Console.WriteLine();
            //delegate
            Calculator c = new Calculator(Delegate.add); 
            c(20);
            Console.WriteLine(Delegate.getNumber());
            Calculator c1 = new Calculator(Delegate.mul);
            c1(30);
            Console.WriteLine(Delegate.getNumber());
        }
    }
}
