<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="ISNP139222_ISNP100522_UNIDAD_4.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 50%;
            border: 2px solid #000000;
            background-color: #0099CC;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            text-align: center;
            width: 177px;
            color: #FFFFFF;
        }
        .auto-style7 {
            text-align: center;
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            <div class="auto-style3">
                <br />
                INICIO DE SESION<br />
                <br />
                <br />
            </div>
            <table align="center" class="auto-style2">
                <tr>
                    <td class="auto-style7" colspan="2">Ingrese su Usuario y Clave</td>
                </tr>
                <tr>
                    <td class="auto-style6"><strong>USUARIO</strong></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtUsuario" placeholder="Usuario" runat="server" Width="235px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"><strong>CLAVE</strong></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtClave" runat="server" placeholder="Clave" type="password" Width="234px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Button ID="btnIniciar" runat="server" Text="INGRESAR" Width="156px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
