using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Interfaces
{
    public interface IUser
    {
        string Login(string userName, string password);
        string Register(string email, string userName, string password);
        //void LogError(string error);
        //bool SendEmail(string emailBody);
    }
}
