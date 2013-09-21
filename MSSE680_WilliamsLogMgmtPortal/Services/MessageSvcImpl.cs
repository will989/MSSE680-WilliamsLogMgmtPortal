using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSE680_WilliamsLogMgmtPortal.DAL;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    public class MessageSvcImpl : IMessageService
    {
        
        public void AddMessage(Message message)
        {
            var messageRepository = RepositoryFactory.Create("Message");
            messageRepository.Insert(message);
        }

        public DAL.Message GetMessage(int id)
        {
            Message message = new Message();
            var messageRepository = RepositoryFactory.Create("Message");
            messageRepository.GetBySpecificKey("MessageId",id);
            return message;
        }

        public void UpdateMessage(Message message)
        {
            var messageRepository = RepositoryFactory.Create("Message");
            messageRepository.Update(message);
        }

        public void DeleteMessage(Message message)
        {
            var messageRepository = RepositoryFactory.Create("Message");
            messageRepository.Delete(message);
        }
         
    }
}
