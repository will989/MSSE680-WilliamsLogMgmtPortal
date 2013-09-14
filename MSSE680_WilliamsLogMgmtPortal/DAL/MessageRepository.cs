using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSE680_WilliamsLogMgmtPortal.DAL
{
    public class MessageRepository
    {
        //generic Message repository
        readonly IDataRepository<Message> objMessageRepository = new DataRepository<Message>();

        //List all messages
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<Message> GetAllMessages()
        {
            return objMessageRepository.GetAll().ToList<Message>();
        }


        //Update Messages
        //(in the real solution editing messages won't be supported
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
        public void UpdateMessage(Message message)
        {
            objMessageRepository.Update(message);
        }


        //delete messages
        //we won't really delete messages
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Delete, true)]
        public void DeleteUser(Message message)
        {
            objMessageRepository.Delete(message);
        }


        //get Message by unique Message id
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public Message GetMessageById(int MessageId)
        {
            try
            {
                return objMessageRepository.GetBySpecificKey("MessageId", MessageId).FirstOrDefault<Message>();
            }
            catch
            {
                return null;
            }
        }



    }
}
