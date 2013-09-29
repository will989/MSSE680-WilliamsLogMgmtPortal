using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSE680_WilliamsLogMgmtPortal.DAL;
using Services;

namespace Business
{
    class UserManager
    {
        public void AddUser(User user)
        {
            UserSvcImpl userSvcImpl = new UserSvcImpl();

            try
            {
                userSvcImpl.AddUser(user);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while adding user" + e);
                throw new Exception();
            }
        }

        public User GetUser(int userId)
        {
            UserSvcImpl userSvcImpl = new UserSvcImpl();
            User user = new User();

            try
            {
                user = userSvcImpl.GetUser(userId);
            }
            catch (UserNotFoundException unfe)
            {
                Debug.WriteLine("User with that id was not found" + unfe);
                throw new UserNotFoundException("User with that id was not found" + unfe);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while getting user" + e);
            }

            return user;
        }

        public void UpdateUser(User user)
        {
            UserSvcImpl userSvcImpl = new UserSvcImpl();

            try
            {
                userSvcImpl.UpdateUser(user);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while updating user" + e);
            }

        }


        //a user should really only be inactivated but I will implement this
        public void DeleteUser(User user)
        {

            UserSvcImpl userSvcImpl = new UserSvcImpl();

            try
            {
                int userId = user.UserId;
                userSvcImpl.DeleteUser(user);
                Debug.WriteLine("User with userId " + userId + "was deleted.");
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while deleting user" + e);
            }

        }

    }
}
