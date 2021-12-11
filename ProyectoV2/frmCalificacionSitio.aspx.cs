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
    public partial class frmCalificacionSitio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Reportecliente report = new Reportecliente();
            DbEnlace.DataSource = report.Listado();
            DbEnlace.DataTextField = "Correo";
            DbEnlace.DataValueField = "IdProveedor";
            DataBind();
        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtComentario.Text != "" && TxtID.Text != "")
            {
                Mantenimiento("1");
                limpiarCampos();
            }
        }

        public void Mantenimiento(String accion)
        {
            ReporteClienteE reporte = new ReporteClienteE();
            Reportecliente repor = new Reportecliente();
            reporte.Idcliente = Int32.Parse(TxtID.Text);
            reporte.IdReserva = Convert.ToInt32(txtCodigo.Text);
            reporte.comentario = txtComentario.Text;
            reporte.IdSitio = Convert.ToInt32(DbEnlace.SelectedValue);
            reporte.Calificacion = Convert.ToInt32(DpCalificacion.SelectedIndex);
            reporte.accion = accion;
            String msj = repor.D_mantenimiento_Reportecliente(reporte);
            if (reporte.Calificacion == 0 || reporte.Calificacion == 2 || reporte.Calificacion == 4)
            {
                string msj2 = repor.D_mantenimiento_ActualizacionSitio(reporte);
            }

        }
        //*******************
        public void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtComentario.Text = "";
            TxtID.Text = "";
        }
    }
}