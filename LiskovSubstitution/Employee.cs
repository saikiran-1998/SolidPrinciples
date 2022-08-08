using LiskovSubstitution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee()
        {
        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract double CalculateBonus(double salary);

        public abstract double GetMinimumSalary();
    }
}
