using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.IO;
using System.Web.Mail;

namespace Micropathologys
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        private System.Net.Mail.MailMessage obj;

        protected void Page_Load(object sender, EventArgs e)
        {
            string Email = TextBox5.Text;
            SmtpClient servers = new SmtpClient();
            servers.Timeout = 150;
            servers.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["EmailAddress"].ToString(), ConfigurationManager.AppSettings[""].ToString());
            servers.Port = System.Convert.ToInt32(ConfigurationManager.AppSettings["Port"].ToString()); ;
            servers.Host = ConfigurationManager.AppSettings["Hostname"].ToString();
            servers.EnableSsl = false;
            obj = new System.Net.Mail.MailMessage();
            obj.From = new MailAddress(TextBox5.Text, "Email confirmation", System.Text.Encoding.UTF8);
            obj.To.Add(ConfigurationManager.AppSettings["EmailAddress"]);
            obj.Priority = System.Net.Mail.MailPriority.High;
            obj.Subject = TextBox5.Text;
            obj.Body = "  EmailAddress: " + TextBox5;
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
                    MessageBox.Show("You have sign up :D"); 
                }

                
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