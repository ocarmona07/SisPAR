<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SisPAR.VistaBackOffice.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>SisPAR - Sistema Plataforma de Atención de Requerimientos</title>
    <meta name="keywords" content="SISPAR" />
    <meta name="description" content="Sistema Plataforma de Atención de Requerimientos" />
    <link href="http://fonts.googleapis.com/css?family=Varela" rel="stylesheet" />
    <link href="css/default.css" rel="stylesheet" type="text/css" media="all" />
    <link href="css/fonts.css" rel="stylesheet" type="text/css" media="all" />
</head>
<body>
    <form id="frmInicio" runat="server">
    <br />
    <asp:Table runat="server" Width="990px" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom" Height="270px">
                <asp:Image runat="server" ImageUrl="~/images/LogoAguasNuevas.jpg" Style="padding-bottom: 30px;" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server" HorizontalAlign="Center" VerticalAlign="Middle">
            <asp:TableCell>
                <asp:Table runat="server" CellSpacing="10">
                    <asp:TableRow>
                        <asp:TableHeaderCell runat="server" Width="100px" Height="30px" HorizontalAlign="Right"
                            VerticalAlign="Middle">
                            <asp:Label runat="server" Text="Usuario:" />
                        </asp:TableHeaderCell>
                        <asp:TableCell runat="server" Width="200px" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:TextBox ID="tbUsuario" runat="server" MaxLength="12" Width="150px" ValidationGroup="Inicio"
                                OnKeyPress="IngresoTextoUsuario" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell runat="server" Height="30px" HorizontalAlign="Right" VerticalAlign="Middle">
                            <asp:Label runat="server" Text="Contraseña:" />
                        </asp:TableHeaderCell>
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:TextBox ID="tbPassword" runat="server" MaxLength="12" Width="150px" TextMode="Password"
                                ValidationGroup="Inicio" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" ColumnSpan="2"
                            Height="40px">
                            <asp:Button ID="btnEntrar" runat="server" Width="120px" Height="30px" Text="Entrar"
                                CausesValidation="True" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell runat="server" Height="200px" HorizontalAlign="Center" VerticalAlign="Bottom">
                <div class="copyright">
                    <asp:Label runat="server" ID="lblCopyright" />
                </div>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </form>
</body>
</html>
