using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_DifferentWaysToInitializeStudentClass
{
	using System;   // Starter Code
	namespace Programming_Fundamentals
	{
		public class Student
		{   // Add access modifiers
			private int _id;
			private string _fName;
			private string _lName;
			private string _department;
			private int _year;
			private string _email;

			public int ID { get => _id; set => _id = value; }
			public string FName { get => _fName; set => _fName = value; }
			public string LName { get => _lName; set => _lName = value; }
			public string Department { get => _department; set => _department = value; }
			public int Year { get => _year; set => _year = value; }
			public string Email { get => _email; set => _email = value; }

			// Add Constructor methods

			public Student()
			{
			}
			public Student(int id,string fName, string lName, string dept, int year, string email )
			{
				ID = id;
				FName = fName;
				LName = lName;
				Department = dept;
				Year = year;
				Email = email;
			}

			public void DisplayStudentInformation() // The display method
			{
				Console.WriteLine("\nStudent Name: " + FName + " " + LName);
				Console.WriteLine("Student ID: " + ID);
				Console.WriteLine("Department: " + Department);
				Console.WriteLine("Study Year: " + Year);
				Console.WriteLine("e-mail address: " + Email);
			}
		}
		public class Program
		{
			static void Main(string[] args)
			{   // ToDo: Instatiation object using default constructor and initialize fields by accessing them
				var std1 = new Student { FName = "Penelope", LName = "Lee", Department = "Computer Science", Email = "plee@somewhere.com", Year = 2016, ID = 001 };
				var std2 = new Student(002, "Jean-Paul", "Smith", "Chemistry", 2020, "jpsmith@somewhere.com");
				var std3 = new Student();
				std3.ID = 003;
				std3.FName = "Sharkieshwa";
				std3.LName = "Gorganzollo";
				std3.Department = "Film Studies";
				std3.Year = 2002;
				std3.Email="sharkgorg@somewhere.com";

				// ToDo: object initialization using parameterized constructor

				// ToDo: initialization using object initializers

				std1.DisplayStudentInformation();
				std2.DisplayStudentInformation();
				std3.DisplayStudentInformation();
			}
		}
	}
}
