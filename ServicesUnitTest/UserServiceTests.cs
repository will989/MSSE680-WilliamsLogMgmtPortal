﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//needed to add MSSE680_WilliamsLogMgmtPortal as a Reference
//under ServicesUnitTest
using MSSE680_WilliamsLogMgmtPortal.DAL;
using MSSE680_WilliamsLogMgmtPortal.Services;

namespace ServicesUnitTest
{
    [TestClass]
    public class UserServiceTests
    {
        //insert a user into the database using the UserSvcImpl
        [TestMethod()]
        public void InsertUserUsingUserSvcImpl()
        {

            DateTime current = System.DateTime.Now;
            User user = new User();
            user.UserName = "userSvcImpl";
            user.Password = "testing";
            user.OrganizationId = 1;
            user.FirstName = "Service";
            user.LastName = "Implementation";
            user.AdminFlag = false;
            user.ActiveDate = current;

            //add user to database using UserSvcImpl
            UserSvcImpl userSvcImpl = new UserSvcImpl();
            userSvcImpl.AddUser(user);

        }
    }
}