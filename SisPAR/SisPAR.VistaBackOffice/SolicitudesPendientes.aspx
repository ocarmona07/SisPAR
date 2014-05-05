<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="SolicitudesPendientes.aspx.cs" Inherits="SisPAR.VistaBackOffice.SolicitudesPendientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:Table runat="server" HorizontalAlign="Center">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Center" Text="Solicitudes Pendientes"
                CssClass="subtitulo" />
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                <asp:GridView ID="gvSolicitudes" runat="server" AutoGenerateColumns="False" Width="650px">
                    <Columns>
                        <asp:BoundField HeaderText="Sistema" DataField="Sistema" ItemStyle-Width="150px" />
                        <asp:BoundField HeaderText="Responsable" DataField="Responsable" ItemStyle-Width="200px" />
                        <asp:BoundField HeaderText="Pendientes" DataField="Responsable" ItemStyle-Width="150px" />
                        <asp:BoundField HeaderText="No asignadas" DataField="Responsable" ItemStyle-Width="150px" />
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" Height="70px" />
        </asp:TableRow>
    </asp:Table>
</asp:Content>
