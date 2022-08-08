using InterfaceSegregation.Interfaces;


namespace InterfaceSegregation.Services
{
    public class UserLogin : ILogin
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
    }
}
