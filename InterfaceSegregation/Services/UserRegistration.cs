using InterfaceSegregation;
using InterfaceSegregation.Interfaces;

namespace SingleResponsibility.Services
{
    public class UserRegistration : IRegistration
    {
        private readonly UserData _data;

        public UserRegistration(UserData data)
        {
            _data = data;
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
