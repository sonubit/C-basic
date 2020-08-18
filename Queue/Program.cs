using System;
using System.Collections.Generic;
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            var names = new Queue<string>();
            names.Enqueue(" sonu");
            names.Enqueue("raju");
            names.Enqueue("golu");
            names.Enqueue("Irfan");
            while (result)
            {
                Console.WriteLine("enter the number which mathod you want to call");
                Console.WriteLine("1 : show name");
                Console.WriteLine("2 : add name");
                Console.WriteLine("3 : Remove name");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.Clear();
                        foreach (var name in names)
                        {

                            Console.WriteLine(name);
                        }
                        break;
                    case 2:
                        Console.WriteLine("enter any name here ");
                        names.Enqueue(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine(names.Dequeue());  
                        break;

                    default: result = false; break;


                }
            }
        }
    }
}
