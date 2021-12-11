<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProveedor.aspx.cs" Inherits="ProyectoV2.frmProveedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/Proveedores/Styles.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="FormRegistroProductos">
            <asp:Label ID="lblIdProveedor" runat="server" Text="IdProveedor"></asp:Label>
            <br />
            <asp:TextBox ID="txtIdProv" CssClass="controls" runat="server" Width="290px"></asp:TextBox>
            <br />
            <asp:Label ID="lblnombre" runat="server" Text="Nombre Proveedor"></asp:Label>
             <br />
            <asp:TextBox ID="txtNombre" CssClass="controls" runat="server" Width="291px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrimerApellido" runat="server" Text="PrimerApellido"></asp:Label>
            <br />
            <asp:TextBox ID="TxtPApellido" CssClass="controls" runat="server" Width="292px"></asp:TextBox>
            <br />
            <asp:Label ID="lblSegundoApellido" runat="server" Text="Segundo Apellido"></asp:Label>
            <br />
            <asp:TextBox ID="txtSApellido" CssClass="controls" runat="server" Width="294px"></asp:TextBox>
            <br />
            <asp:Label ID="lblemail" runat="server" Text="Correo Electronico"></asp:Label>
            <br />
            <asp:TextBox ID="txtCorreo" CssClass="controls" runat="server" Width="295px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDireccion" runat="server" Text="Direccion"></asp:Label>
            <br />
            <asp:TextBox ID="txtDireccion" CssClass="controls" runat="server" Height="43px" Width="298px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNacionalidad" runat="server" Text="Nacionalidad"></asp:Label>
            <br />
            <asp:DropDownList ID="dbProveedor" CssClass="controls" runat="server" Width="316px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
            <br />
            <asp:TextBox ID="txtEstado" CssClass="controls" runat="server" Width="295px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblContrasena" runat="server" Text="Contraseña"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassword" CssClass="controls" runat="server" Width="294px"></asp:TextBox>
            <br />
            <br />
            <%--            <asp:Button ID="btnRegistrarse" runat="server" OnClick="btnRegistrarse_Click" Text="Registrarse" />--%>
            <asp:Button ID="btnRegistrarse" CssClass="BOTON" runat="server" Text="Registrarse" OnClick="btnRegistrarse_Click" Height="48px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
