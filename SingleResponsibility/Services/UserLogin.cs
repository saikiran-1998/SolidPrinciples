using SingleResponsibility.Interfaces;


namespace SingleResponsibility.Services
{
    public class UserLogin : IUser
    {
        private readonly UserData _data;
        public UserLogin(UserData data)
        {
            _data = data;
        }

        public string Login(string userName, string password)
        {
            var user = _data.users.Find(x => x.UserName == userName && x.Password == password);
            if (user == null)
            {
                return "Login Failed";
            }
            else
            {
                return "Login Successfull";
            }
        }

        public string Register(string email, string userName, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}
