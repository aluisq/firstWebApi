using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task <List<User>> GetUsers()
        {
            
           Task <IQueryable<User>> userDTO =  Task.Run(() => _dataContext.Users.Select(x => x));

           var user = await userDTO;

            return user.ToList();
        }

        public User UpdateOneUser(User user)
        {
            return new User();
        }
    }
}