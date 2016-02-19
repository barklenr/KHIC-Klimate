<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MountUnionClimate.aspx.cs" Inherits="MountUnionClimate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mount Union Climate</title>

<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
<link href="content/bootstrap.css" rel="stylesheet"/>
<link href="content/bootstrap-theme.css" rel="stylesheet"/>
<script src="scripts/bootstrap.js"></script>
<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css"/>
<link rel="stylesheet" type="text/css" href="css/bootstrap-theme.min.css"/>
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
      <a class="navbar-brand" href="#">Mount Union Climate</a>
    </div>

    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      <ul class="nav navbar-nav">
           <li class="dropdown">
          <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Home <span class="caret"></span></a>
          <ul class="dropdown-menu">
            <li><a href="#">Action</a></li>
            <li><a href="#">Another action</a></li>
            <li><a href="#">Something else here</a></li>
            <li role="separator" class="divider"></li>
            <li><a href="#">Separated link</a></li>
            <li role="separator" class="divider"></li>
            <li><a href="#">One more separated link</a></li>
          </ul>
        </li>
        <li><a href="http://www.mountunion.edu/">Mount Union Homepage</a></li>
        <li><a href="http://raider.mountunion.edu/cs/">CSIS Homepage</a></li>
         <li><a href="#">Mount Union Weather</a></li> 
      </ul>
   
    </div><!-- /.navbar-collapse -->
  </div><!-- /.container-fluid -->
</nav>
<%--End of the top of the page navbar--%>


<img src="http://192.168.173.24/mjpg/video.mjpg" height="240" width="350"/>
       

<%--Start of the footer--%>
    <div class="navbar navbar-inverse navbar-fixed-bottom">
        <div class="container">
            <h2>This site was built by Cloudware</h2>
         </div>
    </div>
<%--End of the footer--%>

    </div>
    </form>
</body>
</html>
