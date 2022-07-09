using CQRS_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_1.Commands
{
    interface IEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);
    }
}
