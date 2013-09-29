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
    class OrganizationManager
    {
        public void AddOrganization(Organization organization)
        {
            OrganizationSvcImpl organizationSvcImpl = new OrganizationSvcImpl();

            try
            {
                organizationSvcImpl.AddOrganization(organization);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while adding organization" + e);
                throw new Exception();
            }
        }

        public Organization GetOrganization(int organizationId)
        {
            OrganizationSvcImpl organizationSvcImpl = new OrganizationSvcImpl();
            Organization organization = new Organization();

            try
            {
                organization = organizationSvcImpl.GetOrganization(organizationId);
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

        public void UpdateOrganization(Organization organization)
        {
            OrganizationSvcImpl organizationSvcImpl = new OrganizationSvcImpl();

            try
            {
                organizationSvcImpl.UpdateOrganization(organization);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while updating organization" + e);
            }

        }

        public void DeleteOrganization(Organization organization)
        {
            OrganizationSvcImpl organizationSvcImpl = new OrganizationSvcImpl();
            MessageSvcImpl messageSvcImpl = new MessageSvcImpl();
            UserSvcImpl userSvcImpl = new UserSvcImpl();

            try
            {
                int orgId = organization.OrganizationId;
                List<Message> orgMessages = messageSvcImpl.GetOrganizationMessages(orgId).ToList<Message>();
                List<User> orgUsers = userSvcImpl.GetOrganizationUsers(orgId).ToList<User>();

                //an organization can only be deleted if there are no messages
                //and there are no users associated with the organization
                //otherwise the organization should just be inactivated
                if ((orgMessages.Count == 0) && (orgUsers.Count == 0))
                {
                    organizationSvcImpl.DeleteOrganization(organization);
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
