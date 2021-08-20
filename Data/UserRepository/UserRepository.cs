using firstWebApi.Models;

namespace firstWebApi.Data.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public User CreateOneUser(User user)
        {
            
            User newUser = new User();
            
            return newUser;
        }

        public User GetUser()
        {
             
            User userDTO = new User(){
                Id = 1
            };

            return userDTO;
        }

        public User UpdateOneUser(User user)
        {
            return new User();
        }
    }
}