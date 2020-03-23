<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addPersonType.aspx.cs" Inherits="Presentacion.addPersonType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Register Person Type</h1>
    <a class="nav-link" href="index.html">Home</a>
    <br/>
        <asp:label ID="lblMensaje" runat="server" ForeColor="Blue" EnableViewState="false"></asp:label>
    <br />
    <form id="form1" runat="server">
        <div>
            <table style="border:2px solid #cccccc;">
                <tr style="background-color:#507CD1; color:white">
                    <th colspan="3">Add</th>
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
                        <asp:Button ID="btnActualizar" runat="server" Text="Update" OnClick="btnActualizar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnEnviar" runat="server" Text="Register" OnClick="btnEnviar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnMostrar" runat="server" Text="List" OnClick="btnMostrar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnEliminar" runat="server" Text="Delete" OnClick="btnEliminar_Click" />
                    </td>
                </tr>

                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center;">
                        <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="Tipo"/>
                                <asp:BoundField DataField="nombre_tipo" HeaderText="NomTipo"/>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
