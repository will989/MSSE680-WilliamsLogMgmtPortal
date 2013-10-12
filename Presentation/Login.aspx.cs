using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;

namespace Presentation
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Login1_Authenticate(object sender, System.Web.UI.WebControls.AuthenticateEventArgs e)
        {
            string userName = Login1.UserName;
            string password = Login1.Password;

            bool result = AuthenticateUser.AuthUser(userName, password);
           // part of example but not needed since this is handled differently in the Business layer
           // bool result = UserLogin(userName, password);
            if (result)
            {
                e.Authenticated = true;
            }
            else
            {
                e.Authenticated = false;
            }
        }

 
        //From http://forums.asp.net/t/1403132.aspx but not needed since this is handled in the Business layer
        /*
        private bool UserLogin(string userName, string password)
        {

            // read the coonection string from web.config 
            string conString = ConfigurationManager.ConnectionStrings["ConnectionStringName"].ConnectionString;

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(conString))
            {
                //' declare the command that will be used to execute the select statement 
                SqlCommand com =
                    new SqlCommand("SELECT UserName FROM Users WHERE UserName = @UserName AND Password = @Password", con);

                // set the username and password parameters
                com.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName;
                com.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;

                con.Open();
                //' execute the select statment 
                string result = Convert.ToString(com.ExecuteScalar());
                //' check the result 
                if (string.IsNullOrEmpty(result))
                {
                    //invalid user/password , return flase 
                    return false;
                }
                else
                {
                    // valid login
                    return true;
                }
            }
         
        } */
    }
}

