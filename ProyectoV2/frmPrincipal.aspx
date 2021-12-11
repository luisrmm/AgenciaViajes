<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPrincipal.aspx.cs" Inherits="ProyectoV2.frmPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/Menu/Styles.css" rel="stylesheet" />
    <title></title>
</head>
<body>
<form id="form1" runat="server">
        <div class="container">
            <header>
                <h2><a href="#"><i class="ion-plane"></i>Katotravel</a></h2>
                <nav>
                    <ul>
                        <li>
                           <a><asp:LinkButton ID="lbtnPlaya" runat="server" OnClick="lbtnPlaya_Click">Playa</asp:LinkButton></a>
                        </li>
                        <li>
                           <a><asp:LinkButton ID="lbtnMontaña" runat="server" OnClick="lbtnMontaña_Click">Montaña</asp:LinkButton></a>
                        </li>
                        <li>
                            <a><asp:LinkButton ID="lbtnCitadino" runat="server" OnClick="lbtnCitadino_Click">Citadino</asp:LinkButton> </a>
                        </li>
                        <li>
                            <a>
                                <asp:LinkButton CssClass="btn" ID="lbtnIniciarSesion" runat="server" OnClick="lbtnIniciarSesion_Click">Iniciar Sesion</asp:LinkButton></a>
                        </li>
                        <li>
                            <a>
                                <asp:LinkButton CssClass="btn" ID="lbtnRegister" runat="server" OnClick="lbtnRegister_Click">Registrarse</asp:LinkButton></a>
                        </li>
                    </ul>
                </nav>
            </header>
            <div class="cover">
                <h1>Disfuta viajando.</h1>
                <div class="flex-form">
                    <%--<label for="from">
                        <i class="ion-location">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </i>
                    </label>--%>
                    <asp:TextBox ID="txtLugar" CssClass="position" Width="50%" placeholder="donde quieres ir" runat="server"></asp:TextBox>
                    <asp:LinkButton ID="lbtnBUcsar" CssClass="position"  BackColor="Red" Width="50%" runat="server">Buscar</asp:LinkButton>
                </div>
            </div>  
        </div>
</form>
</body>
</html>
