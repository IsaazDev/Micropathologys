<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Micropathologys.aspx.cs" Inherits="Micropathologys.Micropathologys" %>

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
    <div class="registration-wrapper">
        <form id="form1" runat="server">
            <div>
                <p>
                    <strong>
                        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                    </strong>
                </p>
                <p>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </p>
                <p>
                        <p>
                            <strong>
                        <asp:Label ID="myInput" runat="server" Text="Password"></asp:Label>
                            </strong>
                <p>
                    <strong>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    </strong>
                </p>
                    
               
                <p>
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/>
                </p>
            <p>
         
                    <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button7_Click"/>
         
            </p>
            </div>
        </form>
    </div>
<script>
    function Password() {
        var p = document.getElementById("myInput");
        if (p.type === "password") {
            p.type = "text";
        }
        else {
            p.type = "password";
        }
    }
</script>
</body>
</html>
