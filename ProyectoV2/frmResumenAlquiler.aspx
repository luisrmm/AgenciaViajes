<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmResumenAlquiler.aspx.cs" Inherits="ProyectoV2.frmResumenAlquiler" %>

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
      <br />
      <br />
      <br />
      <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Resumen reporte"></asp:Label>
      <br />
      <br />
      <asp:TextBox ID="txtfacilidades" CssClass="controls" runat="server"></asp:TextBox>
       <br />
        <asp:Button ID="btnHuespedes" CssClass="BOTON"  runat="server"  Text="Consultar" OnClick="btnHuespedes_Click" Width="199px"/>
        <asp:GridView ID="dgvResumenAlquiler" runat="server" CellPadding="60" CellSpacing="2" ForeColor="#333333" GridLines="None" Height="10px" Width="600px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" HorizontalAlign="Center" VerticalAlign="Middle" />
            <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <FooterStyle BackColor="#1F53C5" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" VerticalAlign="Middle" Width="20px" Wrap="True" />
            <SelectedRowStyle BackColor="#1F53C5" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="True" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" BorderStyle="None" HorizontalAlign="Justify" VerticalAlign="Middle" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
