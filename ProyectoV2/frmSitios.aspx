<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSitios.aspx.cs" Inherits="ProyectoV2.frmSitios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/MenuClientes/Styles.css" rel="stylesheet" />
    <link href="css/Sitios/styles.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="FormRegistroProductos">
            <asp:Label ID="Label1" runat="server" Text="Nombre del Sitio"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtsitio" CssClass="controls" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2"  runat="server" Text="Proveedor"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DpProveedor" CssClass="controls" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Estado"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DpEstado" CssClass="controls" runat="server">
                <asp:ListItem>Seleccione</asp:ListItem>
                <asp:ListItem>Inactivo</asp:ListItem>
                <asp:ListItem>No disponible</asp:ListItem>
                <asp:ListItem>Activo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" CssClass="BOTON" Text="Agregar Sitio" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
