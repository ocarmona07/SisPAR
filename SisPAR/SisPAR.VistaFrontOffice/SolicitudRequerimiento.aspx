<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="SolicitudRequerimiento.aspx.cs" Inherits="SisPAR.VistaFrontOffice.SolicitudRequerimiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div>
        <form>
        <fieldset>
            <legend>Requerimiento</legend>
            <h1>
            </h1>
            <br />
            <br />
            <table border="1" width="100%">
                <tr>
                    <td>
                        <form method="post" action="">
                        Seleccione:
                        <select name="Choice">
                            <option value="">Proceso</option>
                            <option value="">1</option>
                            <option value="">2</option>
                        </select>
                        </form>
                    </td>
                    <td>
                        1
                    </td>
                    <td>
                        2
                    </td>
                    <td>
                        3
                    </td>
                </tr>
                <tr>
                    <td>
                        <form method="post" action="">
                        Seleccione:
                        <select name="Choice">
                            <option value="">SubProceso</option>
                            <option value="">1</option>
                            <option value="">2</option>
                        </select>
                        </form>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <td>
                    <legend>Descripción del Requerimiento:</legend>
                </td>
                <td>
                    <asp:TextBox runat="server" Width="400px" Height="100px" ID="tbDescripcion"></asp:TextBox>
                </td>
                <td>
                </td>
                <td>
                </td>
            </table>
            <h1>
            </h1>
    </div>
    <br />
    <br />
    <br />
    <fieldset>
        <legend>Datos del Usuario</legend>
    </fieldset>
    <br />
    <br />
    <br />
    <table>
        <asp:Button ID="button1" runat="server" Text="Enviar" /></table>
    <table>
        <asp:Button ID="button2" runat="server" Text="Limpiar" /></table>
    <table>
        <asp:Button ID="button3" runat="server" Text="Atrás" /></table>
</asp:Content>
