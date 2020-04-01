using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Micropathologys
{
    public partial class RegistrationPage : System.Web.UI.Page
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
                string Login = "INSERT INTO Micro(username, password ,Firstname, Surname, Age, EmailAddress) VALUES ('"+Textbox3.Text+"' , '"+TextBox5.Text+"' ,'"+FirstName.Text+"' , '"+Surname.Text+"' , '"+Age.Text+"' ,'"+EmailAddress.Text+"' )";
                SqlCommand sqlcmd = new SqlCommand(Login, sqlCon);

                sqlcmd.Parameters.AddWithValue("@username", Textbox3.Text);
                sqlcmd.Parameters.AddWithValue("@password", TextBox5.Text);
                sqlcmd.Parameters.AddWithValue("@Firstname", FirstName.Text);
                sqlcmd.Parameters.AddWithValue("@Surname", Surname.Text);
                sqlcmd.Parameters.AddWithValue("@Age", Age.Text);  
                sqlcmd.Parameters.AddWithValue("@EmailAddress", EmailAddress.Text);
                string count = Convert.ToString(sqlcmd.ExecuteScalar());

               
                
                if (count == "1")
                {
                    //Session["username"] = TextBox1.Text.Trim();
                    //Response.Redirect("RegistrationPage.aspx");
                    MessageBox.Show("You have sign up :D"); 
                }

        

                //try
                //{
                //    sqlcmd.ExecuteNonQuery();
                //}
                //catch(SqlException f)
                //{
                //    MessageBox.Show(f.Message.ToString(), "fill all boxes please");
                //}

                
            }
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            var NPage = "Micropathologys.aspx";

            if (NPage == "Micropathologys.aspx")
            {
                Response.Redirect("Micropathologys.aspx");
            }

            else
            {
                MessageBox.Show("Page Down!");
            }
        }
    }
}