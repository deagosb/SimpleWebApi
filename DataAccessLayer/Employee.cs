using RestSharp;

namespace DataAccessLayer
{
    public class Employee
    {

        //public Int64 Id { get; set; }
        //public string Name { get; set; }
        //public string ContractTypeName { get; set; }
        //public int RoleId { get; set; }
        //public string RoleName { get; set; }
        //public string RoleDescription { get; set; }
        //public string HourlySalary { get; set; }
        //public string MonthlySalary { get; set; }

        public string GetData()
        {
            // Set Client             
            var client = new RestClient("http://masglobaltestapi.azurewebsites.net/api/Employees");
            var request = new RestRequest(Method.GET);

            // Add HTTP Headers  
            request.AddHeader("cache-control", "no-cache");

            // Execute 
            IRestResponse response = client.Execute(request);

            // Deserialize json
            //return JsonConvert.DeserializeObject<Employee>(response.Content);
            return response.Content;
        }
    }
}
