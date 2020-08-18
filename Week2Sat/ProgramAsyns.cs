using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Week2Sat
{
    class ProgramAsyns
    {

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }
    }

}
