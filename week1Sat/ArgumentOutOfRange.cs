using System;
using System.Collections;

namespace week1Sat
{
    class ArgumentOutOfRange
    {
        public ArgumentOutOfRange()
        {
            try
            {
                ArrayList lis = new ArrayList();
                lis.Add("Geeks");
                lis.Add("GFG");
                Console.WriteLine(lis[2]);
            }
            catch(ArgumentOutOfRangeException are)
            {
                Console.WriteLine(are);
            }
        }
    }
}
