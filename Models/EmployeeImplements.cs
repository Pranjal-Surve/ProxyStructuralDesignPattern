using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyStructuralDesignPattern.GlobalInterfaces;

namespace ProxyStructuralDesignPattern.Models
{
    internal class EmployeeImplements : IEmployee
    {
        public string Create(string client, IEmployee obj)
        {
            return "Employee Created !";
        }
        public string Delete(string client, int employeeId)
        {
            return "Employee Deleted !";
        }

    }
}
