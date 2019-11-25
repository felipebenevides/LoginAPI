using Repository.Models;

namespace Domain.Interfaces.IServices
{
    public interface IUserService
    {
        User GetUser(string username, string password);
    }
}
