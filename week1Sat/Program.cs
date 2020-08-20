using System;
using System.Collections;
//System.Data.SqlClient; 


namespace week1Sat
{
    class mainClass
    {
       public static void Main(string[] args)
        {
            OutOfMemory outOf = new OutOfMemory();
            InvalidCast dd = new InvalidCast();
            ArgumentOutOfRange a = new ArgumentOutOfRange();
            DirectoryNotFound d = new DirectoryNotFound();
            Manager m1 = new Manager();
            m1.GetEmployeeData();
            m1.DisplayEmployeeData();

        }
    }
}
