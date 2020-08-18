using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program1
    {
        public Program1()
        {
            Console.WriteLine("Main Thread :Statred");
            Task task1 = new Task(PrintCounter);
            task1.Wait(5000);
            task1.Start();
            //task1.Start();//throw invalidOperationException 
            Console.WriteLine("Main Thread :  Completed");
            Console.ReadKey();
        }
         static void PrintCounter()
        {
            Console.WriteLine("Child Thread : Started");
            for (int count = 1; count <= 5; count++)
            {
                Console.WriteLine($"count value: {count}");
            }
            Console.WriteLine("Child Thread : Completed");
        }
    }
}
