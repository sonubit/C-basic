using System;
using System.IO;

namespace FileHandling
{
    class FileHandlingMain
    {
        public static void Main(string[] args)
        {
            FileStreamWriter file = new FileStreamWriter();
            bool handler = true;
            while (handler)
            {
                Console.WriteLine("1 :create file");
                Console.WriteLine("2 :write new line");
                Console.WriteLine("3 :write in same line");
                Console.WriteLine("4 :binary writer");
                Console.WriteLine("5 :binary reader");
                Console.WriteLine("enter any number");
                int btn = Convert.ToInt32(Console.ReadLine());
                switch (btn)
                {
                    case 1:file.Create(); break;
                    case 2:file.WriteNewLine(); break;
                    case 3: file.WriteInSameLine(); break;
                    case 4: BinaryReaderWriter.WriteBinaryFile(); break;
                    case 5: BinaryReaderWriter.ReadBinaryFile(); break;
                    default: handler = false; break;
                }
            }
        }
    }
}
