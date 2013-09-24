using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    public class MessageNotFoundException : Exception
    {
        public MessageNotFoundException(String s) : base(s)
        {
            
        }
    }
}
