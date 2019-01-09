using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public class EmployeeMonthlyFactory : EmployeeFactory
    {        
        private double _hourlySalary;
        private double _monthlySalary;

        public EmployeeMonthlyFactory(double hourlySalary, double monthlySalary)
        {
            _hourlySalary = hourlySalary;
            _monthlySalary = monthlySalary;
        }

        public override EmployeeDTO GetEmployee()
        {
            return new EmployeeMonthly(_hourlySalary, _monthlySalary);
        }
    }
}
