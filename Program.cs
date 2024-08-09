using System;
using ProxyStructuralDesignPattern.GlobalInterfaces;
using ProxyStructuralDesignPattern.Models;

public class Program
{
    public static void Main(string[] args)
    {
        IEmployee employeeImpl = new EmployeeImplements(); // Create an instance of EmployeeImplements
        IEmployee employeeProxy = new EmployeeProxy(employeeImpl); // Pass the instance to EmployeeProxy

        // Test the Create and Delete methods
        string createResult = employeeProxy.Create("admin", employeeImpl);
        Console.WriteLine(createResult); // Should output: "Employee Created"

        string deleteResult = employeeProxy.Delete("admin", 123);
        Console.WriteLine(deleteResult); // Should output: "Employee Deleted"

        string createResult1 = employeeProxy.Create("user", employeeImpl);
        Console.WriteLine(createResult1);

        string deleteResult1 = employeeProxy.Delete("user", 124);
        Console.WriteLine(deleteResult1);

    }
}























//IEmployee employee = new EmployeeProxy();
//employee.Create("user", new IEmployee());
//Console.WriteLine("Operation Successful");