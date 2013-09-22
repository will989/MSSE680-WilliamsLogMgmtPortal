using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    public interface IMessageService
    {
        void AddMessage(Message message);
        Message GetMessage(int id);
        void UpdateMessage(Message message);
        void DeleteMessage(Message message);
        List<Message> GetOrganizationMessages(int organizationId);
   
    }
}
