<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="AgregarAlumno.aspx.vb" Inherits="ISNP139222_ISNP100522_UNIDAD_4.AgregarAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 class="text-center">
        <br />
        <strong>FORMULARIO</strong></h3>
    <table align="center" style="width: 80%; border-style: solid; border-width: 1px; background-color: #E4B9B9">
        <tr>
            <td class="text-center" colspan="2"><strong>AGREGAR ALUMNOS</strong></td>
        </tr>
        <tr>
            <td class="text-left" style="width: 247px">CODIGO</td>
            <td>
                
                <asp:TextBox ID="txtCodigo" runat="server" Width="133px"></asp:TextBox>
                
                <asp:RequiredFieldValidator ID="rfvCodigo" runat="server" ControlToValidate="txtCodigo" ErrorMessage="Codigo Requerido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-left" style="width: 247px">NOMBRE</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" Width="277px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Nombre obligatorio"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-left" style="width: 247px">APELLIDO</td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server" Width="276px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="Apellido Requerido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-left" colspan="2">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
            </td>
        </tr>
    </table>
</asp:Content>
