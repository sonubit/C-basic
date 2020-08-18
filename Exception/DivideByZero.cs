using System;


    class DivideByZero
    {
        public DivideByZero()
        {
            int a, b, c;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            try
            {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a / b;
            Console.WriteLine("C VALUE = " + c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Finally block is executed");
            }
        }
    }

