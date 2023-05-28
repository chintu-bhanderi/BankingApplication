using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;    
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class Transaction_crud : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\1.NET\project\BankingApplication\BankingApplication\App_Data\Transaction.mdf;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;");
            Response.Write("Hello1");
            //con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\1.NET\project\BankingApplication\BankingApplication\App_Data\Transaction.mdf;Integrated Security=True";
            Response.Write("Hello2");
            try
            {
                string commnad = "Select * from Transaction";
                SqlCommand cmd = new SqlCommand(commnad, con);
                Response.Write("Hello3");
                con.Open();
                Response.Write("Hello4");
                SqlDataReader rdr = cmd.ExecuteReader();
                Response.Write("Hello5");
                GridViewTransaction.DataSource = rdr;
                GridViewTransaction.DataBind();
                rdr.Close();
            }
            catch(Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
        }
    }
}