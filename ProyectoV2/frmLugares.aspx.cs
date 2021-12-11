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
    public partial class frmLugares : System.Web.UI.Page
    {
        LugaresN place = new LugaresN();
        LugaresE placeE = new LugaresE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DBTipoLugar.SelectedIndex == 0)
            {
                DBTipoLugar.DataSource = place.ListadoTipoLugar();
                DBTipoLugar.DataTextField = "TipoLugar";
                DBTipoLugar.DataValueField = "IDTipoLugar";
                DataBind();
            }

            if (DpProveedor.SelectedItem.Value.Contains("Seleccione"))
            {
                DpProveedor.DataSource = place.ListadoProveedor();
                DpProveedor.DataTextField = "Correo";
                DpProveedor.DataValueField = "IdProveedor";
                DataBind();
            }
        }

        protected void bntIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtnombreLugar.Text))
            {
                throw new Exception("Error en los datos no puede quedar vacio");
            }
            else
            {
                Mantenimiento("1");
               /* HttpContext context = HttpContext.Current;
                string rol = (string)(context.Session["Rol"]);


                System.Diagnostics.Debug.WriteLine("inicioUser.Rol :" + rol+":");
               */

                limpiar();
            }
        }

        void Mantenimiento(String accion)
        {
            placeE.nombreLugar = txtnombreLugar.Text;
            placeE.foto = txtfoto.Text;
            placeE.Ubicacion = txtubicacion.Text;
            placeE.CantHabitantes = Convert.ToInt32(txtcantH.Text);
            placeE.MontoXNoche = Convert.ToDouble(txtmonto.Text);
            placeE.idTipoLugar = Convert.ToInt32(DBTipoLugar.SelectedValue);
            placeE.idProveedor = Convert.ToInt32(DpProveedor.SelectedValue);
            placeE.CantCamas = Convert.ToInt32(txtCantCamas.Text);
            placeE.DetalleLugar = TxtDetalle.Text;
            placeE.accion = accion;
            String msj = place.D_mantenimiento_Lugares(placeE);
        }
        void limpiar()
        {
            txtnombreLugar.Text = "";
            txtfoto.Text = "";
            txtCantCamas.Text = "";
            txtcantH.Text = "";
            txtmonto.Text = "";
            txtnombreLugar.Text = "";
            txtubicacion.Text = "";
            TxtDetalle.Text = "";
        }

        protected void DpProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DpProveedor.SelectedIndex == 0)
            {
                DBTipoLugar.DataSource = place.ListadoTipoLugar();
                DBTipoLugar.DataTextField = "TipoLugar";
                DBTipoLugar.DataValueField = "IDTipoLugar";
                DataBind();
            }
        }
    }
}