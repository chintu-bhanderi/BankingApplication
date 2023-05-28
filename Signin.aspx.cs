using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm
{
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string emailId = inputEmail3.Value;
            string password = inputPassword3.Value;
            string verifyPassword = null;
            string verifyEmailId = null;
            string accountNumberFetch = null;
            //string amountFetched = null;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["SSMSConnectionString"].ConnectionString;
            con.Open();
            try
            {
                int mainFlag = 0;
                string fetchAccountNumber = "Select * from Registration Where Email = '" + emailId + "' and Password = '" + password + "' ";
                SqlCommand sqlCommand = new SqlCommand(fetchAccountNumber, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    verifyPassword = $"{reader["Password"]}";
                    verifyEmailId = $"{reader["Email"]}";
                    accountNumberFetch = $"{reader["Account No"]}";
                    //amountFetched = $"{reader["amountavailable"]}";
                    mainFlag = 1;
                }
                reader.Close();
                if (mainFlag == 1)
                {
                    Session["accountNumberObt"] = accountNumberFetch;
                    Session["isLogin"] = true;
                    //Response.Write(Session["accountNumberObt"]);
                    //Session["amountObt"] = amountFetched;
                    Response.Redirect("/HomePage.aspx");
                    con.Close();
                }
                else
                {
                    Response.Write("Something Problem");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}