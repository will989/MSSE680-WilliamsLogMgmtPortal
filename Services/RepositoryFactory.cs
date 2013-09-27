using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace Services
{
    public class RepositoryFactory
    {

        //the create method takes a string that contains 
        //a repository type as a parameter and returns a repository of that type
        public static IDataRepository Create(string sRepositoryType)
        {
            IDataRepository objRepo=null;
            if (sRepositoryType != null)
            {
                System.Diagnostics.Debug.WriteLine("string sRepositoryType = " +sRepositoryType);

                switch (sRepositoryType)
                {
                    case "Organization":
                        objRepo = new DataRepository<Organization>();
                        System.Diagnostics.Debug.WriteLine("Created new repository {0}", objRepo);
                        break;
                    case "Message":
                        System.Diagnostics.Debug.WriteLine("In Message case statement");
                        objRepo = new DataRepository<Message>();
                        System.Diagnostics.Debug.WriteLine("Created new repository {0}", objRepo);
                        break;
                    case "User":
                        objRepo = new DataRepository<User>();
                        break;
                    default:
                        objRepo = null;
                        throw new System.ArgumentException("Unimplemented Repository type the factory " + sRepositoryType);
                }
                System.Diagnostics.Debug.WriteLine("Outside case statement, Created new repository {0}", objRepo);
                return objRepo;
            }
            return objRepo;
        }
    }
}
