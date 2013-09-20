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
        UserRepository userRepository = new UserRepository();
        public void AddUser(DAL.User user)
        {
            userRepository.AddUser(user);
            throw new NotImplementedException();
        }

        public DAL.User GetUser(int id)
        {
            userRepository.GetUserById(id);
            throw new NotImplementedException();
        }

        public void UpdateUser(DAL.User user)
        {
            userRepository.UpdateUser(user);
        }

        public void DeleteUser(DAL.User user)
        {
            userRepository.DeleteUser(user);
            throw new NotImplementedException();
        }
    }

}
