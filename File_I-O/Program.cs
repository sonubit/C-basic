using System;

namespace File_I_O
{
    class Program
    {
      public  static void Main(string[] args)
        {
            FileIO fileObj = new FileIO();
            bool handler = true;
            while (handler)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------- ");
                Console.WriteLine("1. check File path correct or not ");
                Console.WriteLine("2. read all text in your file using readallline");
                Console.WriteLine("3. read all text in your file using readalltext ");
                Console.WriteLine("4. copy text one to other file ");
                Console.WriteLine("5. Move text one to other file ");
                Console.WriteLine("6. delete file");
                Console.WriteLine("7. clear screen");
                Console.WriteLine("8. streamReader ");
                Console.WriteLine("9. streamWriter ");
                Console.WriteLine("10.create new File ");
                Console.WriteLine("   enter any number");
                int btn = Convert.ToInt32(Console.ReadLine());
                switch(btn)
                {
                    case 1: fileObj.CheckFilePath(); break;
                    case 2: fileObj.FileReaadAllLines(); break;
                    case 3: fileObj.FileReaadAllText(); break;
                    case 4: fileObj.FileCopy(); break;
                    case 5: fileObj.FileMove(); break;
                    case 6: fileObj.FileDelete(); break;
                    case 7: Console.Clear(); break;
                    case 8: fileObj.FileStreamReader(); break;
                    case 9: fileObj.FileStreamWriter(); break;
                    case 10:fileObj.FileCreate(); break;
                    default: handler = false; break;
                }


            }
        }
    }
}
