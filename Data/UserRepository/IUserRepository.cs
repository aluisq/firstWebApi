using firstWebApi.Models;

namespace firstWebApi.Data.UserRepository
{
    public interface IUserRepository
    {
        User CreateOneUser(User user); 

        User UpdateOneUser(User user);
        User GetUser();
    }
}