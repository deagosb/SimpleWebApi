using System;
using System.Collections.Generic;
using DataAccessLayer;
using Newtonsoft.Json;

namespace BusinessLogicLayer
{
    /// <summary>
    /// The 'Product' Abstract Class 
    /// </summary>
    public abstract class EmployeeDTO
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
        public abstract double AnnualSalary { get; set; }

        public EmployeeDTO()
        {
            Employee employee = new Employee();
        }
        
        
    }
}
