using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    public class ServiceNotFoundException : Exception
    {
        public ServiceNotFoundException(String s) : base(s)
        {

        }
    }
}
