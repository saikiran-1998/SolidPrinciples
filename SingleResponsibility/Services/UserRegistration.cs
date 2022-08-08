using SingleResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Services
{
    public class UserRegistration : IUser
    {
        private readonly UserData _data;

        public UserRegistration(UserData data)
        {
            _data = data;
        }

        public string Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public string Register(string email, string userName, string password)
        {
            var user = _data.users.Find(x => x.Email == email && x.UserName == userName);
            if (user == null)
            {
                _data.users.Add(new User { Email = email, Password = password, UserName = userName });
                return "User Registered successfully";
            }
            else
            {
                return "User already Exists, Please use Login";
            }
        }
    }
}
