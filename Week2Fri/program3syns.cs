using System;
using System.IO;
namespace Week2Fri
{
    class program3syns
    {
        public void Start()
        {
            Console.WriteLine("Start main");
            Console.WriteLine( Count ());
            Console.WriteLine("end main");
        }
            static int Count()
        {
            Console.WriteLine("Start counting");
            string file = @"C:\Users\sonu\Desktop\Testing.txt";
            Console.WriteLine("HandleFile enter");
            int count = 0;
            StreamReader reader = new StreamReader(file);
            string v = reader.ReadToEnd();
            count += v.Length;
            return count;
        }
    }
}
