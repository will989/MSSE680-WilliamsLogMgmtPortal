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
        MessageRepository messageRepository = new MessageRepository();
        public void AddMessage(DAL.Message message)
        {
            messageRepository.AddMessage(message);
            throw new NotImplementedException();
        }

        public DAL.Message GetMessage(int id)
        {
            messageRepository.GetMessageById(id);
            throw new NotImplementedException();
        }

        public void UpdateMessage(DAL.Message message)
        {
            messageRepository.UpdateMessage(message);
        }

        public void DeleteMessage(DAL.Message message)
        {
            messageRepository.DeleteMessage
            throw new NotImplementedException();
        }
    }
}
