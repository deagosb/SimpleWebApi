using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    

    /// <summary>
    ///  A 'ConcreteCreator' class 
    /// </summary>
    public class EmployeeHourlyFactory : EmployeeFactory
    {

        private double _hourlySalary;
        private double _monthlySalary;

        public EmployeeHourlyFactory(double hourlySalary, double monthlySalary)
        {
            _hourlySalary = hourlySalary;
            _monthlySalary = monthlySalary;
        }

        public override EmployeeDTO GetEmployee()
        {
            return new EmployeeHourly(_hourlySalary, _monthlySalary);
        }
    }
}
