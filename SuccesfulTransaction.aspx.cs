using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class SuccesfulTransaction : System.Web.UI.Page
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

            Response.Write("Your Transaction had Successfull");
        }

        protected void Click_TransactionShow(object sender, EventArgs e)
        {
            Response.Redirect("Transaction_crud1.aspx");
        }

        protected void Click_MyBalance(object sender, EventArgs e)
        {
            Response.Redirect("CheckBalance.aspx");
        }

        protected void Click_GoHome(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}