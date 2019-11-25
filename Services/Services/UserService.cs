using Domain.Interfaces.IRepository;
using Domain.Interfaces.IServices;
using Repository.Models;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUser(string username, string password)
        {
            return _userRepository.GetUser(username, password);
        }
    }
}
