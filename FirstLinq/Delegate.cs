using System;
using System.Collections.Generic;
using System.Text;
delegate int Calculator(int n);
namespace FirstLinq
{
    class Delegate
    {
        static int number = 100;
        public static int add(int n)
        {
            number = number + n;
            return number;
        }
        public static int mul(int n)
        {
            number = number * n;
            return number;
        }
        public static int getNumber()
        {
            return number;
        }
    }
}
