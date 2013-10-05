using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MSSE680_WilliamsLogMgmtPortal.DAL;
using Business;

namespace Presentation
{
    public partial class MessageForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Message message = new Message();

            //convert input to integers where needed
            message.CorrelationIdentifier = Convert.ToInt32(this.CorrelationId.Text);  
            message.SendingOrgId = Convert.ToInt32(this.SendingOrgId.Text);
            message.ReceivingOrgId = Convert.ToInt32(this.ReceivingOrgId.Text);
            message.Severity = Convert.ToInt32(this.Severity.Text);
            message.OrgMessage = this.Message.Text;
            message.Timestamp = this.TimeStamp.SelectedDate;
            
            var mm = new MessageManager();
            mm.AddMessage(message);
        }
    }
}