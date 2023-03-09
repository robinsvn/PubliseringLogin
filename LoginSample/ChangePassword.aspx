<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="PubliseringLogin.ChangePassword" %>

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
    <h1>Vennligst skriv inn forrige passord, også det nye passordet.</h1>
    <%--Change Password panel, hvor du må skrive inn gammelt passord og deretter nytt for å bytte.--%>
    <asp:Panel ID="ChangePasswordPanel" runat="server" DefaultButton="ChangePasswordButton">
        <asp:Label ID="OldPasswordText" runat="server" Text="Old Password"></asp:Label><br />
            <asp:TextBox ID="OldPasswordTextBox" runat="server" TextMode="Password" ></asp:TextBox><br /><br />
        <asp:Label ID="NewPasswordText" runat="server" Text="New Password"></asp:Label><br />
            <asp:TextBox ID="NewPasswordTextBox" runat="server" TextMode="Password" ></asp:TextBox><br /><br />
        <asp:Button ID="ChangePasswordButton" runat="server" Text="Change password" OnClick="ChangePasswordButton_Click" /><br /><br />
        <%--Label for å indikere om Passordet var feil, eller om passordet har blir endret. Når man har byttet passord, blir man også automatisk redirektet bort fra denne siden.--%>
        <asp:Label ID="WrongPassword" runat="server" Text="Det gamle passordet var feil." Visible="false"></asp:Label>
        <asp:Label ID="ChangedPassword" runat="server" Text="Passordet har blitt endret." Visible="false"></asp:Label>
  </asp:Panel>
</form>
</body>
</html>
