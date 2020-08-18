﻿using System;
using System.IO;
using System.Threading.Tasks;

namespace Week2Sat
{
    class ProgramFileReader
    {

        public ProgramFileReader()
        {
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
        }
        static async void CallMethod()
        {
            string filePath = "C:\\Users\\sonu\\Desktop\\TaskAsync.txt";
            Task<int> task = ReadFile(filePath);

            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");

            int length = await task;
            Console.WriteLine(" Total length: " + length);

            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");
        }

        static async Task<int> ReadFile(string file)
        {
            int length = 0;

            Console.WriteLine(" File reading is stating");
            using (StreamReader reader = new StreamReader(file))
            {
                string s = await reader.ReadToEndAsync();

                length = s.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }
    }
}
