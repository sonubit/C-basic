using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program3
    {
        public Program3()
        {
            BackgroundMethod();
            for (int i = 0; i < 5; i++)
            {
               Thread.Sleep(1000);
                Console.WriteLine("::Main::");
            }


            async static void BackgroundMethod()
            {
                void InnerMethod()
                {
                    while (true)
                    {
                        Thread.Sleep(15000);
                        Console.WriteLine("::Background::");
                    }
                }
                var task = new Task(InnerMethod);
                task.Start();
                await task;
            }
        }
    }
}
