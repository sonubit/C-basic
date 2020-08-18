using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Week2Fri
{
    class ProgramAsyns
    {
        public void Start()
        {
            Console.WriteLine("start main 1");
            Task<int> result = add();
            Console.WriteLine("again main method running");
            Console.WriteLine("length: {0}", result.Result);
        }
        async static Task<int> add()
        {
            Console.WriteLine("enter in add method");
            Task<string> TaskUrl = new HttpClient().GetStringAsync("https://visur.one/");
            string result = await TaskUrl;
            Console.WriteLine("child 2");
            return result.Length;
        }
    }
}
