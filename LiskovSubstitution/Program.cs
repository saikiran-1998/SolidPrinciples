using LiskovSubstitution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new PermanentEmployee(1, "Kiran"));
            employee.Add(new TemperoryEmployee(2, "Sai"));
            foreach (var item in employee)
            {
                Console.WriteLine("Minimum salary of " + item.Name + " is " + item.GetMinimumSalary());
                Console.WriteLine(item.Name + " Gets " + item.CalculateBonus(30000) + " as bonus");
            }

            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(new PermanentEmployee(1, "Kiran"));
            employees.Add(new TemperoryEmployee(2, "Sai"));
            employees.Add(new ContractEmployee(3, "Vamsi"));
            foreach (var item in employees)
            {
                Console.WriteLine("Minimum salary of "+item.Name + " is " + item.GetMinimumSalary());
            }
            Console.ReadKey();
        }
    }
}
