using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSE680_WilliamsLogMgmtPortal.DAL
{
    public class UserRepository
    {
        //generic User repository
        readonly IDataRepository<User> objUserRepository = new DataRepository<User>();

        //List all users
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<User> GetAllUsers()
        {
            return objUserRepository.GetAll().ToList<User>();
        }


        //Update users
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
        public void UpdateUser(User user)
        {
            objUserRepository.Update(user);
        }


        //delete users
        //we will normally only inactivate users
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Delete, true)]
        public void DeleteUser(User user)
        {
            objUserRepository.Delete(user);
        }


        //get user by unique user id
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public User GetUserById(int UserId)
        {
            try
            {
                return objUserRepository.GetBySpecificKey("UserId", UserId).FirstOrDefault<User>();
            }
            catch
            {
                return null;
            }
        }
    }
}
