using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoV2
{
    public partial class frmInicioProveedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnPlaya_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmLugares.aspx");
        }

        protected void lbtnMontaña_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmSitios.aspx");
        }

        protected void lbtnCitadino_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmFacilidades.aspx");
        }

        protected void lbtnIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        protected void lbtnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}