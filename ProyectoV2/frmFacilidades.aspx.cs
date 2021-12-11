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
    public partial class frmFacilidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FacilidadesN facilidadesN = new FacilidadesN();
            GridView1.DataSource = facilidadesN.ListadoFcilidades();
            DataBind();
        }

        protected void btnHuespedes_Click(object sender, EventArgs e)
        {
            if (txtfacilidades.Text != "")
            {
                mantenimiento("1");
                txtfacilidades.Text = "";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfacilidades.Text = GridView1.SelectedRow.Cells[0].ToString();
        }
        public void mantenimiento(String accion)
        {
            FcilidadesE f = new FcilidadesE();
            FacilidadesN n = new FacilidadesN();
            f.Facilidades = txtfacilidades.Text;
            f.accion = accion;
            String msj = n.D_mantenimiento_Facilidades1(f);
        }

    }
}