using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileHandling
{
    class FileStreamWriter
    {
        public void Create()
        {
            try
            {
                Console.WriteLine("enter  path");
                string path = Console.ReadLine();
                FileStream f = new FileStream(path, FileMode.Create);
                StreamWriter s = new StreamWriter(f);

                s.WriteLine("hello c#");
                s.Close();
                f.Close();
            }
            catch(IOException e)
            {
                Console.WriteLine(e);
            }
           
            Console.WriteLine("File created");
        }

        public void WriteNewLine()
        {
            try
            {
                Console.WriteLine("enter  path");
                string path = Console.ReadLine();
                FileStream f = new FileStream(path, FileMode.Open);
                StreamWriter s = new StreamWriter(f);
                Console.WriteLine("write some thing to add new line in your file ");
                string newline=Console.ReadLine();
                s.WriteLine(newline);
                s.Close();
                f.Close();
            }
            catch(FileNotFoundException fnf)
            {
                Console.WriteLine("enter correct path" + fnf);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }

        public void WriteInSameLine()
        {
            try
            {
                Console.WriteLine("enter  path");
                string path = Console.ReadLine();
                FileStream f = new FileStream(path, FileMode.Open);
                StreamWriter s = new StreamWriter(f);
                Console.WriteLine("write some thing to add new line in your file ");
                string newline = Console.ReadLine();
                s.Write(newline);
                s.Close();
                f.Close();
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine("enter correct path" + fnf);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
