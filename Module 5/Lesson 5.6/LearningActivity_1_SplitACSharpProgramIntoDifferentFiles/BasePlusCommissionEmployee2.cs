using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningActivity_1_SplitACSharpProgramIntoDifferentFiles
{
    public partial class BasePlusCommissionEmployee : CommissionEmployee
    {
        public override double Earnings()
        {
            return BaseSalary + base.Earnings();
        }// end method earnings                                              

        // return string representation of BasePlusCommissionEmployee object
        //@Override                                                           
        public override string ToString()
        {

            string s = "Base-salaried-commission employee: " + Name + "\n" + "Social security number: " + Ssn +
                "\nGross sales " + string.Format("${0:0.00}", GrossSales) + "; Commission rate " + string.Format("${0:0.00}", CommissionRate) + "; Base salary " + string.Format("${0:0.00}", BaseSalary) + string.Format("\nEarned ${0:0.00}", Earnings());
            return s;
        } // end method tostring           

    }
}
