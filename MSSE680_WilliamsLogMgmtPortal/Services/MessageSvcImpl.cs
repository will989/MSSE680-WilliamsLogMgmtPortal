using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using MSSE680_WilliamsLogMgmtPortal.DAL;
using Message = MSSE680_WilliamsLogMgmtPortal.DAL.Message;

namespace MSSE680_WilliamsLogMgmtPortal.Services
{
    public class MessageSvcImpl : IMessageService
    {
        public void AddMessage(Message message)
        {
            Factory factory = new Factory();
            //use the factory to create a repository
            var myRepo = (Message) factory.GetRepository(typeof (IRepository).Name);
            //myRepo.Insert(message);
            var messageRepository = RepositoryFactory.Create("Message");
            messageRepository.Insert(message);
        }

        public DAL.Message GetMessage(int id)
        {
            try
            {
                //use the factory to create a repository
                Message message = new Message();
                message = null;
                
                //need to use factory
                //IMessageRepository messageRepository = (IMessageRepository)factory.GetRepository(typeof(IMessageRepository).Name);
                var msgRepo = new DataRepository<Message>();
                List<Message> myMsgs = msgRepo.GetBySpecificKey("MessageId", id).ToList<Message>();
                
                //Repository factory method:
                var messageRepository = Services.RepositoryFactory.Create("Message");
                //List<Message> myMessages = messageRepository.GetBySpecificKey("MessageId", id).ToList<Message>();

                message = myMsgs[0];

                if (message == null)
                {
                    throw new MessageNotFoundException("Message not found!");
                }
                else
                {
                    return message;
                }
            }
            
            catch (OrganizationNotFoundException onfe)
            {
                System.Console.WriteLine("Caught OrganizationNotFoundException" + onfe);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Caught Exception" + e);
            }
            
        }

        public void UpdateMessage(Message message)
        {
            //use the factory to create a repository
            var messageRepository = RepositoryFactory.Create("Message");
            messageRepository.Update(message);
        }

        public void DeleteMessage(Message message)
        {
            //use the factory to create a repository
            var messageRepository = RepositoryFactory.Create("Message");
            messageRepository.Delete(message);
        }

        public List<Message> GetOrganizationMessages(int organizationId)
        {
            //use the factory to create a new repository
            var messageRepository = RepositoryFactory.Create("Message");

           List<Message> orgMessages = messageRepository.GetBySpecificKey("OrganizationId", organizationId);
            return new List<Message>();

        }
 
    }
}