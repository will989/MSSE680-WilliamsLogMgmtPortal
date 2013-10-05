using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSSE680_WilliamsLogMgmtPortal.DAL;
using Services;

namespace Business
{
    public class MessageManager
    {
        public void AddMessage(Message message)
        {
            //create new MessageManager object
            MessageManager messageManager = new MessageManager();

            try
            {
                //let the Message Manager figure out how we are adding messages
                messageManager.AddMessage(message);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while adding message" + e);
                throw new Exception();
            }
        }

        public Message GetMessage(int messageId)
        {
            Message message = new Message();

            //create new MessageManager object
            MessageManager messageManager = new MessageManager();

            try
            {
                //let the Message Manager figure out how we are getting messages
                message = messageManager.GetMessage(messageId);
            }
            catch (MessageNotFoundException mnfe)
            {
                Debug.WriteLine("Message with that id was not found" + mnfe);
                throw new MessageNotFoundException("Message with that id was not found" + mnfe);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while getting message" + e);
            }

            return message;
        }

        public List<Message> GetOrganizationMessages(int organizationId)
        {
            //use manager to get organization messages
            List<Message> orgMessages = new List<Message>();
            MessageManager messageManager = new MessageManager();

            try
            {
                //use the message manager to figure out how to get an organization's messages
                orgMessages = messageManager.GetOrganizationMessages(organizationId);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while getting list of messages" + e);
            }

            return orgMessages;
        }

        public List<Message> GetCorrelatedMessages(int correlationId)
        {
            //user manager to get related messages
            MessageManager messageManager = new MessageManager();
            List<Message> correlatedMessages = new List<Message>();

            try
            {
                correlatedMessages = messageManager.GetOrganizationMessages(correlationId);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while getting list of messages" + e);
            }

            return correlatedMessages;
        }
    }
}
