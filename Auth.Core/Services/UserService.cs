using Auth.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Core.Services
{
    public class UserService
    {
        private static List<User> _users = new List<User>
    {
        new User { Username = "testuser", Password = "password" } // Example user
    };

        public User ValidateUser(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
