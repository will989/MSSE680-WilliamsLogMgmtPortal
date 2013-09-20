using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    //interface for User Service
    public interface IUserService
    {
        void AddUser(User user);
        User GetUser(int id);
        void UpdateUser(User user);
        void DeleteUser(User user);

    }
}
