//needed to add MSSE680_WilliamsLogMgmtPortal as a Reference
//under ServicesUnitTest
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSSE680_WilliamsLogMgmtPortal.DAL;
using Services;

namespace BusinessUnitTests
{
    [TestClass]
    public class OrganizationServiceTests
    {
        [TestMethod()]
        public void BusinessOrgManagerInsertOrganizationUsingOrganizationServiceImpl()
        {
            var factory = new Factory();
            Organization organization = new Organization();
            //organization.OrganizationId = 1;  - this is auto-assigned in db
            organization.Name = "Service Implementation Organization";
            organization.Street = "Service Blvd";
            organization.City = "Service";
            organization.State = "CO";
            organization.Zip = "80601";
            organization.StartDate = System.DateTime.Now;

            //add organization using factory to create necessary service
            //IOrganizationService organizationSvc = (IOrganizationService)factory.GetService(typeof(IOrganizationService).Name);
            //organizationSvc.AddOrganization(organization);

            //pre-factory implementation
            //add organization to database using OrganizationSvcImpl
            OrganizationSvcImpl orgSvcImpl = new OrganizationSvcImpl();
            orgSvcImpl.AddOrganization(organization);

        }
    }
}
