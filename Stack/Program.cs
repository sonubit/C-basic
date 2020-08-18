using System;
using System.Collections.Generic;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            var names = new Stack<string>();
            names.Push(" sonu");
            names.Push("raju");
            names.Push("golu");
            names.Push("Irfan");
            while (result)
            {
                Console.WriteLine("1 : show name");
                Console.WriteLine("2 : push name");
                Console.WriteLine("3 : pop name");
                Console.WriteLine("4 : peek ");
                Console.WriteLine("enter the number which mathod you want to call");
                try
                {
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
                        names.Push(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("pop name from the stack ");
                        Console.WriteLine(names.Pop());
                        break;
                    case 4:
                        Console.WriteLine("peek the name from stack ");
                        Console.WriteLine(names.Peek());
                        break;
                    default: result = false; break;


                    }
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
