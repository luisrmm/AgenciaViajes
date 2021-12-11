<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFacilidades.aspx.cs" Inherits="ProyectoV2.frmFacilidades" %>

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
      <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Facilidades"></asp:Label>
      <br />
      <br />
      <asp:TextBox ID="txtfacilidades" CssClass="controls" runat="server"></asp:TextBox>
       <br />
        <asp:Button ID="btnHuespedes" CssClass="BOTON"  runat="server"  Text="Agregar Facilidades" OnClick="btnHuespedes_Click"/>
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="table" ForeColor="#333333" GridLines="None" Height="542px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="430px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Facilidad" HeaderText="Facilidad" />
                <asp:CommandField ShowSelectButton="True">
                <ControlStyle BackColor="#3399FF" />
                </asp:CommandField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
</body>
</html>

