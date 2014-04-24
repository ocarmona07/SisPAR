<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="AtencionRequerimientos.aspx.cs" Inherits="SisPAR.VistaBackOffice.AtencionRequerimientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:Table runat="server" HorizontalAlign="Center">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Center" Text="Atención de Requerimientos"
                CssClass="subtitulo" ColumnSpan="2" />
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Left" Width="220px" Style="padding-left: 30px" Text="Filtro" />
            <asp:TableCell runat="server" HorizontalAlign="Left" Text="Sistema" />
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Left" Style="padding-left: 30px">
                <asp:DropDownList ID="ddlFiltros" runat="server" Width="170px" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Left">
                <asp:DropDownList ID="ddlSistemas" runat="server" Width="130px" />                
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" ColumnSpan="2" Style="padding-top: 20px">
                <asp:GridView ID="gvRequerimientos" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField HeaderText="ID">
                            <HeaderStyle Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Sistema">
                            <HeaderStyle Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Módulo">
                            <ItemTemplate>
                                <asp:Label ID="lblModulo" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Derivada">
                            <HeaderStyle Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Solicitante">
                            <HeaderStyle Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Estado">
                            <HeaderStyle Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Recepción">
                            <HeaderStyle Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Empresa">
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
