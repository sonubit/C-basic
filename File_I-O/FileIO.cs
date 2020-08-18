using System;
using System.IO;

namespace File_I_O
{
    class FileIO
    {

        public void CheckFilePath()
        {
            Console.WriteLine("enter your file Path");
      
            string file_Path=Console.ReadLine();
           if( File.Exists(file_Path))
            {
                Console.WriteLine("correct path");
            }
            else
            {
                Console.WriteLine("wrong  file path");
            }
        }

        public void FileReaadAllLines()
        {
            Console.WriteLine("enter your file Path");
            string file_Path = Console.ReadLine();
            String[] lines;
            if (File.Exists(file_Path))
            {
                lines = File.ReadAllLines(file_Path);

                for (int i=0; lines.Length>i ; i++)
                {
                    Console.WriteLine(lines[i]);
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("wrong  file path");
            }
        }
        public void FileReaadAllText()
        {
            Console.WriteLine("enter your file Path");
            string file_Path = Console.ReadLine();
            string lines;
            if (File.Exists(file_Path))
            {
                lines = File.ReadAllText(file_Path);
                Console.WriteLine(lines);
                
            }
            else
            {
                Console.WriteLine("wrong  file path");
            }
        }

        public void FileCopy()
        {
            Console.WriteLine("enter your old file Path");
            string old_Path = Console.ReadLine();
            Console.WriteLine("enter your new file Path");
            string new_Path = Console.ReadLine();
            if (File.Exists(old_Path) && File.Exists(new_Path))
            {
                File.Copy(old_Path,new_Path,true);
                Console.WriteLine("copy file ");

            }
            else
            {
                Console.WriteLine("wrong  file path");
            }
        }

        public void FileDelete()
        {
            Console.WriteLine("enter your file Path");
            string file_Path = Console.ReadLine();
            if (File.Exists(file_Path))
            {
                File.Delete(file_Path);
                Console.WriteLine("file deleted");

            }
            else
            {
                Console.WriteLine("wrong  file path");
            }
        }

        public void FileMove()
        {
            Console.WriteLine("enter your old file Path");
            string old_Path = Console.ReadLine();
            Console.WriteLine("enter your new file Path");
            string new_Path = Console.ReadLine();
            if (File.Exists(old_Path) && File.Exists(new_Path))
            {
                File.Move(old_Path, new_Path, true);
                Console.WriteLine("move file ");

            }
            else
            {
                Console.WriteLine("wrong  file path");
            }
        }


        public void FileStreamReader()
        {
            Console.WriteLine("enter your file Path");
            string file_Path = Console.ReadLine();
            if (File.Exists(file_Path))
            {
                using (StreamReader streamReaderObje = File.OpenText(file_Path))
                {
                    string s = "";
                    while ((s = streamReaderObje.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }

                }
            }
            else
            {
                Console.WriteLine("wrong  file path");
            }
        }
        public void FileStreamWriter()
        {
            Console.WriteLine("enter your file Path");
            string file_Path = Console.ReadLine();
            if (File.Exists(file_Path))
            {
                using (StreamWriter streamWriterObj = File.AppendText(file_Path))
                {
                    Console.WriteLine("enter text here to write in your file");
                    string text = Console.ReadLine();
                    streamWriterObj.WriteLine(text);
                    streamWriterObj.Close();
                    Console.WriteLine(File.ReadAllText(file_Path));
                }
            }
            else
            {
                Console.WriteLine("wrong  file path");
            }
        }

        public void FileCreate()
        {
            try
            {
                Console.WriteLine("enter location where you want to create file ");
                string loc = Console.ReadLine();
                FileInfo file = new FileInfo(loc);
                file.Create();
                Console.WriteLine("File created ");
            }
            catch (IOException e)
            {
                Console.WriteLine("Something  wrong: " +e);
            }
        }
    }
}
