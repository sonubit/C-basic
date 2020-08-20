using System;
using System.IO;

namespace FileHandling
{
    class BinaryReaderWriter
    {
        public static void WriteBinaryFile()
        {
            Console.WriteLine("enter file path");
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    bool handler = true;
                    while (handler)
                    {
                        Console.WriteLine("1 :store int value");
                        Console.WriteLine("2 :store string value");
                        Console.WriteLine("3 :store bool value");
                        Console.WriteLine("enter any number");
                        int btn = Convert.ToInt32(Console.ReadLine());
                        switch (btn)
                        {
                            case 1:
                                Console.WriteLine("enter any number to store in our file");
                                writer.Write(Convert.ToDouble(Console.ReadLine()));
                                writer.Write("\n");
                                    break;
                            case 2:
                                Console.WriteLine("enter some thing  to store in our file");
                                writer.Write(Console.ReadLine());
                                writer.Write("\n"); 
                                break;
                            case 3:writer.Write(true);
                                writer.Write("\n"); 
                                break;
                            default:handler=false; break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("enter correct path");
            }
        }
        public static void ReadBinaryFile()
        {
            Console.WriteLine("enter file path");
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {

                    bool handler = true;
                    while (handler)
                    {
                        Console.WriteLine("1 :read int value");
                        Console.WriteLine("2 :read string value");
                        Console.WriteLine("3 :read bool value");
                        Console.WriteLine("enter any number");
                        int btn = Convert.ToInt32(Console.ReadLine());
                        switch (btn)
                        {
                            case 1:
                                try
                                {
                                    Console.WriteLine("Double Value : " + reader.ReadDouble());
                                }
                                catch(EndOfStreamException eos)
                                {
                                    Console.WriteLine(eos);
                                }
                                break;
                            case 2:
                                try
                                {
                                    Console.WriteLine("String Value : " + reader.ReadString());
                                }
                                catch(EndOfStreamException eos)
                                {
                                    Console.WriteLine(eos);
                                }
                                break;
                            case 3:
                                try
                                {
                                    Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
                                }
                                catch(EndOfStreamException eos)
                                {
                                    Console.WriteLine(eos);
                                }
                                break;
                            default: handler = false;   break;
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("enter correct path");
            }
        }

    }
}
