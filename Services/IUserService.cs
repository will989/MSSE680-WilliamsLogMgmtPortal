using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace Services
{
    //interface for User Service
    public interface IUserService
    {
        void AddUser(User user);
        User GetUser(int id);
        User GetUser(string userName);
        void UpdateUser(User user);
        void DeleteUser(User user);

    }
}
