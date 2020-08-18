using System;

namespace Bank
{
    class Overriding
    {
        public virtual void show()
        {
            Console.WriteLine("parent class show method");
        }
    }
    class OverringChild : Overriding
    {
        public override void show()
        {
            Console.WriteLine("child class override show method");
        }
    }
}
