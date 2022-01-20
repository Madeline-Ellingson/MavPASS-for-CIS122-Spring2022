// Written by Madeline Ellingson
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS122_1_19_2022
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Student aStudent1 = new Student();
			Student aStudent2 = new Student();
			Student aStudent3 = new Student();

			aStudent1.FirstName = "Anna";
			aStudent1.LastName = "Roberts";
			aStudent1.FeeBalance = 5.49;
			aStudent1.IsInternational = true;
			aStudent1.SSN = "123-45-6789";

			aStudent2.FirstName = "Madeline";
			aStudent2.LastName = "VonWalde";
			aStudent2.FeeBalance = 10.27;
			aStudent2.IsInternational = false;
			aStudent2.SSN = "456-789-1234";

			aStudent3.FirstName = "Robert";
			aStudent3.LastName = "Hammel";
			aStudent3.FeeBalance = 9.99;
			aStudent3.IsInternational = false;
			aStudent3.SSN = "789-12-3456";

			List<Student> aListOfStudents = new List<Student>();

			aListOfStudents.Add(aStudent1);
			aListOfStudents.Add(aStudent2);
			aListOfStudents.Add(aStudent3);

			foreach(Student s in aListOfStudents)
			{
				// Instead of having to write this all out whenever you
				// want to print out an object you can now just use the 
				// ToString() Method

				//Console.WriteLine("Student ID: " + s.StudentID + "\n"
				//				+ "First Name: " + s.FirstName + "\n"
				//				+ "Last Name: " + s.LastName + "\n"
				//				+ "Fee Balance: " + s.FeeBalance + "\n"
				//				+ "Is International: " + s.IsInternational + "\n"
				//				+ "Full Name: " + s.FullName + "\n");

				// This method is called the same way as you would 
				// any other method on an object which you will learn
				// more about later
				Console.WriteLine(s.ToString());
			}

			Console.ReadLine();
		}
	}
}

