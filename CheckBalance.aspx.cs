using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace BankingApplication
{
    public partial class CheckBalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["isLogin"] == false)
            {
                string message = "You are not Logged-In.";
                string script = $@"<script type='text/javascript'>alert('{message}');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script);
                
                Response.Redirect("Signin.aspx");
            }
            int myBalance = fatchAmount((Session["accountNumberObt"]).ToString());
            Response.Write("Your Balace is: " + myBalance + " Rs.");
        }

        protected int fatchAmount(string AccountNo)
        {
            int amount = 0;
            string ConnString = WebConfigurationManager.ConnectionStrings["SSMSConnectionString"].ConnectionString;
            //string SqlString = "Select * From Contacts Where FirstName = @FirstName";
            string SqlString = "Select * from [dbo].[Accounts] where [Account No]=@Account";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Account", AccountNo);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        amount = Convert.ToInt32(reader["Balance"]);
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }

            return amount;
        }

        protected void Click_GoHome(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}