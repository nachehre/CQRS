using CQRS_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_1.Repositories
{
    public class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        public Employee GetByID(int employeeID)
        {
            // Get the employee record from a data store  
            // Below is for demo purposes only  
            return new Employee()
            {
                Id = 100,
                FirstName = "Nasim",
                LastName = "Chehre",
                DateOfBirth = new DateTime(2000, 1, 1),
                Street = "AmirAbad Street",
                City = "Tehran",
                PostalCode = "k1k 1k1"
            };
        }
    }
}
