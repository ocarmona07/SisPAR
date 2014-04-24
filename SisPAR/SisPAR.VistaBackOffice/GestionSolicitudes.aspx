<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="GestionSolicitudes.aspx.cs" Inherits="SisPAR.VistaBackOffice.GestionSolicitudes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <asp:Table runat="server" HorizontalAlign="Center" CellSpacing="0" CellPadding="0"
        Style="margin-bottom: -1px;">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                <asp:Button ID="btnSolicitud" runat="server" Text="Solicitud" Width="140px" Height="40px"
                    CssClass="tablaTabs tablaTabsInactivo" Enabled="False" OnClick="TabSolicitud" />
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:Button ID="btnEvento" runat="server" Text="Evento" Width="130px" Height="40px"
                    CssClass="tablaTabs tablaTabsActivo" OnClick="TabEvento" />
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:Button ID="btnConsultas" runat="server" Text="Consultas" Width="140px" Height="40px"
                    CssClass="tablaTabs tablaTabsActivo" />
            </asp:TableCell>
            <asp:TableCell runat="server" Width="480px" />
        </asp:TableRow>
    </asp:Table>
    <asp:Table ID="tblSolicitud" runat="server" HorizontalAlign="Center" CssClass="tablaTabsCampo">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" Width="120px" HorizontalAlign="Right" VerticalAlign="Middle"
                Text="Sistema: " />
            <asp:TableCell runat="server" Width="330px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbSistema" runat="server" ReadOnly="True" Width="200px" />
            </asp:TableCell>
            <asp:TableCell runat="server" Width="130px" HorizontalAlign="Right" VerticalAlign="Middle"
                Text="Fecha de Ingreso: " />
            <asp:TableCell runat="server" Width="280px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbFechaIngreso" runat="server" ReadOnly="True" Width="100px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Módulo: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbModulo" runat="server" ReadOnly="True" Width="200px" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Fecha de Cierre: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbFechaCierre" runat="server" ReadOnly="True" Width="100px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="ID: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbId" runat="server" ReadOnly="True" Width="80px" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Impacto: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbImpacto" runat="server" ReadOnly="True" Width="150px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Solicitante: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" ColumnSpan="3">
                <asp:TextBox ID="tbSolicitante" runat="server" ReadOnly="True" Width="250px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Archivo adjunto: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" ColumnSpan="3">
                <asp:TextBox ID="tbArchivoAdjunto" runat="server" ReadOnly="True" Width="460px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Glosa Usuario: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" ColumnSpan="3">
                <asp:TextBox ID="tbGlosaUsuario" runat="server" Width="700px" Height="80px" TextMode="MultiLine" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Glosa Técnica: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" ColumnSpan="3">
                <asp:TextBox ID="tbGlosaTecnica" runat="server" Width="700px" Height="80px" TextMode="MultiLine" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Asignado a: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="ddlAsignado" runat="server" Width="300px" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Impacto: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="ddlImpacto" runat="server" Width="170px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Responsable: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="tbResponsable" runat="server" Width="300px" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Estado: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="ddlEstado" runat="server" Width="130px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Tipo: " />
            <asp:TableCell runat="server">
                <asp:DropDownList ID="ddlTipo" runat="server" Width="250px" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Subtipo: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="ddlSubtipo" runat="server" Width="250px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" ColumnSpan="4">
                <asp:Table runat="server" Width="700px" HorizontalAlign="Center">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" Height="50px" HorizontalAlign="Center" VerticalAlign="Bottom">
                            <asp:Button ID="btnSolicitudModificar" runat="server" Width="120px" Height="30px"
                                Text="Modificar" />
                        </asp:TableCell>
                        <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                            <asp:Button ID="btnSolicitudRestablecer" runat="server" Width="120px" Height="30px"
                                Text="Restablecer" />
                        </asp:TableCell>
                        <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                            <asp:Button ID="btnSolicitudImprimir" runat="server" Width="120px" Height="30px"
                                Text="Imprimir" />
                        </asp:TableCell>
                        <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Bottom">
                            <asp:Button ID="btnSolicitudAtras" runat="server" Width="120px" Height="30px" Text="Atrás" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Table ID="tblEvento" runat="server" HorizontalAlign="Center" CssClass="tablaTabsCampo"
        Visible="False">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" Width="434px" Height="80px" HorizontalAlign="Center"
                VerticalAlign="Middle">
                <asp:Button ID="btnCrearEvento" runat="server" Text="Crear Evento" Width="130px"
                    Height="25px" />
            </asp:TableCell>
            <asp:TableCell runat="server" Width="434px" HorizontalAlign="Center" VerticalAlign="Middle">
                <asp:Button ID="btnEventoAtras" runat="server" Text="Atrás" Width="100px" Height="25px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="tbrGrillaEventos" runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" ColumnSpan="2">
                <asp:GridView ID="gvEventos" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField HeaderText="Número">
                            <ItemTemplate>
                                <asp:Label ID="lblNumero" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="80px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fecha">
                            <ItemTemplate>
                                <asp:Label ID="lblFecha" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="80px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Estado">
                            <HeaderStyle Width="90px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tipo">
                            <HeaderStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Archivo Adjunto">
                            <HeaderStyle Width="80px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Glosa">
                            <HeaderStyle Width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Responsable">
                            <HeaderStyle Width="150px" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="tbcCrearEvento" runat="server" Visible="True">
            <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" ColumnSpan="2"
                Style="padding-top: 30px;">
                <asp:Table runat="server" HorizontalAlign="Center" BorderWidth="1px" CellPadding="5">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:Label runat="server" Text=" Nuevo Evento " Width="110px" BackColor="white" Style="margin-top: -15px; padding-left: 10px; display: block;" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Requerimiento: "
                            Width="200px" />
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" Width="500px">
                            <asp:DropDownList ID="ddlEventoRequerimiento" runat="server" Width="210px" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Estado: " />
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:TextBox ID="tbEventoEstado" runat="server" Width="100px" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server" Visible="True">
                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Nombre Responsable: " />
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:TextBox ID="tbEventoNombreResponsable" runat="server" Width="200px" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server" Visible="True">
                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Descripción: " />
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:TextBox ID="tbEventoDescripcion" runat="server" Width="400px" Height="60px" TextMode="MultiLine" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server" Visible="True">
                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Fecha: " />
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:TextBox ID="tbEventoFecha" runat="server" Width="100px" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server" Visible="True">
                        <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" ColumnSpan="2">
                            <asp:Table runat="server" HorizontalAlign="Center" CellPadding="20">
                                <asp:TableRow runat="server">
                                    <asp:TableCell runat="server">
                                        <asp:Button ID="btnEventoCrear" runat="server" Text="Crear" Width="100px" Height="25px" />
                                    </asp:TableCell>
                                    <asp:TableCell runat="server">
                                        <asp:Button ID="btnEventoLimpiar" runat="server" Text="Limpiar" Width="100px" Height="25px" />
                                    </asp:TableCell>
                                    <asp:TableCell runat="server">
                                        <asp:Button ID="btnEventoCancelar" runat="server" Text="Cancelar" Width="100px" Height="25px" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
