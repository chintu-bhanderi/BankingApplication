using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["accountNumberObt"] != null)
            {
                Session.Remove("accountNumberObt");
                Session.RemoveAll();
                Response.Redirect("/Home1.aspx");
            }
            else
            {
                Label1.Text = "Session not created successfully";
            }
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}