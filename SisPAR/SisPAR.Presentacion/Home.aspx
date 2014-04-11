<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SisPAR.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>SisPAR</title>
    <meta name="keywords" content="" />
    <meta name="description" content="" />
    <link href="http://fonts.googleapis.com/css?family=Varela" rel="stylesheet" />
    <link href="css/default.css" rel="stylesheet" type="text/css" media="all" />
    <link href="css/fonts.css" rel="stylesheet" type="text/css" media="all" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="wrapper">
        <div id="header" class="container">
            <div id="logo">
                <h1>
                    Sistema PAR</h1>
            </div>
        </div>
        <div id="banner">
            <div class="container">
                <div class="title">
                    <h2>
                        plataforma de atención de requerimiento</h2>
                </div>
            </div>
        </div>
    </div>
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
    </asp:Login>
    </form>
</body>
</html>
