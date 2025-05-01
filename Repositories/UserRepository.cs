using ApiAuth.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace ApiAuth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string userName, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, UserName = "batman", Password = "batman", Role = "manager" });
            users.Add(new User { Id = 2, UserName = "robin", Password = "robin", Role = "employee" });
            return users.Where(x => x.UserName.ToLower() == userName.ToLower()
                                        && x.Password == password).FirstOrDefault();
        }
    }
}
