using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSSE680_WilliamsLogMgmtPortal.DAL;
using Services;
using Business;

namespace BusinessUnitTests
{
    [TestClass]
    public class AuthenticateUserTests
    {
        [TestMethod()]
        public void AuthenticateUserTest()
        {
            string username = "Seed";
            string password = "testing";

            bool authorized = false;
            authorized = AuthenticateUser.AuthUser(username, password);

            Assert.IsTrue(authorized);

        }
    }
}