<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Restricted.aspx.cs" Inherits="PubliseringLogin.Restricted" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Restricted</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
     <link href="Styles.css" rel="stylesheet" />
    <script>
        function myFunction() {
          var x = document.getElementById("myTopnav");
          if (x.className === "topnav") {
            x.className += " responsive";
          } else {
            x.className = "topnav";
          }
        }
    </script>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <div class="topnav"id="myTopnav">
                <a href="Default.aspx">Home</a>
                <a href="ArlyPage.aspx">Arly</a>
                <a href="Restricted.aspx" class="active">Restricted</a>
                <asp:LoginStatus ID="LoginStatus1" runat="server" />
                
                <a href="javascript:void(0);" class="icon" onclick="myFunction()">
                <i class="fa fa-bars"></i>
                </a>
            </div><br />
        <asp:TextBox ID="ArlyTextbox" runat="server" TextMode="MultiLine"></asp:TextBox><br />
            <asp:Button ID="UpdateDB" runat="server" Text="Update" OnClick="UpdateDB_Click" style="width: 61px"/><br /><br /><br />
        <asp:TextBox ID="KolonneTextbox" runat="server" TextMode="MultiLine"></asp:TextBox><br />
            <asp:Button ID="UpdateKolonne" runat="server" Text="Update" OnClick="UpdateKolonne_Click" style="width: 61px"/>
        
        </div>
    </form>
</body>
</html>
