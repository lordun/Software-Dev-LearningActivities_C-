using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity1_Employee
{
	public class Employee  // Starter Code
	{
		// ToDo Set Private Data Field
		private string _name;
		private double _wage;
		private double _hours;
		private double _payCheque;

		public string Name { get => _name; set => _name = value; }
		public double Wage { get => _wage; set => _wage = value; }
		public double PayCheque { get => _payCheque; set => _payCheque = value; }
		public double Hours { get => _hours; set => _hours = value; }

		public Employee()
		{
			_name = "";
			_wage = 0;
			_hours = 0;
			_payCheque = 0;
		}
		public void HoursWorked(double hours)
		{
			 Hours+=hours;
		}
		public double Pay()
		{
			PayCheque = Hours * Wage;
			Hours = 0;
			return PayCheque;
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			// create two employee objects
			Employee emp1 = new Employee();
			Employee emp2 = new Employee();


			emp1.Name="David";
			emp1.Wage=15;
			emp2.Name="Susan";
			emp2.Wage=20;

			Console.WriteLine("Employee '{0}' is paid {1} before working...", emp1.Name, emp1.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} before working...", emp2.Name, emp2.Pay());
			emp1.HoursWorked(5);
			emp2.HoursWorked(8);
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.Name, emp1.Pay());

			emp1.HoursWorked(5);
			emp2.HoursWorked(2);
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.Name, emp1.Pay());
			Console.WriteLine("Employee '{0}' is paid {1} after working...", emp2.Name, emp2.Pay());
		}
	}
}
