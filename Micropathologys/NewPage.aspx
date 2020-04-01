<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewPage.aspx.cs" Inherits="Micropathologys.NewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" Height="230px" OnTextChanged="TextBox1_TextChanged" Width="473px"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="475px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
