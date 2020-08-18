using System;
using System.Collections.Generic;
using System.Text;
{

    public sealed class ClassSealedA
    {
        public ClassSealedA()
        {
            Console.WriteLine("Class Sealed we can't inherit");
        }
    }
    class ClassSealed
    {

    }
    class Program1
    {
        static void Main(string[] args)
        {
            ClassSealedA s = new ClassSealedA();

        }
    }
}