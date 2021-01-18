namespace LearningActivity_1_SplitACSharpProgramIntoDifferentFiles
{
    public class SalariedEmployee : Employee
        {
            public double WeeklySalary { get; set; }

            // three-argument constructor
            public SalariedEmployee(string name, string ssn, double salary) : base(name, ssn)
            {
                WeeklySalary = salary; // set weekly salary
            }
            //Must Override base class method                                                           
            public override double Earnings()
            {
                return WeeklySalary;
            }

            //Overriding BaseClass ToString Method                                                    
            public override string ToString()
            {
                string s = "Salaried employee: " + base.ToString() + "\nWeekly salary " + string.Format("${0:0.00}", WeeklySalary) + string.Format("\nEarned ${0:0.00}", Earnings()) + "\n";
                return s;
            }
            // end method tostring                                     
        } // end class SalariedEmployee//
    }


