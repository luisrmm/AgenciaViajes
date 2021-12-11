<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLugares.aspx.cs" Inherits="ProyectoV2.frmLugares" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/Lugares.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="FormRegistroProductos">
            <asp:Label ID="Label1" runat="server" Text="Nombre Lugar"></asp:Label>
            <br />
            <asp:TextBox ID="txtnombreLugar" CssClass="controls" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2"  runat="server" Text="foto"></asp:Label>
            <br />
            <asp:TextBox ID="txtfoto" CssClass="controls" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3"  runat="server" Text="ubicacion"></asp:Label>
            <br />
            <asp:TextBox ID="txtubicacion" CssClass="controls" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4"  runat="server" Text="cantidad"></asp:Label>
            <br />
            <asp:TextBox ID="txtcantH" CssClass="controls" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Camas"></asp:Label>
            <br />
            <asp:TextBox ID="txtCantCamas" CssClass="controls" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="monto"></asp:Label>
            <br />
            <asp:TextBox ID="txtmonto" CssClass="controls" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server"  Text="Tipo lugar"></asp:Label>
            <br />
            <asp:DropDownList ID="DBTipoLugar" CssClass="controls" runat="server">
                <asp:ListItem>Seleccione</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server"  Text="Detalle"></asp:Label>
            <br />
            <asp:TextBox ID="TxtDetalle" CssClass="controls" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Codigo Proveedor"></asp:Label>
            <br />
            <asp:DropDownList ID="DpProveedor" CssClass="controls" runat="server" OnSelectedIndexChanged="DpProveedor_SelectedIndexChanged">
                <asp:ListItem>Seleccione</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="bntIngresar" CssClass="BOTON" runat="server" Text="Registrar Lugares" OnClick="bntIngresar_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

