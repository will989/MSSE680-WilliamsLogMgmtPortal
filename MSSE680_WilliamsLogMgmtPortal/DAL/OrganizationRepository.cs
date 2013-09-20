using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSE680_WilliamsLogMgmtPortal.DAL
{
    public class OrganizationRepository
    {
        /// <summary>
        /// The organization repository is instantiated
        /// </summary>
        readonly IDataRepository<Organization> objOrganizationRepository = new DataRepository<Organization>();

        //Add organization
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Insert, true)]
        public void AddOrganization(Organization organization)
        {
            objOrganizationRepository.Insert(organization);
        }


        //list organizations
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<Organization> GetAllOrganizations()
        {
            return objOrganizationRepository.GetAll().ToList<Organization>();
        }


        //update an organization
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
        public void UpdateOrganization(Organization organization)
        {
            objOrganizationRepository.Update(organization);
        }


        //delete an organization
        //in the real solution we will likely only inactivate organizations
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Delete, true)]
        public void DeleteOrganization(Organization organization)
        {
            objOrganizationRepository.Delete(organization);
        }


        //look up organization by OrganizationId
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public Organization GetOrganizationById(int OrganizationId)
        {
            try
            {
                return objOrganizationRepository.GetBySpecificKey("OrganizationId", OrganizationId).FirstOrDefault<Organization>();
            }
            catch
            {
                return null;
            }
        }
    }
}
