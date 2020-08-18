using System;
using System.Collections.Generic;
namespace Linq
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.id = 1;
            p.name = "sonu";
            p.salary = 8000;
            Person p1 = new Person();
            p1.id = 2;
            p1.name = "golu";
            p1.salary = 9000;
            Person p2 = new Person();
            p2.id = 3;
            p2.name = "golu";
            p2.salary = 10000;
            Person p3 = new Person();
            p3.id = 4;
            p3.name = "sadu";
            p3.salary = 12000;
            Dictionary<int, Person> DP = new Dictionary<int, Person>();
            //
            //add the data into the key value pair 
            DP.Add(p.id, p);
            DP.Add(p1.id, p1);
            DP.Add(p2.id, p2);
            DP.Add(p3.id, p3);
            Person id2 = DP[2];
            //count the total dictionary list
            Console.WriteLine("total " + DP.Count);
            //if i want to delete all the from the dictionary 
            /*DP.Clear();*/
           /* Console.WriteLine("id={0}, name={1}, salary={2}", id2.id, id2.name, id2.salary);*/
            foreach (KeyValuePair<int, Person> keypair in DP)
            {
                Console.WriteLine("id={0}", keypair.Key);
                Person kp=keypair.Value;
                Console.WriteLine("id={0}, name={1}, salary={2}", kp.id, kp.name, kp.salary);
            }
            //search the value using the key value 
            Person result;
            Console.WriteLine("enter any key to find the data");
            int key = Convert.ToInt32(Console.ReadLine());
            if (DP.TryGetValue(key, out result))
            {
                Console.WriteLine("id={0}, name={1}, salary={2}", result.id, result.name, result.salary);
            }
            else
            {
                Console.WriteLine("key not found");
            }

            
        }
    }
}
