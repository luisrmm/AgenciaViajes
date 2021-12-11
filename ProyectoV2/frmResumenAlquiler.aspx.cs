using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaNegocios;
namespace ProyectoV2
{
    public partial class frmResumenAlquiler : System.Web.UI.Page
    {
        ResumenAlquilerE reporteE = new ResumenAlquilerE();
        ResumenAlquilerN reporteN = new ResumenAlquilerN();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHuespedes_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfacilidades.Text != "*")
                {
                    IList _reporte = new List<ResumenAlquilerE>();
                    DateTime fecha = DateTime.Parse(txtfacilidades.Text);
                    _reporte = (IList)reporteN.Reporte_resumen(fecha);
                    dgvResumenAlquiler.DataSource = _reporte;
                    dgvResumenAlquiler.DataBind();
                }
                else
                {
                    dgvResumenAlquiler.DataSource = reporteN.ResumenAlquiler();
                    DataBind();
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            txtfacilidades.Text = "";
        }
    }
}
