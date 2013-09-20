using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    public interface IOrganizationService
    {
        void AddOrganization(Organization organization);
        Organization GetOrganization(int id);
        void UpdateOrganization(Organization organization);
        void DeleteOrganization(Organization organization);

    }
}
