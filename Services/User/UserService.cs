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

        public async Task<List<Models.User>> GetUsers()
        {
          Task <List<Models.User>> user =  _userRepository.GetUsers();

          return await user;
        }
    }
}