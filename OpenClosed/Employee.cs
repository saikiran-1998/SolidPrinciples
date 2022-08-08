using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // public string EmployeeType { get; set; }
        public Employee()
        {
        }

        public Employee(int id, string name/*,string emploeeType*/)
        {
            Id = id;
            Name = name;
            //EmployeeType = emploeeType;
        }
        //public double CalculateBonus(double salary)
        //{
        //    if (EmployeeType=="Permanent")
        //    {
        //        return salary + 20000;
        //    }
        //    else
        //    {
        //        return salary + 10000;
        //    }
        //}
        public abstract double CalculateBonus(double salary);
    }
}
