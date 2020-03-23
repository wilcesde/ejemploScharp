<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addPersona.aspx.cs" Inherits="Presentacion.addPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Registro datos persona</h1>
    <a class="nav-link" href="index.html">Home</a>
    <form id="form1" runat="server">
        <div>
            <table style="border:2px solid #cccccc;">
                <tr style="background-color:#507CD1; color:white">
                    <th colspan="3">Agregar Registro</th>
                </tr>
                <tr>
                    <td>
                        Id:
                    </td>
                    <td>
                        <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Nombre:
                    </td>
                    <td>
                        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Edad:
                    </td>
                    <td>
                        <asp:TextBox ID="txtedad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnMostrar" runat="server" Text="Listar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
