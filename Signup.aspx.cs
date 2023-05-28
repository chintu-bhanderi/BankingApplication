using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace RegistrationForm
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = floatingName.Value;
            string accountNumber = flotingaccountNumber.Value;
            string email = inputEmail4.Value;
            string password = inputPassword4.Value;
            string bankid = bankId.Value;
            string confirmPassword = floatingconfirmPassword.Value;
            //string city = inputCity.Value;
            int pincode = Int32.Parse(floatinginputZip.Value);

            if(password!=confirmPassword){
                string message = "Password and ConfirmPassword is not match.";
                string script = $@"<script type='text/javascript'>alert('{message}');</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script);
                
                Response.Redirect("Signin.aspx");
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["SSMSConnectionString"].ConnectionString;
            con.Open();
            try
            {
                int flag = 0;
                string fetchAccountNumber = "Select * from Accounts Where [Account No] = '" + accountNumber + "'";
                SqlCommand sqlCommand = new SqlCommand(fetchAccountNumber, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string accountObtain = $"{reader["Account No"]}";
                    flag = 1;
                }
                reader.Close();
                if (flag == 1)
                {
                    insertRegister(name, accountNumber, email, password, bankid, pincode);
                    Response.Redirect("/Home1.aspx");
                    /*//Response.Write("Account present");
                    string command = "INSERT INTO Registration(Name, Account No, Password, Pincode, Email, bankid) Values('" + name + "', '" + accountNumber + "', '" + password + "', '" + pincode + "', '" + email + "', '" + bankid + "')";
                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();
                    //if (rows == 1)
                    //{
                        Response.Write("Done");
                        
                        con.Close();
                    //}*/   
                }
                else
                {
                    Response.Write(@"<div class=""alert alert-danger"" role=""alert""> Sorry your account is not present in our bank..😥😥😥</div>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        protected void insertRegister(string name, string accountNumber, string email, string password, string bankid, int pincode)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP-FL1EIHNK;Integrated Security=True;Initial Catalog=Test";
            string query = "INSERT into[dbo].[Registration] ([Name] ,[Account No], [Password], [Pincode], [Email],[bankid]) values(@name, @accountNumber, @password, @pincode, @email , @bankid)";
            try
            {
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@accountNumber", accountNumber);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@pincode", pincode);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@bankid", bankid);
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            Response.Redirect("Home1.aspx");
        }

    }
}