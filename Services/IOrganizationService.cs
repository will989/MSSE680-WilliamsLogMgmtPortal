using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace Services
{
    public interface IOrganizationService : IService
    {
        void AddOrganization();
        void AddOrganization(Organization organization);
        Organization GetOrganization(int id);
        void UpdateOrganization(Organization organization);
        void DeleteOrganization(Organization organization);

    }
}
