using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyStructuralDesignPattern.GlobalInterfaces
{
    internal interface IEmployee
    {
        string Create(string client, IEmployee obj);
        string Delete(string client, int employeeId);
    }   
}
