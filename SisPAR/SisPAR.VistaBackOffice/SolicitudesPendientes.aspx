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
                <asp:GridView ID="gvSolicitudes" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField HeaderText="Sistema">
                            <ItemTemplate>
                                <asp:Label ID="lblSistema" runat="server" Text="" />
                            </ItemTemplate>
                            <HeaderStyle Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Responsable">
                            <ItemTemplate>
                                <asp:Label ID="lblResponsable" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Pendientes">
                            <HeaderStyle Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="No asignadas">
                            <HeaderStyle Width="150px" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" Height="70px" />
        </asp:TableRow>
    </asp:Table>
</asp:Content>
