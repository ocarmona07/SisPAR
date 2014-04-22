<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Requerimientos.aspx.cs" Inherits="SisPAR.VistaFrontOffice.Requerimientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div>
        <form>
        <fieldset>
            <asp:Button ID="button1" runat="server" Text="Nuevo Requerimiento" />
            <br />
            <br />
            <label for="fecha_dia">
                Seleccione Rango:</label>
            <br />
            <input type="text" size="3" maxlength="2" id="fecha_dia" name="fecha_dia" />
            de
            <select id="fecha_mes" name="fecha_mes">
                <option value="1">Enero</option>
                <option value="2">Febrero</option>
                <option value="3">Marzo</option>
                <option value="4">Abril</option>
                <option value="5">Mayo</option>
                <option value="6">Junio</option>
                <option value="7">Julio</option>
                <option value="8">Agosto</option>
                <option value="9">Septiembre</option>
                <option value="10">Octubre</option>
                <option value="11">Noviembre</option>
                <option value="12">Diciembre</option>
            </select>
            <input type="text" size="5" maxlength="4" id="fecha_año" name="fecha_ano" />
        </fieldset>
        <br />
        <br />
        <input type="text" size="53" name="nombre" value="" />
        <asp:Button ID="button2" runat="server" Text="Buscar Requerimiento" />
        <fieldset>
            <legend>Seleccionar los procesos</legend>
            <br />
            <label>
                Promoción:</label>
            <br />
            <input type="radio" name="promocion" value="ninguno" checked="checked" />
            Proceso
            <br />
            <input type="radio" name="promocion" value="portes" />
            Sub Proceso
            <br />
            <input type="radio" name="promocion" value="descuento" />
            Estado
            <br />
            <table style="width: 820px">
                <tr>
                    <th>
                        Firstname
                    </th>
                    <th>
                        Lastname
                    </th>
                    <th>
                        Points
                    </th>
                    <th>
                        Points
                    </th>
                    <th>
                        Points
                    </th>
                    <th>
                        Points
                    </th>
                </tr>
                <tr>
                    <td>
                        Jill
                    </td>
                    <td>
                        Smith
                    </td>
                    <td>
                        50
                    </td>
                    <td>
                        50
                    </td>
                    <td>
                        50
                    </td>
                    <td>
                        50
                    </td>
                </tr>
                <tr>
                    <td>
                        Eve
                    </td>
                    <td>
                        Jackson
                    </td>
                    <td>
                        94
                    </td>
                    <td>
                        94
                    </td>
                    <td>
                        94
                    </td>
                    <td>
                        94
                    </td>
                </tr>
                <tr>
                    <td>
                        John
                    </td>
                    <td>
                        Doe
                    </td>
                    <td>
                        80
                    </td>
                    <td>
                        80
                    </td>
                    <td>
                        80
                    </td>
                    <td>
                        80
                    </td>
                </tr>
            </table>
        </fieldset>
        </form>
    </div>
</asp:Content>
