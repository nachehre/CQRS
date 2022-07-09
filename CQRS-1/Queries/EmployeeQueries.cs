﻿using CQRS_1.DTO;
using CQRS_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_1.Queries
{
    public class EmployeeQueries : IEmployeeQueries
    {
        private readonly IEmployeeQueriesRepository _repository;
        public EmployeeQueries(IEmployeeQueriesRepository repository)
        {
            _repository = repository;
        }
        public EmployeeDTO FindByID(int employeeID)
        {
            var emp = _repository.GetByID(employeeID);
            return new EmployeeDTO
            {
                Id = emp.Id,
                FullName = emp.FirstName + " " + emp.LastName,
                Address = emp.Street + " " + emp.City + " " + emp.PostalCode,
                Age = Convert.ToInt32(Math.Abs(((DateTime.Now - emp.DateOfBirth).TotalDays) / 365)) - 1
            };
        }
    }
}
