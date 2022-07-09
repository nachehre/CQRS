using CQRS_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_1.Repositories
{
   public interface IEmployeeQueriesRepository
    {
        Employee GetByID(int employeeID);
    }
}
