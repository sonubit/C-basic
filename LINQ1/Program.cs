using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<Employee> objEmp = new List<Employee>();

            objEmp.Add(new Employee { EmpId=1,Name = "golu", Location="bihar" });
            objEmp.Add(new Employee { EmpId=2,Name = "saddam", Location="bihar" });
            objEmp.Add(new Employee { EmpId=3,Name = "raju", Location="bhopal" });
            objEmp.Add(new Employee { EmpId=4,Name = "Preeti", Location ="bhopal"});
            objEmp.Add(new Employee { EmpId=5,Name = "sailesh", Location ="banglore"});
            objEmp.Add(new Employee { EmpId=6,Name = "ritesh", Location ="banglore"});
            objEmp.Add(new Employee { EmpId=7,Name="sonu",Location="bihar"});
            var result = from e in objEmp
                         where e.Location.Equals("banglore")
                         select new
                         {
                             EmpId =e.EmpId,
                             Name = e.Name,
                             Location = e.Location
                         };
          foreach (var item in result)
            {
                Console.WriteLine(item.EmpId+" \t |"+item.Name + "\t  | " + item.Location);
            }
            Console.ReadLine();
        }
}
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
