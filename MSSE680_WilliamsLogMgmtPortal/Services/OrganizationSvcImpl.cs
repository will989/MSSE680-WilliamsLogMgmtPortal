using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    public class OrganizationSvcImpl : IOrganizationService
    {
 
        public void AddOrganization(DAL.Organization organization)
        {
            var organizationRepository = RepositoryFactory.Create("Organization");
            //organizationRepository.AddOrganization(organization);
             //add org to database
            organizationRepository.Insert(organization);
        }

        public DAL.Organization GetOrganization(int id)
        {
            //*** Need to figure out how to return the organization
            var organizationRepository = RepositoryFactory.Create("Organization");
            Organization organization = new Organization();
            organizationRepository.GetBySpecificKey("OrganizationId", id);
            return organization;
        }

        public void UpdateOrganization(DAL.Organization organization)
        {
            //create repository of the correct type
            var organizationRepository = RepositoryFactory.Create("Organization");
            
            //update the organization
            organizationRepository.Update(organization);
        }

        public void DeleteOrganization(DAL.Organization organization)
        {
            //create repository of the correct type
            var organizationRepository = RepositoryFactory.Create("Organization");

            //delete the organization
            organizationRepository.Delete(organization);
        }
         
    }

}