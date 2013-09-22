﻿using System;
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
            //use the factory to create a repository
            var messageRepository = RepositoryFactory.Create("Message");
            messageRepository.Insert(message);
        }

        public DAL.Message GetMessage(int id)
        {
            //use the factory to create a repository
            Message message = new Message();
            var messageRepository = RepositoryFactory.Create("Message");
            messageRepository.GetBySpecificKey("MessageId", id);
            return message;
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
            //use the factory to create a repository
            var messageRepository = RepositoryFactory.Create("Message");

            //*** need to figure this out
           // List<Message> orgMessages = messageRepository.GetBySpecificKey("OrganizationId", organizationId);
            return new List<Message>();

        }
 
    }
}