using Domain.Interfaces.IRepository;
using Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public User GetUser(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "admin", Password = "12345", Role = "manager" });
            users.Add(new User { Id = 2, Username = "funcionario", Password = "12345", Role = "employee" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }
    }
}
