﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="GestionSolicitudes.aspx.cs" Inherits="SisPAR.VistaBackOffice.GestionSolicitudes"
    Culture="Auto" UICulture="Auto" %>

<%@ Register TagPrefix="act" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=4.1.7.1213, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function ValidarFechas() {
            var mensaje = 'La Fecha Hasta no debe ser superior a la Fecha Desde';

            var fechaDesde = document.getElementById("<%= tbConsultasFechaDesde.ClientID %>").value;
            var xDay = fechaDesde.substring(0, 2);
            var xMonth = fechaDesde.substring(3, 5);
            var xYear = fechaDesde.substring(6, 10);

            var fechaHasta = document.getElementById("<%= tbConsultasFechaHasta.ClientID %>").value;
            var yDay = fechaHasta.substring(0, 2);
            var yMonth = fechaHasta.substring(3, 5);
            var yYear = fechaHasta.substring(6, 10);
            if (xYear < yYear) {
                return true;
            } else {
                if (xYear == yYear) {
                    if (xMonth < yMonth) {
                        return true;
                    } else {
                        if (xMonth == yMonth) {
                            if (xDay <= yDay)
                                return true;
                            else {
                                alert(mensaje);
                                return false;
                            }
                        } else {
                            alert(mensaje);
                            return false;
                        }
                    }
                } else {
                    alert(mensaje);
                    return false;
                }
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <act:ToolkitScriptManager ID="tkmDate" runat="server" EnableScriptGlobalization="True"
        EnableScriptLocalization="True" />
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
                    CssClass="tablaTabs tablaTabsActivo" OnClick="TabConsultas" />
            </asp:TableCell>
            <asp:TableCell runat="server" Width="480px" />
        </asp:TableRow>
    </asp:Table>
    <asp:Table ID="tblSolicitud" runat="server" HorizontalAlign="Center" CssClass="tablaTabsCampo">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" Width="120px" HorizontalAlign="Right" VerticalAlign="Middle"
                Text="Sistema: " />
            <asp:TableCell runat="server" Width="330px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbSolicitudSistema" runat="server" ReadOnly="True" Width="200px" />
            </asp:TableCell>
            <asp:TableCell runat="server" Width="130px" HorizontalAlign="Right" VerticalAlign="Middle"
                Text="Fecha de Ingreso: " />
            <asp:TableCell runat="server" Width="280px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbSolicitudFechaIngreso" runat="server" ReadOnly="True" Width="100px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Módulo: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbSolicitudModulo" runat="server" ReadOnly="True" Width="200px" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Fecha de Cierre: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbSolicitudFechaCierre" runat="server" ReadOnly="True" Width="100px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="ID: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbSolicitudId" runat="server" ReadOnly="True" Width="80px" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Impacto: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbSolicitudImpacto" runat="server" ReadOnly="True" Width="150px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Solicitante: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" ColumnSpan="3">
                <asp:TextBox ID="tbSolicitudSolicitante" runat="server" ReadOnly="True" Width="250px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Archivo adjunto: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" ColumnSpan="3">
                <asp:TextBox ID="tbSolicitudArchivoAdjunto" runat="server" ReadOnly="True" Width="460px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Glosa Usuario: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" ColumnSpan="3">
                <asp:TextBox ID="tbSolicitudGlosaUsuario" runat="server" Width="700px" Height="80px"
                    TextMode="MultiLine" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Glosa Técnica: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" ColumnSpan="3">
                <asp:TextBox ID="tbSolicitudGlosaTecnica" runat="server" Width="700px" Height="80px"
                    TextMode="MultiLine" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Asignado a: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="ddlSolicitudAsignado" runat="server" Width="300px" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Impacto: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="ddlSolicitudImpacto" runat="server" Width="170px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Responsable: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="ddlSolicitudResponsable" runat="server" Width="300px" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Estado: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="ddlSolicitudEstado" runat="server" Width="130px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Tipo: " />
            <asp:TableCell runat="server">
                <asp:DropDownList ID="ddlSolicitudTipo" runat="server" Width="250px" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Subtipo: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="ddlSolicitudSubtipo" runat="server" Width="250px" />
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
                            <asp:Button ID="btnSolicitudAtras" runat="server" Width="120px" Height="30px" Text="Atrás"
                                PostBackUrl="AtencionRequerimientos.aspx" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Table ID="tblEvento" runat="server" HorizontalAlign="Center" CssClass="tablaTabsCampo"
        Visible="False">
        <asp:TableRow ID="tbrBotonesEventos" runat="server">
            <asp:TableCell runat="server" Width="434px" Height="80px" HorizontalAlign="Center"
                VerticalAlign="Middle">
                <asp:Button ID="btnCrearEvento" runat="server" Text="Crear Evento" Width="130px"
                    Height="25px" OnClick="CrearEvento" />
            </asp:TableCell>
            <asp:TableCell runat="server" Width="434px" HorizontalAlign="Center" VerticalAlign="Middle">
                <asp:Button ID="btnEventoAtras" runat="server" Text="Atrás" Width="100px" Height="25px"
                    PostBackUrl="AtencionRequerimientos.aspx" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="tbrGrillaEventos" runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" ColumnSpan="2">
                <asp:GridView ID="gvEventos" runat="server" AutoGenerateColumns="False" Width="760px"
                    OnRowCommand="EventosRowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="Número" DataField="EVE_ID" ItemStyle-Width="80px" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField HeaderText="Fecha" DataField="EVE_FECHA" DataFormatString="{0:dd/MM/yyyy}"
                            ItemStyle-Width="80px" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField HeaderText="Estado" DataField="EST_ESTADOS.EST_TIPO" ItemStyle-Width="100px"
                            ItemStyle-HorizontalAlign="Center" />
                        <asp:TemplateField HeaderText="Archivo Adjunto">
                            <ItemTemplate>
                                <asp:ImageButton runat="server" ID="ibAdjunto" ImageUrl="images/download-file.png"
                                    ToolTip="Descargar adjunto" CommandName="Descargar" CommandArgument='<%# Eval("EVE_ADJUNTO") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                            <HeaderStyle Width="80px" />
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Glosa" DataField="EVE_DESCRIPCION" ItemStyle-Width="300px" />
                        <asp:BoundField HeaderText="Responsable" DataField="EVE_RESPONSABLE" ItemStyle-Width="150px"
                            ItemStyle-HorizontalAlign="Center" />
                        <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:ImageButton runat="server" ID="ibEditar" ImageUrl="images/edit.gif" ToolTip="Editar"
                                    CommandName="Editar" CommandArgument='<%# Eval("EVE_ID") %>' />
                                <asp:Label runat="server" Text=" / " />
                                <asp:ImageButton runat="server" ID="ibEliminar" ImageUrl="images/delete.gif" ToolTip="Eliminar"
                                    CommandName="Eliminar" CommandArgument='<%# Eval("EVE_ID") %>' OnClientClick="javascript: return confirm('¿Desea eliminar el evento seleccionado?');" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                            <HeaderStyle Width="60px" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="tbcCrearEvento" runat="server" Visible="False">
            <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" ColumnSpan="2"
                Style="padding-top: 30px;">
                <asp:HiddenField ID="hdnIdEvento" runat="server" />
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
                            <asp:DropDownList ID="ddlEventoRequerimiento" runat="server" Width="210px" ValidationGroup="CrearEvento" />
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" CssClass="Validador"
                                ControlToValidate="ddlEventoRequerimiento" InitialValue="0" ValidationGroup="CrearEvento" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Estado: " />
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:DropDownList ID="ddlEventoEstado" runat="server" Width="100px" ValidationGroup="CrearEvento" />
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" CssClass="Validador"
                                ControlToValidate="ddlEventoEstado" InitialValue="0" ValidationGroup="CrearEvento" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Archivo Adjunto: " />
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:ImageButton ID="ibEventoAdjunto" runat="server" Visible="False" ImageUrl="images/download-file.png"
                                OnClick="EventoAdjuntoOnClick" Style="margin-right: 10px;" />
                            <asp:FileUpload ID="fupEventoAdjunto" runat="server" Width="400px" />
                            <asp:RequiredFieldValidator ID="rfvAdjunto" runat="server" ErrorMessage="*" CssClass="Validador"
                                ControlToValidate="fupEventoAdjunto" InitialValue="" ValidationGroup="CrearEvento" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Nombre Responsable: " />
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:TextBox ID="tbEventoNombreResponsable" runat="server" Width="200px" ValidationGroup="CrearEvento" />
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" CssClass="Validador"
                                ControlToValidate="tbEventoNombreResponsable" InitialValue="" ValidationGroup="CrearEvento" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Descripción: " />
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:TextBox ID="tbEventoDescripcion" runat="server" Width="400px" Height="60px"
                                TextMode="MultiLine" ValidationGroup="CrearEvento" />
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" CssClass="Validador"
                                ControlToValidate="tbEventoDescripcion" InitialValue="" ValidationGroup="CrearEvento" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Fecha: " />
                        <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                            <asp:TextBox ID="tbEventoFecha" runat="server" Width="100px" ValidationGroup="CrearEvento"
                                CssClass="Fecha" />
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="*" CssClass="Validador"
                                ControlToValidate="tbEventoFecha" InitialValue="" ValidationGroup="CrearEvento" />
                            <act:CalendarExtender ID="calEventoFecha" runat="server" TargetControlID="tbEventoFecha" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" ColumnSpan="2">
                            <asp:Table runat="server" HorizontalAlign="Center" CellPadding="20">
                                <asp:TableRow runat="server">
                                    <asp:TableCell runat="server">
                                        <asp:Button ID="btnEventoCrear" runat="server" Text="Crear" Width="100px" Height="25px"
                                            OnClick="GuardarEvento" CausesValidation="True" ValidationGroup="CrearEvento" />
                                    </asp:TableCell>
                                    <asp:TableCell runat="server">
                                        <asp:Button ID="btnEventoLimpiar" runat="server" Text="Limpiar" Width="100px" Height="25px"
                                            OnClick="LimpiarCrearEvento" OnClientClick="javascript: return confirm('¿Desea limpiar los campos de evento?');" />
                                    </asp:TableCell>
                                    <asp:TableCell runat="server">
                                        <asp:Button ID="btnEventoCancelar" runat="server" Text="Cancelar" Width="100px" Height="25px"
                                            OnClick="CancelarEvento" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Table ID="tblConsultas" runat="server" HorizontalAlign="Center" CssClass="tablaTabsCampo"
        Visible="False">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" Width="130px" HorizontalAlign="Right" VerticalAlign="Middle"
                Text="Responsable: " />
            <asp:TableCell runat="server" Width="280px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="ddlConsultasResponsables" runat="server" Width="200px" />
            </asp:TableCell>
            <asp:TableCell runat="server" Width="120px" HorizontalAlign="Right" VerticalAlign="Middle"
                Text="Estado: " />
            <asp:TableCell runat="server" Width="330px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:DropDownList ID="ddlConsultasEstado" runat="server" Width="200px" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Fecha Desde: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbConsultasFechaDesde" runat="server" Width="100px" CssClass="Fecha" />
                <act:CalendarExtender ID="calConsultasDesde" runat="server" TargetControlID="tbConsultasFechaDesde" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Text="Fecha Hasta: " />
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TextBox ID="tbConsultasFechaHasta" runat="server" Width="100px" CssClass="Fecha" />
                <act:CalendarExtender ID="calConsultasHasta" runat="server" TargetControlID="tbConsultasFechaHasta" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" Height="60px"
                ColumnSpan="4">
                <asp:Button ID="btnConsultasConsultar" runat="server" Width="100px" Height="25px"
                    Text="Consultar" OnClick="ConsultasFiltrarOnClick" OnClientClick="javascript: return ValidarFechas();" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Center" VerticalAlign="Middle" Height="60px"
                ColumnSpan="4">
                <asp:GridView ID="gvConsultas" runat="server" AutoGenerateColumns="False" Width="760px"
                    OnRowCommand="EventosRowCommand" EmptyDataText="<div style='text-align: Center;'>No existen resultados</div>">
                    <Columns>
                        <asp:BoundField HeaderText="Número" DataField="EVE_ID" ItemStyle-Width="80px" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField HeaderText="Fecha" DataField="EVE_FECHA" DataFormatString="{0:dd/MM/yyyy}"
                            ItemStyle-Width="80px" ItemStyle-HorizontalAlign="Center" />
                        <asp:BoundField HeaderText="Estado" DataField="EST_ESTADOS.EST_TIPO" ItemStyle-Width="100px"
                            ItemStyle-HorizontalAlign="Center" />
                        <asp:TemplateField HeaderText="Archivo Adjunto">
                            <ItemTemplate>
                                <asp:ImageButton runat="server" ID="ibAdjunto" ImageUrl="images/download-file.png"
                                    ToolTip="Descargar adjunto" CommandName="Descargar" CommandArgument='<%# Eval("EVE_ADJUNTO") %>' />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                            <HeaderStyle Width="80px" />
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Glosa" DataField="EVE_DESCRIPCION" ItemStyle-Width="350px" />
                        <asp:BoundField HeaderText="Responsable" DataField="EVE_RESPONSABLE" ItemStyle-Width="150px"
                            ItemStyle-HorizontalAlign="Center" />
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" HorizontalAlign="Right" VerticalAlign="Middle" Height="60px"
                ColumnSpan="2">
                <asp:Button ID="btnConsultasExportar" runat="server" Width="100px" Height="25px"
                    Text="Exportar" Style="margin-right: 50px;" />
            </asp:TableCell>
            <asp:TableCell runat="server" HorizontalAlign="Left" VerticalAlign="Middle" ColumnSpan="2">
                <asp:Button ID="btnConsultasAtras" runat="server" Width="100px" Height="25px" Text="Atras"
                    Style="margin-left: 50px;" PostBackUrl="AtencionRequerimientos.aspx" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
