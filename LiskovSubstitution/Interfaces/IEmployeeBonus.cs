using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Interfaces
{
    internal interface IEmployeeBonus
    {
        double CalculateBonus(double salary);
    }
}
