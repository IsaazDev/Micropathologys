using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Micropathologys
{
    public partial class Micropathologys : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblErrorMessage.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection("Server= localhost; Database= Dele_default; Integrated Security=True;"))
            {
                sqlCon.Open();
                string Login = "Select Count(1) from Micro Where username=@username And password=@password";
                SqlCommand sqlcmd = new SqlCommand(Login, sqlCon);
                sqlcmd.Parameters.AddWithValue("@username", TextBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@password", TextBox2.Text.Trim());
              //sqlcmd.Parameters.AddWithValue("@Firtname", Firstname.Text.Trim());
               // sqlcmd.Parameters.AddWithValue("@Surname", Surname.Text.Trim());
              // sqlcmd.Parameters.AddWithValue("@Age", Age.Text.Trim());
               // sqlcmd.Parameters.AddWithValue("@EmailAddress", EmailAddress.Text.Trim());
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            
            if(count == 1)
                {
                    //Session["username"] = TextBox1.Text.Trim();
                    Response.Redirect("NewPage.aspx");
                    //MessageBox.Show("You have sign up :D");
                }

            else {
                    MessageBox.Show("Password Don't match!");
                }
            }


        }
            protected void Button7_Click(object sender, EventArgs e)
            {
            var NPage = "RegistrationPage.aspx";

            if(NPage == "RegistrationPage.aspx")
            {
                Response.Redirect("RegistrationPage.aspx");
               }

            else
            {
                MessageBox.Show("Page Down!");
              }
            }
    }
}