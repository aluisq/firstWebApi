
using System.Collections.Generic;
using System.Threading.Tasks;
using firstWebApi.Models;

namespace firstWebApi.Services.User
{
    public interface IUserService
    {
        Task <List<firstWebApi.Models.User>> GetUsers();

        Task<firstWebApi.Models.User> getUserByID(int id);
        
    }
}