using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    public class Factory
    {
        public Factory()
        {
        }

        public IRepository GetRepository(string repositoryname)
        {
            Type type;
            Object obj = null;

            try
            {
                //Looks up the implementation name in app.config
                //type = Type.GetType(GetRepositoryName(repositoryname));
                //Dynamically instantiates the implementation class
                obj = new DataRepository<respositoryname>();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;

            }
            return (IRepository) obj;
        }

        private string GetRepositoryName(string repositoryname)
        {
            NameValueCollection settings =
                ConfigurationManager.AppSettings;
            //Looks up the impl name in app.config
            return settings.Get(repositoryname);

        }

        public IService GetService(string servicename)
        {
            Type type;
            Object obj = null;

            try
            {
                //Looks up the implementation name in app.config
                type = Type.GetType(GetImplName(servicename));
                //Dynamically instantiates the implementation class
                obj = Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;

            }
            return (IService) obj;
        }

        private string GetImplName(string servicename)
        {
            NameValueCollection settings =
                ConfigurationManager.AppSettings;
            //Looks up the impl name in app.config
            return settings.Get(servicename);

        }

    }
}
