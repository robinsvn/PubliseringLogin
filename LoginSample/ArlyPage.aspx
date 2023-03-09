<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArlyPage.aspx.cs" Inherits="PubliseringLogin.ArlyPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PubliseringLogin</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- Load an icon library to show a hamburger menu (bars) on small screens -->
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
           <%-- Default navbaren som er på alle sider. Active classfor å gi en grønn farge for å vise hvilken side du er på. Blir til hamburger meny om nettsiden er under 600px vidde.--%>
            <div class="topnav" id="myTopnav">
                    <a href="Default.aspx">Home</a>
                    <a href="ArlyPage.aspx" class="active">Arly</a>
                    <a href="Restricted.aspx">Restricted</a>
                    <asp:LoginStatus ID="LoginStatus1" runat="server" />
                <a href="javascript:void(0);" class="icon" onclick="myFunction()">
                <i class="fa fa-bars"></i>
                </a>
            </div>
            <center>
                <%--Label for å vise tekst hentet fra database. Denne henter fra "ArlyText" i databasen.--%>
            <div class="MID">
                <p class="label"><asp:Label ID="ArlyText" runat="server" Text="Label"></asp:Label>   </p> 
             </div>
                </center>
        </div>
    </form>
</body>
</html>