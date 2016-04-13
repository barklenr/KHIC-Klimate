﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RaiderRadar.aspx.cs" Inherits="MountUnionClimate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Raider Radar</title>

    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="style.css" rel="stylesheet" />
    <link href="content/bootstrap.css" rel="stylesheet" />
    <link href="content/bootstrap-theme.css" rel="stylesheet" />
    <script src="scripts/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="css/bootstrap-theme.min.css" />
    <script type="text/javascript" src="https://code.jquery.com/jquery-1.11.3.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="scripts/bootstrap.js"></script>
    <!--[if IE]>
  <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
<![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <%--Navbar at the top of the page--%>
            <nav class="navbar navbar-inverse navbar navbar-fixed-top">
                <div class="container-fluid">
                    <!-- Brand and toggle get grouped for better mobile display -->
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="#">Raider Radar</a>
                    </div>

                    <!-- Collect the nav links, forms, and other content for toggling -->
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                        <ul class="nav navbar-nav">
                            <li><a href="http://www.mountunion.edu/" target="_blank">Mount Union Homepage</a></li>
                            <li><a href="http://raider.mountunion.edu/cs/" target="_blank">CSIS Homepage</a></li>
                            <li><a href="http://raider.mountunion.edu/~weather/Bracy_Vantage_Pro_Plus.htm" target="_blank">Bracy Weather</a></li>
                        </ul>

                    </div>
                    <!-- /.navbar-collapse -->
                </div>
                <!-- /.container-fluid -->
            </nav>
            <%--End of the top of the page navbar--%>

            <%-- This is the jumbotron and will also hold the camera--%>
            <div class="container text-center">
                <div class="jumbotron">
                     <center><img src="http://10.18.32.100/mjpg/video.mjpg" class="img-responsive" height="1000" width="1000"  /></center>
                </div>
            </div>
            <%--End of the Jumbotron--%>

            <%--This is the Bracy Weather Data--%>
            <div class="container text-center">
            <table class="table table-hover">
            <%--<asp:TextBox ID="txtData" runat="server" TextMode="MultiLine"></asp:TextBox>--%>
            <asp:Panel ID="Panel" runat="server">
                <tr>
                    <td>
                    <asp:Label ID="lblCurrentTemperature" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                    <asp:Label ID="lblHumidity" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                    <asp:Label ID="lblWind" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                    <asp:Label ID="lblBarometer" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                    <asp:Label ID="lblTodaysRain" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                    <asp:Label ID="lblWindChill" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                    <asp:Label ID="lblHighTemperature" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                    <asp:Label ID="lblLowTemperature" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </asp:Panel>
            </table>
            </div>
            <%--This is the end of Bracy Weather Data--%>

            <%--This is the timelapse--%>
            <div class="container text-center">
               <iframe src="https://silver.mountunion.edu:50039/cloudware/raiderradartimelapse.aspx" width="100%" height="575" scrolling="no" frameborder="0"></></iframe>
            </div>
            <%--This is the end of the timelapse--%>

            <%--This is the Weather Channel Radar--%>
            <div class="embed-container maps">
            <iframe id="MyIFrame" runat="server" scrolling="yes" width="100%" height="768px" frameborder="0"></iframe>
            </div>
            <%--This is the end of the Weather Channel Radar--%>

            <%--Start of the footer--%>
            <footer>
                <div class="row text-center">
                    <div class="col-lg-12">
                        <h3><a href="AboutUs.aspx" target="_blank">About Us</a> | <a href="https://raiderradar.wordpress.com" target="_blank">WordPress Blog</a></h3>
                    </div>
                </div>
            </footer>
            <%--End of the footer--%>
        </div>
    </form>
</body>
</html>
