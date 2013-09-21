using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    public class RepositoryFactory
    {
        //the create method takes a string that contains 
        //a repository type as a parameter
        public static IDataRepository Create(string sRepositoryType)
        {
            IDataRepository objRepo;
            switch (sRepositoryType)
            {
                case "Organization":
                    objRepo = new DataRepository<Organization>();
                    break;
                case "Message":
                    objRepo = new DataRepository<Message>();
                    break;
                case "User":
                    objRepo = new DataRepository<User>();
                    break;
                default:
                    objRepo = null;
                    throw new System.ArgumentException("Unimplemented Repository type the factory " + sRepositoryType);
            }
            return objRepo;
        }
    }
}
