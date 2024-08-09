using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyStructuralDesignPattern.GlobalInterfaces;

namespace ProxyStructuralDesignPattern.Models
{
    internal class EmployeeProxy : IEmployee
    {
        IEmployee iemployeeImplements;
        public EmployeeProxy(IEmployee employee)
        {
            iemployeeImplements = employee; 
        }      

        public string Create(string client, IEmployee obj)
        {
            if (client == "admin")
            {
                return iemployeeImplements.Create(client, obj); // Return the result of the operation
            }
            return "Access denied !";
        }

        public string Delete(string client, int employeeId)
        {
            if (client == "admin")
            {
                return iemployeeImplements.Delete(client, employeeId); // Return the result of the operation
            }
            return "Access denied !";
        }


    }
}



















//public EmployeeProxy(IEmployee employee)
//{
//    //this.employee = employee;
//    iemployeeImplements = new EmployeeImplements();  //has a relationship (EmployeeImplements object)
//}