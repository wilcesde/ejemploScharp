<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cartType.aspx.cs" Inherits="Presentacion.cartType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Capas</title>
</head>
<body>
    <h1>Saludos!!!</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMensaje" runat="Server" ForeColor="red" EnableViewState="False" />
            <table style="border:2px solid #cccccc;">
                <tr style="background-color:#507CD1;color:White;">
                    <th colspan="3">Agregar Registros</th>
                </tr>
                <tr>
                    <td>
                        Type Id:
                    </td>
                    <td>
                        <asp:TextBox ID="txttypeid" runat="Server"></asp:TextBox>
                    </td>                    
                </tr>
                <tr>
                    <td>
                        Type Name:
                    </td>
                    <td>
                        <asp:TextBox ID="txttypename" runat="Server"></asp:TextBox>
                    </td>                    
                </tr>            
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="AgregarTv"/>
                    </td>
                    <td>
                        <asp:Button ID="Load" runat="server" Text="Mostrar" />
                    </td>
                </tr>
                <tr>
                    <td />
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="idtv" HeaderText="Id" />
                                <asp:BoundField DataField="nametv" HeaderText="Nombre" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
