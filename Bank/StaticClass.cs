using System;

namespace Bank
{
    class StaticClass
    {
         public StaticClass( int s)
        {
            Console.WriteLine("static constructor is called"+ s);
        }
        //public StaticClass()
        //{
        //    Console.WriteLine("non-static constructor is called");
        //}
    }

    //methodloading
    class MethodOverloading
        {
        public void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
        public void add(int a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
    }
}
