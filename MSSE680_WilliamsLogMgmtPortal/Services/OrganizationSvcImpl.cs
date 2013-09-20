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
        OrganizationRepository organizationRepository = new OrganizationRepository()
        public void AddOrganization(DAL.Organization organization)
        {
            organizationRepository.AddOrganization(organization);
            throw new NotImplementedException();
        }

        public DAL.Organization GetOrganization(int id)
        {
            organizationRepository.GetOrganizationById(id);
            throw new NotImplementedException();
        }

        public void UpdateOrganization(DAL.Organization organization)
        {
            organizationRepository.UpdateOrganization(organization);
        }

        public void DeleteOrganization(DAL.Organization organization)
        {
            organizationRepository.DeleteOrganization(organization);
            throw new NotImplementedException();
        }
    }