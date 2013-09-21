using System;
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
    public class RepositoryFactoryTests
    {
        //inserts an organization into the database using the repository
        [TestMethod()]
        public void InsertOrganizationUsingRepositoryFactory()
        {

            Organization organization = new Organization();
            //organization.OrganizationId = 1;  - this is auto-assigned in db
            organization.Name = "Repository Organization";
            organization.Street = "Testing St";
            organization.City = "Anytown";
            organization.State = "CO";
            organization.Zip = "80601";
            organization.StartDate = System.DateTime.Now;

            //use repository factory to create a repository
            //of the correct type
            var organizationRepository = RepositoryFactory.Create("Organization");

            //add org to database
            organizationRepository.Insert(organization);

        }
    }
}
