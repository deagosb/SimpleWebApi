using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    /// <summary>
    ///  A 'ConcreteProduct' class
    /// </summary>
    class EmployeeHourly : EmployeeDTO
    {
        private double _annualSalary;

        public EmployeeHourly(double hourlySalary, double monthlySalary)
        {
            _annualSalary = 120 * hourlySalary * 12;
        }

        public override double AnnualSalary
        {
            get { return _annualSalary; }
            set { _annualSalary = value; }
        }
    }
}
