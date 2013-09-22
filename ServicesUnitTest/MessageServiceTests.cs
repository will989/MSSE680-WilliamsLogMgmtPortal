using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//needed to add MSSE680_WilliamsLogMgmtPortal as a Reference
//under ServicesUnitTest
using MSSE680_WilliamsLogMgmtPortal.DAL;
using MSSE680_WilliamsLogMgmtPortal.Services;

    
namespace ServicesUnitTest
{
    [TestClass]
    public class MessageServiceTests
    {
        //inserts an organization into the database using the repository
        [TestMethod()]
        public void InsertMessageUsingMessageSvcImpl()
        {
            DateTime current = System.DateTime.Now;

            Message message1 = new Message();
            message1.MessageId = 1;
            message1.CorrelationIdentifier = 1010101;
            message1.SendingOrgId = 1;
            message1.ReceivingOrgId = 1;
            message1.Severity = 3;
            message1.OrgMessage = "This is a test message";
            message1.Timestamp = current;
            
            //add message to database using MessageSvcImpl
            MessageSvcImpl msgSvcImpl = new MessageSvcImpl();
            msgSvcImpl.AddMessage(message1);

        }
    }
}
