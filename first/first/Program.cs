using System;

namespace first
{
  
    class Program
    {
        static void Main(string[] args)
        {
            StatementIfElse Check = new StatementIfElse();
            Console.WriteLine("enter your age ");
            int x = Convert.ToInt32(Console.ReadLine());
            Check.ageCheck(x);
            Check.days(4);
            Check.for_loop();
            Check.while_loop();
        }
    }
   
}
