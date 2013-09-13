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

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>Returns a list of all products</returns>
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<Organization> GetAllProducts()
        {
            return objOrganizationRepository.GetAll().ToList<Organization>();
        }


        /// <summary>
        /// Updates a product
        /// </summary>
        /// <param name="p">The product entity</param>
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
        public void UpdateOrganization(Organization organization)
        {
            objOrganizationRepository.Update(organization);
        }


        /// <summary>
        /// Delete a product
        /// </summary>
        /// <param name="p">The product entity to be deleted</param>
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Delete, true)]
        public void DeleteOrganization(Organization organization)
        {
            objOrganizationRepository.Delete(organization);
        }


        /// <summary>
        /// Gets an organization by ID, assuming the Organization Id is unique
        /// </summary>
        /// <param name="OrganizationID">The value for the primary key OrganizationId</param>
        /// <returns>The product associated with the integer ID</returns>
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
