<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PubliseringLogin.Default" %>

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
                <a href="Default.aspx" class="active">Home</a>
                <a href="ArlyPage.aspx">Arly</a>
                <a href="Restricted.aspx">Restricted</a>
                <asp:LoginStatus ID="LoginStatus1" class="topnav-right" runat="server" />
                
                <a href="javascript:void(0);" class="icon" onclick="myFunction()">
                <i class="fa fa-bars"></i>
                </a>
            </div><br />
            <center>
                <%--Label for å vise tekst hentet fra database. Denne henter fra "kol1" i databasen.--%>
                <div class="MID">
                    <asp:Label ID="Kolonne1" runat="server" Text="Label"></asp:Label>   
                </div>
            </center>
        </div>
    </form>
</body>
</html>
