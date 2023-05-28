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
    public partial class Transaction_crud1 : System.Web.UI.Page
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
            ShowTransaction1();
        }
        protected void ShowTransaction1()
        {
            string myAccount = (Session["accountNumberObt"]).ToString();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["SSMSConnectionString"].ConnectionString;
            try
            {
                using (con)
                {
                    string commnad = "Select [To Account],[Payee Name],[Amount],[Remark] from [dbo].[Transaction1] where [My Account]=@myAccount";
                    SqlCommand cmd = new SqlCommand(commnad, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@myAccount", myAccount);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridViewTransactionShow1.DataSource = rdr;
                    GridViewTransactionShow1.DataBind();
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
        }
    }
}