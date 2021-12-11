<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicioProveedores.aspx.cs" Inherits="ProyectoV2.frmInicioProveedores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/MenuProveedores/Styles.css" rel="stylesheet" />
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
                           <a><asp:LinkButton ID="lbtnLugares" CssClass="btn" runat="server" OnClick="lbtnPlaya_Click">Lugares</asp:LinkButton></a>
                        </li>
                        <li>
                           <a><asp:LinkButton ID="lbtnSitios" CssClass="btn" runat="server" OnClick="lbtnMontaña_Click">Sitios</asp:LinkButton></a>
                        </li>
                        <li>
                            <a><asp:LinkButton ID="lbtnFacilidades" CssClass="btn" runat="server" OnClick="lbtnCitadino_Click">Facilidades del Lugar</asp:LinkButton>
                            </a>
                        </li>
                        <li>
                            <a>
                                <asp:LinkButton CssClass="btn" ID="lbtnreporte" runat="server" OnClick="lbtnIniciarSesion_Click">Reporte de Reservacion</asp:LinkButton></a>
                        </li>
                    </ul>
                </nav>
            </header>  
        </div>
</form>
</body>
</html>

