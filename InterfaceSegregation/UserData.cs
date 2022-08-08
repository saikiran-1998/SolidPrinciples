using System.Collections.Generic;

namespace InterfaceSegregation
{
    public class UserData
    {
        public List<User> users = new List<User>();
        public UserData()
        {
            users.Add(new User { UserName = "sai", Password = "@sai", Email = "sai@email.com" });
            users.Add(new User { UserName = "kiran", Password = "@kiran", Email = "kiran@email.com" });
            users.Add(new User { UserName = "vamsi", Password = "@vamsi", Email = "vamsi@email.com" });
        }
    }
}
