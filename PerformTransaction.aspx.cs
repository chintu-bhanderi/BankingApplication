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
    public partial class PerformTransaction : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                DropDownListChooseAccount();
            }
        }

        protected void DropDownListChooseAccount()
        {
            string ConnString = WebConfigurationManager.ConnectionStrings["SSMSConnectionString"].ConnectionString;
            string SqlString = "Select [Account No] from [dbo].[Accounts]";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        string AcNo = "";
                        SqlDataReader rdr = cmd.ExecuteReader();
                        //ddlAcNo.Items.Add("Account_No");
                        while (rdr.Read())
                        {
                            /*AcNo = rdr.GetString("Account No");*/
                            AcNo = rdr["Account No"].ToString();
                            if (AcNo == (Session["accountNumberObt"]).ToString())
                                continue;
                            ddlAcNo.Items.Add(AcNo);
                            //Response.Write(AcNo);
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
        }

        protected void btnPay_Submit(object sender, EventArgs e)
        {
            string myaccount = (Session["accountNumberObt"]).ToString();
            string accountNo;
            if(ddlAcNo.SelectedItem.Value == "0")
            {
                accountNo = "No account is selected";
            }
            else
            {
                accountNo = ddlAcNo.SelectedItem.Value;
            }
            string name = TbName.Text;
            int amount = Int32.Parse(TbAmount.Text);
            string remark = TbRemark.Text;

            UpdateAccount(accountNo,myaccount, amount);
            AddTransactionHistory(myaccount, accountNo, name,amount,remark);
            Response.Redirect("SuccesfulTransaction.aspx");
        }

        protected void UpdateAccount(string ToAccount,string MyAccount,int Amount)
        {
            int MycurrentBalance = fatchAmount(MyAccount);
            if(MycurrentBalance-Amount<0)
            {
                Response.Redirect("ErrorHandler.aspx");
            }
            else
            {
                int TocurrentBalance = fatchAmount(ToAccount);
                UpdateBalance(ToAccount, TocurrentBalance+Amount);
                UpdateBalance(MyAccount, MycurrentBalance-Amount);
            }
            
        }

        protected int fatchAmount(string AccountNo)
        {
            int amount = 0;
            string ConnString = WebConfigurationManager.ConnectionStrings["SSMSConnectionString"].ConnectionString;
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

        protected void UpdateBalance(string AccountNo, int Amount)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP-FL1EIHNK;Integrated Security=True;Initial Catalog=Test";
            string query = "UPDATE [dbo].[Accounts] SET [Balance]=@Amount where [Account No]=@ToAccount";
            try
            {
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@ToAccount", AccountNo);
                        cmd.Parameters.AddWithValue("@Amount", Amount);
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

        protected void AddTransactionHistory(string MyAccount,string AccountNo,string Name, int Amount,string Remark)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP-FL1EIHNK;Integrated Security=True;Initial Catalog=Test";
            string query = "INSERT into[dbo].[Transaction1] ([My Account] ,[To Account], [Payee Name], Amount, Remark) values(@MyAccount, @Account, @Name, @Amount, @Remark)";
            try
            {
                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@MyAccount", MyAccount);
                        cmd.Parameters.AddWithValue("@Account", AccountNo);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Amount", Amount);
                        cmd.Parameters.AddWithValue("@Remark", Remark);
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Click_Cancel(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        /*protected void Click_GoHome(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }*/
    }
}