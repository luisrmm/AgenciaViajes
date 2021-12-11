<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicioHuespedes.aspx.cs" Inherits="ProyectoV2.frmInicioHuespedes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/MenuClientes/Styles.css" rel="stylesheet" />
    <link href="css/MenuClientes/Tabla.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="tabla">
        <div>
            <div class="container">
            <header>
                <h2><a href="#"><i class="ion-plane"></i>Katotravel</a></h2>
                <nav>
                    <ul>
                        <li>
                           <a><asp:LinkButton ID="lbtnLugares" CssClass="btn" runat="server" OnClick="lbtnPlaya_Click">Proveedor</asp:LinkButton></a>
                        </li>
                        <li>
                           <a><asp:LinkButton ID="lbtnSitios" CssClass="btn" runat="server" OnClick="lbtnMontaña_Click">Reporte</asp:LinkButton></a>
                        </li>
                        <li>
                            <a><asp:LinkButton ID="lbtnFacilidades" CssClass="btn" runat="server" OnClick="lbtnCitadino_Click">Quejas</asp:LinkButton> </a>
                        </li>
                        <li>
                            <a>
                                <asp:LinkButton CssClass="btn" ID="lbtnreporte" runat="server">Reservas</asp:LinkButton></a>
                        </li>
                        <li>
                            <a>
                                <asp:LinkButton CssClass="btn" ID="lbtnCerrarSesion" runat="server" OnClick="lbtnIniciarSesion_Click">Cerrar Sesion</asp:LinkButton></a>
                        </li>
                    </ul>
                </nav>
            </header>  
        </div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
       
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" GridLines="None" Height="200px" Width="948px" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="NombreLugar" HeaderText="Nombre de lugar"/>
                <asp:BoundField DataField="Foto" HeaderText="Foto" />
                <asp:BoundField DataField="Ubicacion" HeaderText="Ubicacion" />
                <asp:BoundField DataField="CantidadHabitaciones" HeaderText="Habitaciones" />
                <asp:BoundField DataField="CantidadCamas" HeaderText="Camas" />
                <asp:BoundField DataField="MontoXNoche" HeaderText="Monto" />
                <asp:BoundField DataField="TipoLugar" HeaderText="Tipo de Lugar" />
                <asp:BoundField DataField="DetalleLugar" HeaderText="Detalle del Lugar" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" />
                
                <asp:CommandField SelectText="Reservar" ShowSelectButton="True">
                <ControlStyle BackColor="#6699FF" />
                </asp:CommandField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
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
