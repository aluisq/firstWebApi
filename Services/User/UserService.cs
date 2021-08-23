using System.Collections.Generic;
using System.Threading.Tasks;
using firstWebApi.Data.UserRepository;

namespace firstWebApi.Services.User
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task <Models.User> getUserByID(int id)
        {
           
           Task <Models.User> user =  _userRepository.GetUserById(id);

            return await user;
           
        }

        public async Task<List<Models.User>> GetUsers()
        {
          Task <List<Models.User>> user =  _userRepository.GetUsers();

          return await user;
        }
    }
}