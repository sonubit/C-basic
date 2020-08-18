using System;
using System.Collections.Generic;
namespace Week2Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            var names = new List<string>();
            names.Add(" sonu");
            names.Add("raju");
            names.Add("golu");
            names.Add("Irfan");
            names.Remove("raju");
            while (result)
            {
                
                Console.WriteLine("enter the number which mathod you want to call");
                Console.WriteLine("1 : show name");
                Console.WriteLine("2 : add name");
                Console.WriteLine("3 : Remove name");
                Console.WriteLine("4 : Remove name by index location");


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
                        names.Add(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("enter any name here ");
                        names.Remove(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("enter index location which which you want to remove ");
                        names.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                        break;

                    default: result=false ; break;


                }
            }
        }
    }
}
