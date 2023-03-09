<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PubliseringLogin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
</head>
<body>
<form id="form1" runat="server">
  <div>
    <asp:Button ID="DefaultRedirect" runat="server" Text="Tilbake til hovedsiden" OnClick="DefaultRedirect_Click" />
  </div>
    <h1> Logg inn med Administrator passord for å redigere nettsiden.</h1>
  <asp:Panel ID="LoginPanel" runat="server" DefaultButton="LoginButton">
    <asp:TextBox ID="PasswordCheck" runat="server" TextMode="Password" ></asp:TextBox>
    <asp:Button ID="LoginButton" runat="server" Text="Logg inn" OnClick="LoginButton_Click" /><br />
    <asp:Label ID="WrongPassword" runat="server" Text="WrongPassword" Visible="false"></asp:Label>
  </asp:Panel><br />
    <a href="ChangePassword.aspx">Change password</a>
</form>
</body>
</html>
