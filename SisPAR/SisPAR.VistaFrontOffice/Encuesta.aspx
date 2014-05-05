<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Encuesta.aspx.cs" Inherits="SisPAR.Encuesta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="MG.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div>
        <asp:Table ID="Table3" runat="server" HorizontalAlign="Left" Width="900px" BorderWidth="0px"
            Height="50px" CssClass="Mtable">
            <asp:TableRow ID="TableRow3" runat="server">
                <asp:TableCell ID="TableCell5" runat="server">
                    <asp:Label ID="Label1" runat="server">Encuesta Satisfacción</asp:Label>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    <div style="padding-top: 80px;">
        <asp:Label runat="server">Queremos Brindar un mejor servicio,favor responder encuesta:</asp:Label>
        <asp:Table ID="Table1" runat="server" HorizontalAlign="Justify" Width="900px" BorderWidth="4px"
            Height="200px" CssClass="Mtable2" CellPadding="2" CellSpacing="1">
            <asp:TableRow ID="TableRow1" runat="server" BorderWidth="1">
                <asp:TableCell ID="TableCell2" runat="server" HorizontalAlign="Right" ColumnSpan="2">
                   
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    <div>
        <asp:Label runat="server">Observaciones:</asp:Label>
        <asp:Table ID="Table4" runat="server" HorizontalAlign="Left" Width="900px" BorderWidth="0px"
            Height="50px">
            <asp:TableRow ID="TableRow4" runat="server">
                <asp:TableCell ID="TableCell4" runat="server">
                    <asp:TextBox runat="server" Width="894px" Height="100px" ID="tbDescripcion"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    <asp:Table ID="Table2" runat="server" HorizontalAlign="Center" Width="800px">
        <asp:TableRow ID="TableRow2" runat="server">
            <asp:TableCell ID="TableCell3" runat="server">
                <asp:Button ID="button1" runat="server" Text="Enviar" Width="200px" Height="30px" />
            </asp:TableCell>
            <asp:TableCell ID="TableCell6" runat="server">
                <asp:Button ID="button3" runat="server" Text="Atrás" Width="200px" Height="30px" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
