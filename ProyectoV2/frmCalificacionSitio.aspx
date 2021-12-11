<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCalificacionSitio.aspx.cs" Inherits="ProyectoV2.frmCalificacionSitio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/CalificacionSitio/Calificacionsitos.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <br/>
            <br/>
            <br/>
            <div class="FormRegistroProductos">
            <asp:Label ID="Label1" runat="server" Text="Codigo de Reserva"></asp:Label>
            <br/>
            <asp:TextBox ID="txtCodigo" CssClass="controls" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="Identificacion"></asp:Label>
            <br/>
                <asp:TextBox ID="TxtID" runat="server" CssClass="controls" EnableViewState="False" MaxLength="9"></asp:TextBox>
            <br/>
            <asp:Label ID="Label3" runat="server" Text="Sitio"></asp:Label>
                <br />
                <asp:DropDownList ID="DbEnlace" runat="server" CssClass="controls">
                </asp:DropDownList>
            <br/>
            <br/>
            <asp:Label ID="Label4" runat="server" Text="comentario"></asp:Label>
                <br />
                <asp:TextBox ID="txtComentario" runat="server" CssClass="controls"></asp:TextBox>
            <br/>
            <br/>
            <asp:Label ID="Calificacion" runat="server" Text="Calificacion"></asp:Label>
                <br />
                <asp:DropDownList ID="DpCalificacion" runat="server" CssClass="controls">
                    <asp:ListItem>Seleccione</asp:ListItem>
                    <asp:ListItem>Buen Servicio</asp:ListItem>
                    <asp:ListItem>Mal Servicio</asp:ListItem>
                    <asp:ListItem>Servicio Regular</asp:ListItem>
                    <asp:ListItem>PesimoServicio</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="btnregistrar" runat="server" CssClass="BOTON" OnClick="btnregistrar_Click" Text="Presentar Queja" />
                <br />
                <br />
                <br />
        </div>
    </form>
</body>
</html>

