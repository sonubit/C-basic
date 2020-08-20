using System;
using System.Collections.Generic;
using System.Text;

namespace week1Sat
{
    class Overflow
    {
        public Overflow()
        {
            int value = 780000000;
            checked
            {
                try
                {
                    int square = value * value;
                    Console.WriteLine("{0} ^ 2 = {1}", value, square);
                }
                catch (OverflowException)
                {
                    double square = Math.Pow(value, 2);
                    Console.WriteLine("Exception: {0} > {1:E}.",
                                      square, Int32.MaxValue);
                }
            }
        }
    }
}
