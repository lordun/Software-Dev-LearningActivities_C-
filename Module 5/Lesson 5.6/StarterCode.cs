using System;
using System.Text;

namespace SplitProgram
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Ssn { get; set; }

        // two-argument constructor
        public Employee(string name, string ssn)
        {
            Name = name;
            Ssn = ssn;
        }

        //Overriding System Object class method...
        public override string ToString()
        {
            return Name + "\nSocial security number: " + Ssn;

        }

        // abstract method overridden by concrete subclasses        
        public abstract double earnings();
        // no implementation is allowed here, derived calss must override this method!
    } // end abstract class Employee

    public class SalariedEmployee : Employee
    {
        public double WeeklySalary { get; set; }

        // three-argument constructor
        public SalariedEmployee(string name, string ssn, double salary) : base(name, ssn)
        {
            WeeklySalary = salary; // set weekly salary
        }
        //Must Override base class method                                                           
        public override double earnings()
        {
            return WeeklySalary;
        }

        //Overriding BaseClass ToString Method                                                    
        public override string ToString()
        {
            string s = "Salaried employee: " + base.ToString() + "\nWeekly salary " + string.Format("${0:0.00}", WeeklySalary) + string.Format("\nEarned ${0:0.00}", earnings()) + "\n";
            return s;
        }
        // end method tostring                                     
    } // end class SalariedEmployee//

    public class HourlyEmployee : Employee
    {
        public double Wage { get; set; } // wage per hour

        private double _hours;
        public double Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value >= 0.0 && value <= 168.0)
                  _hours = value;
                else
                  _hours = 0;

            }
        }
        // four-argument constructor
        public HourlyEmployee(string name, string ssn, double hourlyWage, double hoursWorked):base(name, ssn )
        {
           Wage=hourlyWage; // set hourly wage
           Hours= hoursWorked; // set hours worked
        } 
 
      // calculate earnings; override abstract method earnings in Employee
      //@Override                                                           
      public override double earnings()
      {                                                                  
      if (Wage<= 40 ) // no earning for less than 40 hours of overtime overtime
      return Wage * Hours;                                
      else                                                             
      return 40 * Wage + (Hours-  40 ) * Wage *  1.5 ; //overtime earning is 1.5 times regualr pay..
      } // end method earnings                                            

      // return string representation of HourlyEmployee object              
      //@Override                                                             
      public override string ToString()
      {                                                                     
            string s = "Hourly employee: " + base.ToString() + "\nHourly wage " + string.Format("${0:0.00}", Wage + "; Hours worked "+ Hours+ string.Format("\nEarned ${0:0.00}",earnings()) + "\n");
            return s;
        } // end method tostring                                              
   } // end class HourlyEmployee




    public class CommissionEmployee : Employee
    {
        private double _grossSales; // gross weekly sales
        public double GrossSales
        {
            get
            {
                return _grossSales;
            }
            set
            { 
                if (value >= 0.0)
                    _grossSales = value;
                else
                    _grossSales = 0;

            }
        }

        public double CommissionRate { get; set; } // commission percentage

        // four-argument constructor
        public CommissionEmployee(string name, string ssn, double sales, double rate):base(name, ssn )
        {

            GrossSales=sales;
            CommissionRate=rate;
        } 

      // calculate earnings; override abstract method earnings in Employee
      //@Override                                                           
      public override double earnings()
      {                                                                   
      return CommissionRate * GrossSales;                    
      } // end method earnings                                            

      // return string representation of CommissionEmployee object
      //@Override                                                   
      public override string ToString()
      {

            string s = "Commission employee: " + base.ToString() + "\nGross sales " + string.Format("${0:0.00}", GrossSales)+ "; Commission rate "+ string.Format("${0:0.00}", CommissionRate+ string.Format("\nEarned ${0:0.00}",earnings()) + "\n");
            return s;          
      } // end method tostring                                    
   } // end class CommissionEmployee



    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        public double BaseSalary { get; set; }
       // five-argument constructor
      public BasePlusCommissionEmployee(string name, string ssn, double sales, double rate, double salary): base(name, ssn, sales, rate)
      {
            BaseSalary=salary; // set base salary
      } // end five-argument BasePlusCommissionEmployee constructor

      // calculate earnings; override method earnings in CommissionEmployee
      //@Override                                                            
      public override double earnings()
      {                                                                    
      return BaseSalary + base.earnings();                        
      }// end method earnings                                              

      // return string representation of BasePlusCommissionEmployee object
      //@Override                                                           
      public override string ToString()
      {

            string s = "Base-salaried-commission employee: " + Name +"\n"+ "Social security number: " + Ssn+
                "\nGross sales " + string.Format("${0:0.00}", GrossSales) + "; Commission rate " + string.Format("${0:0.00}", CommissionRate) + "; Base salary " + string.Format("${0:0.00}", BaseSalary) + string.Format("\nEarned ${0:0.00}", earnings());
            return s;                            
      } // end method tostring                                            
   } // end class BasePlusCommissionEmployee



    class Program
    {
        static void Main(string[] args)
        {

         //Create subclass objects
         SalariedEmployee salariedEmployee = new SalariedEmployee("Mahbub Murshed", "123-12-1357", 800.00);
         HourlyEmployee hourlyEmployee = new HourlyEmployee("Emmanuel Manarang", "111-22-3333", 16.75, 40);
         CommissionEmployee commissionEmployee = new CommissionEmployee("Dipti Gogoi", "444-44-4444", 10000, .06);
         BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Vinci Taylaran", "777-77-7777", 5000, .04, 300);

         Console.WriteLine("Employees processed individually:\n");
         Console.WriteLine(salariedEmployee);
         Console.WriteLine(hourlyEmployee);
         Console.WriteLine(commissionEmployee);
         Console.WriteLine(basePlusCommissionEmployee);

         //Create an Employee array
         var employees = new Employee[4];
         //Initialize array with different Employees
         employees[0] = salariedEmployee;
         employees[1] = hourlyEmployee;
         employees[2] = commissionEmployee;
         employees[3] = basePlusCommissionEmployee;
            
         Console.WriteLine("\nUtilise polymorphism to iterate across different employees:\n");
            
         //Process every element in the array
         foreach (var currentEmployee in employees)
         {
            
                // Check if employee is a BasePlusCommissionEmployee
                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    // downcast Employee reference to BasePlusCommissionEmployee reference
                    BasePlusCommissionEmployee employee =(BasePlusCommissionEmployee) currentEmployee;
                    employee.BaseSalary=1.30 * employee.BaseSalary;
                    Console.WriteLine("New base-salary with 30% increase is: $"+employee.BaseSalary);
                } // end if
                Console.WriteLine(currentEmployee); // invokes tostring    
            } // end for

         Console.WriteLine();
         // Get Employee type from employees array
         for (int j = 0; j < employees.Length; j++)
            Console.WriteLine("Employee {0} is {1}", j+1, employees[j].GetType().Name);
                            
        }
    }
}
