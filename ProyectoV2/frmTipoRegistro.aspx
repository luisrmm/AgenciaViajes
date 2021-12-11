<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTipoRegistro.aspx.cs" Inherits="ProyectoV2.frmTipoRegistro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/TipodeRegistro/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" class="FORMINCIO" runat="server">
    <div class="wrapper">
    <div class="card"><img src="img/huesped.jpg"/>
    <div class="info" >
      <h1>Huespedes</h1>
      <p>Registrate como huesped y ve nuestros sitios y comodidades a tu gusto.</p>
      <asp:Button ID="btnHuespedes"  runat="server"  Text="Huespedes" OnClick="btnHuespedes_Click"/>
    </div>
    </div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <div class="card"><img src="img/recepcion.jpg"/>
    <div class="info">
      <h1>Recepcion</h1>
      <p>Se parte de nuestro equipo y coloca tu lugar de hospedaje.</p>
      <asp:Button ID="Button2" runat="server"  Text="Proveedores" OnClick="Button2_Click"/>
    </div>
    </div>
    </div>
   
      </form>
   
    <p>
        &nbsp;</p>
</body>
</html>