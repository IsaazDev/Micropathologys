<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="Micropathologys.RegistrationPage" %>

<!DOCTYPE html>
<style>
html {
  height: 100%;
}
* {
  -webkit-box-sizing: border-box;
          box-sizing: border-box;
  margin: 0;
  padding: 0;
}
body {
  height: 100%;
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: vertical;
  -webkit-box-direction: normal;
      -ms-flex-direction: column;
          flex-direction: column;
}
.registration-wrapper {
  height: 100%;
  display: -webkit-box;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-pack: center;
      -ms-flex-pack: center;
          justify-content: center;
  -webkit-box-align: center;
      -ms-flex-align: center;
          align-items: center;
  background-image: url("https://i.ytimg.com/vi/1eeqZNn-k0Y/maxresdefault.jpg");
  background-size: cover;
  background-repeat: no-repeat;
  position: relative;
}
.registration-wrapper > * {
  z-index: 10;
}
.registration-wrapper::after {
  content: '';
  display: block;
  height: 100%;
  width: 100%;
  position: absolute;
  top: 0;
  left: 0;
  background: rgba(255, 255, 255, 0.2);
}
.registration-wrapper form {
  width: 100%;
  max-width: 360px;
  background-color: white;
  padding: 12px;
  -webkit-box-shadow: 0 1px 3px rgba(0, 0, 0, 0.12), 0 1px 2px rgba(0, 0, 0, 0.24);
          box-shadow: 0 1px 3px rgba(0, 0, 0, 0.12), 0 1px 2px rgba(0, 0, 0, 0.24);
}
</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <strong>Username</strong>
            </p>
            <asp:TextBox runat="server" Id ="Textbox3"  Text="TextBox1" required="required" />
            <p>
                <strong>Password</strong>
            </p>
                <asp:TextBox ID="TextBox5" runat="server" Text="TextBox5" required="required" ></asp:TextBox>
            <p>
            <strong>First Name</strong>
            </p>
            <asp:TextBox ID="FirstName" runat="server" Text="Firstname" required="required"  ></asp:TextBox>

                <p>
                <strong>Surname</strong>
                </p>
                <asp:TextBox ID="Surname" runat="server" Text="Surname" required="required" ></asp:TextBox>
            <p>
                <strong> Age </strong>
            </p>
            </p>
            </p>
            <asp:TextBox ID="Age" runat="server" Text="Age" required="required" ></asp:TextBox>
            <p>
                <strong> Email Address </strong>
            </p>
            <asp:TextBox ID="EmailAddress" runat="server" Text="EmailAddress" required="required" ></asp:TextBox>
           
        </div>
        <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
        </p>
        <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button9_Click" Text="Back" />
        </p>
    </form>
</body>
</html>
