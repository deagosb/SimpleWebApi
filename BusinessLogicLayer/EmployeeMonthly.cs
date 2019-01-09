using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    /// <summary>
    ///  A 'ConcreteProduct' class
    /// </summary>
    class EmployeeMonthly : EmployeeDTO
    {
        private double _annualSalary;

        public EmployeeMonthly(double hourlySalary, double monthlySalary)
        {
            _annualSalary = monthlySalary * 12;
        }

        public override double AnnualSalary
        {
            get { return _annualSalary; }
            set { _annualSalary = value; }
        }
    }
}
