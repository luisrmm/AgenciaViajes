using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoV2
{
    public partial class frmInicioHuespedes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            string firstName = "------";
            firstName = (string)(context.Session["Rol"]);
            System.Diagnostics.Debug.WriteLine("Data form Session " + firstName);
        }


        protected void lbtnIniciarSesion_Click(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            context.Session["Rol"] = "";

            Response.Redirect("frmInicioSesion.aspx");
        }

        protected void lbtnPlaya_Click(object sender, EventArgs e)
        {
           Response.Redirect("frmInicioProveedores.aspx");
        }

        protected void lbtnMontaña_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmResumenAlquiler.aspx");
        }

        protected void lbtnCitadino_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCalificacionSitio.aspx");
        }

        protected void lbtnQuejas_Click(object sender, EventArgs e)
        {

        }
    }
}