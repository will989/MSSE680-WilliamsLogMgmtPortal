using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace Services
{
    public class Factory
    {
        public Factory()
        {
        }

        public IService GetService(String servicename)
        {
            Type type;
            Object obj = null;

            try
            {
                //Looks up the implementation name in app.config
                //but is not getting the correct result for some reason
                type = Type.GetType(GetImplName(servicename));
                //Dynamically instantiates the implementation class
                if (type != null) obj = Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception occured: {0}", e);
                //throw e;

            }
            return (IService)obj;
        }

        private string GetImplName(string servicename)
        {
            NameValueCollection settings =
                ConfigurationManager.AppSettings;
            string s = ConfigurationManager.AppSettings.Get(servicename);
            Debug.WriteLine("String s = " +s);

            if (!String.IsNullOrEmpty(s))
            {
                //Looks up the impl name in app.config
                return settings.Get(servicename);
            }

            //Default service
            return "IUserService";

        }

    }
}
