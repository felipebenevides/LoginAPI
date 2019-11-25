using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.IRepository
{
    public interface IUserRepository
    {
        User GetUser(string username, string password);
    }
}
