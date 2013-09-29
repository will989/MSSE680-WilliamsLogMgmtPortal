//needed to add MSSE680_WilliamsLogMgmtPortal as a Reference
//under ServicesUnitTest
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSSE680_WilliamsLogMgmtPortal.DAL;
using Services;

namespace BusinessUnitTests
{
    [TestClass]
    public class UserServiceTests
    {
        //insert a user into the database using the UserSvcImpl
        [TestMethod()]
        public void BusinessUserManagerInsertUserUsingUserSvcImpl()
        {
            var factory = new Factory();
            DateTime current = System.DateTime.Now;
            User user = new User();
            user.UserName = "userSvcImpl";
            user.Password = "testing";
            user.OrganizationId = 1;
            user.FirstName = "Service";
            user.LastName = "Implementation";
            user.AdminFlag = false;
            user.ActiveDate = current;


            //add user using factory to create necessary service
            //IUserService userSvc = (IUserService)factory.GetService(typeof(IUserService).Name);
            //userSvc.AddUser(user);

            //add user to database using UserSvcImpl
            UserSvcImpl userSvcImpl = new UserSvcImpl();
            userSvcImpl.AddUser(user);

        }
    }
}
