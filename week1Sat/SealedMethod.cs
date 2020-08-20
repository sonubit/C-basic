/*using System;
using System.Collections.Generic;
using System.Text;

namespace week1Sat
{
    class SealedMethod
    {
        public  virtual void show()
        {
            Console.WriteLine("parent");
        }
    }
    class SealedMethodA: SealedMethod
    {
        public sealed override void show() 
        {
            Console.WriteLine("parent method sealed there after using sealed keyword in method we can't override");
        }
    }

    class SealedMethodB: SealedMethodA
    {
        public override void show() { }
    }
}
*/