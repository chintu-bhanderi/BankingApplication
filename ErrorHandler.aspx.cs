using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class ErrorHandler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Click_GoHome(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}