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
    public class OrganizationManager
    {
        public void AddOrganization(Organization organization)
        {
            //create new Organization Manager
            var organizationManager = new OrganizationManager();

            try
            {
                //use the manager to determine how organizaton's are being added
                organizationManager.AddOrganization(organization);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while adding organization" + e);
                throw new Exception();
            }
        }

        public Organization GetOrganization(int organizationId)
        {

            //create new Organization Manager
            var organizationManager = new OrganizationManager();
            Organization organization = new Organization();

            try
            {
                //user manager to determine how we are getting organizations
                organization = organizationManager.GetOrganization(organizationId);
            }
            catch (OrganizationNotFoundException onfe)
            {
                Debug.WriteLine("Organization with that id was not found" + onfe);
                throw new OrganizationNotFoundException("Message with that id was not found" + onfe);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while getting organization" + e);
            }

            return organization;
        }

        public List<Organization> GetAllOrganizations()
        {
            //create new Organization Manager
            var organizationManager = new OrganizationManager();
            List<Organization> orgList = new List<Organization>();


            try
            {
            var orgRepo = new DataRepository<Organization>();
            orgList = orgRepo.GetAll().ToList<Organization>();
                
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while getting list of messages" + e);
            }

            return orgList;
        }

        public void UpdateOrganization(Organization organization)
        {

            try
            {
                //create new Organization Manager
                var organizationManager = new OrganizationManager();
                //user manager to determine how we are updating organizations
                organizationManager.UpdateOrganization(organization);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while updating organization" + e);
            }

        }

        public void DeleteOrganization(Organization organization)
        {

            try
            {
                //user factory to get service implementations
                //create new Managers
                var organizationManager = new OrganizationManager();
                var messageManager = new MessageManager();
                var userManager = new UserManager();
                int orgId = organization.OrganizationId;

                List<Message> orgMessages = messageManager.GetOrganizationMessages(orgId).ToList<Message>();
                List<User> orgUsers = userSvc.GetOrganizationUsers(orgId).ToList<User>();

                //an organization can only be deleted if there are no messages
                //and there are no users associated with the organization
                //otherwise the organization should just be inactivated
                if ((orgMessages.Count == 0) && (orgUsers.Count == 0))
                {
                    organizationManager.DeleteOrganization(organization);
                }
                else
                {
                    throw new OrganizationNotFoundException("The organization is in use, it must be inactivated");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while deleting organization" + e);
            }

        }

    }
}
