using System;
using System.IO;
using System.Threading.Tasks;

namespace Week2Fri
{
    class program2Asyns
    {
        public void Start()
        {
            Task<int> task = HandleFileAsync();
            Console.WriteLine("Please wait patiently " + "while I do something important.");
         
            task.Wait();
            var x = task.Result;
            Console.WriteLine("Count: " + x);
            Console.WriteLine("[DONE]");
            Console.ReadLine();
        }
        static async Task<int> HandleFileAsync()
        {
            string file = @"C:\Users\sonu\Desktop\Testing.txt";
              Console.WriteLine("HandleFile enter");
            int count = 0;
            using (StreamReader reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();
                count += v.Length;               
            }
            Console.WriteLine("HandleFile exit");
            return count;
        }
    }
}
