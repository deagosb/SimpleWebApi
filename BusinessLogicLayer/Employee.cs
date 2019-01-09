using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class Employee
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public string HourlySalary { get; set; }
        public string MonthlySalary { get; set; }


        public Employee()
        {
            
        }

        public EmployeeDTO GetEmployee(Int64 Id)
        {            
            EmployeeDTO result = GetAll().Where(x => x.Id == Id).FirstOrDefault();            
            return result;
        }


        public List<EmployeeDTO> GetAll()
        {

            DataAccessLayer.Employee listEmployee = new DataAccessLayer.Employee();
            string result = listEmployee.GetData();

            List<Employee> obj = JsonConvert.DeserializeObject<List<Employee>>(result);

            List<EmployeeDTO> objResult = new List<EmployeeDTO>();

            if (obj.Count > 0)
            {
                for (int i = 0; i < obj.Count; i++)
                {
                    string _contractTypeName = obj[i].ContractTypeName;
                    double _monthlySalary = Convert.ToDouble(obj[i].MonthlySalary);
                    double _hourlySalary = Convert.ToDouble(obj[i].HourlySalary);


                    if (_contractTypeName == "HourlySalaryEmployee")
                    {

                        EmployeeFactory factory = null;
                        factory = new EmployeeHourlyFactory(_monthlySalary, _monthlySalary);
                        EmployeeDTO employee = factory.GetEmployee();
                        employee.Id = obj[i].Id;
                        employee.Name = obj[i].Name;
                        employee.ContractTypeName = obj[i].ContractTypeName;
                        employee.RoleName = obj[i].RoleName;
                        employee.RoleId = obj[i].RoleId;
                        employee.RoleDescription = obj[i].RoleDescription;
                        employee.HourlySalary = Convert.ToDouble(obj[i].HourlySalary);
                        objResult.Add(employee);
                    }
                    else
                    {
                        EmployeeFactory factory = null;
                        factory = new EmployeeMonthlyFactory(_monthlySalary, _monthlySalary);
                        EmployeeDTO employee = factory.GetEmployee();
                        employee.Id = obj[i].Id;
                        employee.Name = obj[i].Name;
                        employee.ContractTypeName = obj[i].ContractTypeName;
                        employee.RoleName = obj[i].RoleName;
                        employee.RoleId = obj[i].RoleId;
                        employee.RoleDescription = obj[i].RoleDescription;
                        employee.HourlySalary = Convert.ToDouble(obj[i].MonthlySalary);
                        objResult.Add(employee);
                    }
                }
            }            

            return objResult;
        }

    }    

}
