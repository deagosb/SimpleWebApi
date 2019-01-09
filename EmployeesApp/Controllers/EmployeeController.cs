using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogicLayer;

namespace EmployeesApp.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        // GET: api/Employee
        public List<EmployeeDTO> Get()
        {
            Employee employee = new Employee();
            List<EmployeeDTO> result = employee.GetAll();
            return result;

            //return new string[] { "value1", "value2" };
        }

        // GET: api/Employee/1
        public EmployeeDTO Get(int id)
        {
            Employee employee = new Employee();           
            return employee.GetEmployee(id); ;
        }
        
    }
}
