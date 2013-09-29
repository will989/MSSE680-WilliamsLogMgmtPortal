//needed to add MSSE680_WilliamsLogMgmtPortal as a Reference
//under ServicesUnitTest
using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSSE680_WilliamsLogMgmtPortal.DAL;
using Services;


namespace BusinessUnitTests
{
    [TestClass]
    public class MessageServiceTests
    {
        //inserts an organization into the database using the repository
        [TestMethod()]
        public void BusinessMessageMgrInsertMessageUsingMessageSvcImpl()
        {
            var factory = new Factory();
            
            DateTime current = System.DateTime.Now;

            Message message1 = new Message();
            message1.MessageId = 1;
            message1.CorrelationIdentifier = 1010101;
            message1.SendingOrgId = 1;
            message1.ReceivingOrgId = 1;
            message1.Severity = 3;
            message1.OrgMessage = "This is a test message";
            message1.Timestamp = current;
           
           //factory not working...
           //add message using factory to create necessary service
           //IMessageService messageSvc = (IMessageService)factory.GetService(typeof(IMessageService).Name);
           // messageSvc.AddMessage(message1);

           //add message to database using MessageSvcImpl
           MessageSvcImpl msgSvcImpl = new MessageSvcImpl();
           msgSvcImpl.AddMessage(message1);

        }

        
        [TestMethod()]
        public void GetMessagesTest()
        {
            Message message = new Message();


            try
            {
                MessageSvcImpl msgSvcImpl = new MessageSvcImpl();
                message = msgSvcImpl.GetMessage(1);
            }
            catch (MessageNotFoundException)
            {
                Debug.WriteLine("Message was not found");
            }

            Assert.IsTrue(message.SendingOrgId == 1);

        }
    }
}
