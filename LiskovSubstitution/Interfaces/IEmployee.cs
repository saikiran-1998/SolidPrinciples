using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Interfaces
{
    internal interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        double GetMinimumSalary();
    }
}
