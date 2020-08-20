using System;
using System.Collections.Generic;
using System.Text;

namespace week1Sat
{
    class InvalidCast
    {
        public InvalidCast()
        {
            bool flag = true;
            try
            {
                Char ch = Convert.ToChar(flag);
                Console.WriteLine("Conversion succeeded.");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Cannot convert a Boolean to a Char.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
