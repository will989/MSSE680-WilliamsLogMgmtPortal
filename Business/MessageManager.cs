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
    class MessageManager
    {
        public void AddMessage(Message message)
        {
            MessageSvcImpl messageSvcImpl = new MessageSvcImpl();

            try
            {
                messageSvcImpl.AddMessage(message);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while adding message" + e);
                throw new Exception();
            }
        }

        public Message GetMessage(int messageId)
        {
            MessageSvcImpl messageSvcImpl = new MessageSvcImpl();
            Message message = new Message();

            try
            {
                message = messageSvcImpl.GetMessage(messageId);
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
            MessageSvcImpl messageSvcImpl = new MessageSvcImpl();
            Message message = new Message();
            List<Message> orgMessages = new List<Message>();

            try
            {
                orgMessages = messageSvcImpl.GetOrganizationMessages(organizationId);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception caught while getting list of messages" + e);
            }

            return orgMessages;
        }
    }
}
