﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace MSSE680_WilliamsLogMgmtPortal.DALUnitTest
{
    [TestClass]
    public class UserTests
    {
        [TestMethod()]
        public void validateGoodUserTest()
        {
            User user = new User();
            user.UserId = 1;
            user.UserName = "test";
            user.Password = "testing";
            user.OrganizationId = 1;
            user.FirstName = "Test";
            user.LastName = "User";
            user.AdminFlag = false;
            user.ActiveDate = System.DateTime.Now;

            Assert.IsTrue(user.validate());

        }

        [TestMethod()]
        public void validateBadUserTest()
        {
            User user = new User();
            user.UserId = -1;
            user.UserName = "test";
            user.Password = "testing";
            user.OrganizationId = 1;
            user.FirstName = "Test";
            user.LastName = "User";
            user.AdminFlag = false;
            user.ActiveDate = System.DateTime.Now;

            Assert.IsFalse(user.validate());

        }

        //verify that users are equal
        [TestMethod()]
        public void equalsTest()
        {
            DateTime current = System.DateTime.Now;

            User user1 = new User();
            user1.UserId = 1;
            user1.UserName = "test";
            user1.Password = "testing";
            user1.OrganizationId = 1;
            user1.FirstName = "Test";
            user1.LastName = "User";
            user1.AdminFlag = false;
            user1.ActiveDate = current;


            User user2 = new User();
            user2.UserId = 1;
            user2.UserName = "test";
            user2.Password = "testing";
            user2.OrganizationId = 1;
            user2.FirstName = "Test";
            user2.LastName = "User";
            user2.AdminFlag = false;
            user2.ActiveDate = current;

            Assert.IsTrue(user1.equals(user2));
        }

        //verify that users are different
        [TestMethod()]
        public void notEqualsTest()
        {
            DateTime current = System.DateTime.Now;

            User user1 = new User();
            user1.UserId = 1;
            user1.UserName = "test";
            user1.Password = "testing";
            user1.OrganizationId = 1;
            user1.FirstName = "Test";
            user1.LastName = "User";
            user1.AdminFlag = false;
            user1.ActiveDate = current;


            User user2 = new User();
            user2.UserId = 1;
            user2.UserName = "test";
            user2.Password = "testing";
            user2.OrganizationId = 2;
            user2.FirstName = "Test";
            user2.LastName = "User";
            user2.AdminFlag = false;
            user2.ActiveDate = current;

            Assert.IsFalse(user1.equals(user2));
        }
    }
}
