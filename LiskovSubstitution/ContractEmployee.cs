using LiskovSubstitution.Interfaces;
using System;

namespace LiskovSubstitution
{
    internal class ContractEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContractEmployee()
        {
        }

        public ContractEmployee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public double GetMinimumSalary()
        {
            return 10000;
        }
    }
}
