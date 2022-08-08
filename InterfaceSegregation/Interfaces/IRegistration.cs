using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Interfaces
{
    public interface IRegistration
    {
        string Register(string email, string userName, string password);
    }
}
