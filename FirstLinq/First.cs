using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstLinq
{
    class First
    {
        public void number()
        {
            int[] numbers = new int[] { 97, 92, 81, 60,1,6,8,9,3,2,4};
             var numberQuery =
                from number in numbers
                where number > 80 //find all number greater than 80 
                select number;
            Console.WriteLine("/n number greater than 80");
            foreach (int i in numberQuery)
            {
                Console.Write(i + " ");
            }
            var lessNumber= from num in numbers
                 where num < 10 // find all number from list number where number is less than 10
                select num;
            Console.WriteLine("/n number less than 10");

            foreach (int j in lessNumber)
            {
                Console.Write(j + " ");
            }

        }


    }
    
}
