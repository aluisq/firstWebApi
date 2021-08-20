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

        public Models.User GetUser()
        {
          Models.User user = _userRepository.GetUser();

          return user;
        }
    }
}