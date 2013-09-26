using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    public class OrganizationNotFoundException : Exception
    {
        public OrganizationNotFoundException(String s) : base(s)
        {
            
        }
    }
}
