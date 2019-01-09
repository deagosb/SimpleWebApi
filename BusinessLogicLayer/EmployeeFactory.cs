using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    /// <summary>
    /// The 'Creator' Abstract Class
    /// </summary>
    public abstract class EmployeeFactory
    {
        public abstract EmployeeDTO GetEmployee();
    }
}
