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

             //add org to database
            organizationRepository.Insert(organization);
        }

        public DAL.Organization GetOrganization(int id)
        {
            try
            {
                var organizationRepository = new RepositoryFactory.Create("Organization");

                Organization organization = new Organization();
                organization = null;

                //return an organization
                organization = organizationRepository.GetBySpecificKey("OrganizationId", id);

                if (organization == null)
                {
                    throw new OrganizationNotFoundException("Organization not found!");
                }
                else
                {
                    return organization;  
                }
                
            }
            catch (OrganizationNotFoundException onfe)
            {
                System.Console.WriteLine("Caught OrganizationNotFoundException" + onfe);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Caught Exception" + e);
            }
        }

        public void UpdateOrganization(DAL.Organization organization)
        {
            //create repository of the correct type
            var organizationRepository = new RepositoryFactory.Create("Organization");
            
            //update the organization
            organizationRepository.Update(organization);
        }

        public void DeleteOrganization(DAL.Organization organization)
        {
            //create repository of the correct type
            var organizationRepository = new RepositoryFactory.Create("Organization");

            //delete the organization
            organizationRepository.Delete(organization);
        }
         
    }

}