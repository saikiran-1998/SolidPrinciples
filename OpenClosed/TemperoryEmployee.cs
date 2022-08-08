using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    internal class TemperoryEmployee : Employee
    {
        public TemperoryEmployee(int id, string name) : base(id, name)
        {
        }

        public override double CalculateBonus(double salary)
        {
            return salary+10000;
        }
    }
}
