using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class Home1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["isLogin"] = false;
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signin.aspx");
        }
    }
}