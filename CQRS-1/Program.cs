using CQRS_1.Commands;
using CQRS_1.Queries;
using CQRS_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Command the Employee Domain to save data  
            var employeeCommand = new EmployeeCommands(new EmployeeCommandRepository());
            employeeCommand.SaveEmployeeData(new Models.Employee
            {
                Id = 200,
                FirstName = "Nasim",
                LastName = "Chehre",
                Street = " AmirAbad Street",
                City = "Tehran",
                PostalCode = "j1j1j1",
                DateOfBirth = new DateTime(2002, 2, 2)
            });
            Console.WriteLine( $"Employee data stored");
            // Query the Employee Domain to get data  
            var employeeQuery = new EmployeeQueries(new EmployeeQueriesRepository());
            var employee = employeeQuery.FindByID(100);
            Console.WriteLine( $"Employee ID:{employee.Id}, Name:{employee.FullName}, Address:{employee.Address}, Age:{employee.Age}");
            Console.ReadKey();
        }
    }
}
