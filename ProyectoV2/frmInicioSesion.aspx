<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicioSesion.aspx.cs" Inherits="ProyectoV2.frmInicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/Login/style.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="blur"></div>
    <div class="formContent blur"><img src="img/palemeraIcon.jpeg" class="avatarImg"/>
    <form id="form1" runat="server">
        <br />
        <asp:Label ID="lblusernma" CssClass="label" runat="server" Text="Nombre de Usuario"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtUsername" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblpass" CssClass="label" runat="server" Text="Contraseña"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtpass" TextMode="Password" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnIngresar" runat="server" Text="Iniciar Sesion" OnClick="btnIngresar_Click" />
        <br />
        <br />
        <div class="login"><div class="Oroption">O</div></div>
        <div class="signup"> ¿No estas registrado? <a href="PantallaTipoRegistro.aspx" class="a">Registrarse</a></div>
    </form>
    </div>
</body>
</html>
