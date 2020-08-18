using System;
using System.Linq;
using System.Collections.Generic;


public class OrderBy
{
	public void order()
	{
				var studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "golu", Age = 18 } ,
				new Student() { StudentID = 2, StudentName = "sonu",  Age = 15 } ,
				new Student() { StudentID = 3, StudentName = "raju",  Age = 25 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
				new Student() { StudentID = 5, StudentName = "mohan" , Age = 19 }
			};

		var orderByResult = from s in studentList
							orderby s.StudentName //Sorts the studentList collection in ascending order
							select s;

		var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
									  orderby s.StudentName descending
									  select s;

		Console.WriteLine("Ascending Order:");

		foreach (var std in orderByResult)
		{
			Console.WriteLine(std.StudentName);
		}
		Console.WriteLine("Descending Order:");

		foreach (var std in orderByDescendingResult)
		{
			Console.WriteLine(std.StudentName);
		}

	}

}

public class Student
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }

}