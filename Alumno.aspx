<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Alumno.aspx.vb" Inherits="ISNP139222_ISNP100522_UNIDAD_4.Alumno1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center">LISTADO ALUMNOS</h2>
    <asp:PlaceHolder ID="estudiantes" runat="server" />

    <br />
    <a runat="server" href="~/AgregarAlumno">NUEVO ALUMNO</a>

</asp:Content>
