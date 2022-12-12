<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Docente.aspx.vb" Inherits="ISNP139222_ISNP100522_UNIDAD_4.Docente1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2 class="text-center">LISTADO DOCENTES</h2>
    <asp:PlaceHolder ID="docentes" runat="server" />

    <br />
    <a runat="server" href="~/AgregarMaestro">NUEVO DOCENTE</a>
</asp:Content>
