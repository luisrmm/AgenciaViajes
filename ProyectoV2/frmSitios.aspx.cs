using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoV2
{
    public partial class frmSitios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SitiosN siteN = new SitiosN();
            DpProveedor.DataSource = siteN.ListadoProveedores();
            DpProveedor.DataTextField = "Correo";
            DpProveedor.DataValueField = "IdProveedor";
            DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtsitio.Text != "")
            {
                mantenimiento("1");
                Limpiar();
            }
        }
        public void Limpiar()
        {
            txtsitio.Text = "";
            DpEstado.SelectedItem.Text = "Seleccione";
        }
        public void mantenimiento(String accion)
        {
            SitiosN siteN = new SitiosN();
            SitiosE sitiosE = new SitiosE();
            sitiosE.NombreSitio = txtsitio.Text;
            sitiosE.IdProveedor = Convert.ToInt32(DpProveedor.SelectedValue);
            sitiosE.Estado = DpEstado.Text;
            sitiosE.accion = accion;
            String msj = siteN.D_mantenimiento_Clientes(sitiosE);
        }
    }
}