using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee(1,"Kiran", "Permanent");
            //Console.WriteLine(employee1.Name+" Gets "+ employee1.CalculateBonus(30000)+" as bonus");
            //Employee employee2 = new Employee(2, "sai", "temporory");
            //Console.WriteLine(employee2.Name + " Gets " + employee2.CalculateBonus(30000) + " as bonus");
            
            Employee employee1 = new PermanentEmployee(1, "Kiran");
            Console.WriteLine(employee1.Name+" Gets "+ employee1.CalculateBonus(30000)+" as bonus");

            Employee employee2 = new TemperoryEmployee(2, "sai");
            Console.WriteLine(employee2.Name + " Gets " + employee2.CalculateBonus(30000) + " as bonus");


            Console.ReadKey();
        }
    }
}
