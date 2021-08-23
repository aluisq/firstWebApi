using System.Collections.Generic;
using System.Threading.Tasks;
using firstWebApi.Models;

namespace firstWebApi.Data.UserRepository
{
    public interface IUserRepository
    {
        User CreateOneUser(User user); 

        User UpdateOneUser(User user);
        Task <List<User>> GetUsers();

        Task <User> GetUserById(int id);

    }
}