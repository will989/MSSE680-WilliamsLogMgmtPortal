using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    public class UserSvcImpl : IUserService
    {
        public void AddUser(DAL.User user)
        {
            //use the factory to create a repository
            var userRepository = RepositoryFactory.Create("User");
            userRepository.Insert(user);
        }

        public DAL.User GetUser(int id)
        {
            //use the factory to create a repository
            User user = new User();
            var userRepository = RepositoryFactory.Create("User");
            userRepository.GetBySpecificKey("UserId",id);
            return user;
        }

        public void UpdateUser(DAL.User user)
        {
            //use the factory to create a repository
            var userRepository = RepositoryFactory.Create("User");
            userRepository.Update(user);
        }

        public void DeleteUser(DAL.User user)
        {
            //use the factory to create a repository
            var userRepository = RepositoryFactory.Create("User");
            userRepository.Delete(user);
        }
        
    }

}
