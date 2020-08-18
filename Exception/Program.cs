using System;
using System.IO;

    
    class Program
    { 
     static void fileNot()
    {
        try
        {
            FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate);
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.ToString());
        }

    }
    static void Main(string[] args)
        {
        //user define Exception
        Program.fileNot()
        AgeCheck age = new AgeCheck();
        try
        {
            Console.WriteLine("enter your age");
            age.validate(Convert.ToInt32(Console.ReadLine()));
        }
        catch (InvalidAgeException e)
        {
            Console.WriteLine(e); 
        }
        // try catch finally keywords
        DivideByZero d = new DivideByZero();
        //try catch
        IndexOutOfRange i = new IndexOutOfRange();
        /*int a= 10;
        int b = 0;
        int x = a / b;
        Console.WriteLine(x);
        Console.WriteLine("hi");*/
        }
    }

