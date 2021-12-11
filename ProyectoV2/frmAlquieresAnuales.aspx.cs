using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
using CapaEntidades;
using System.Collections;

namespace ProyectoV2
{
    public partial class frmAlquieresAnuales : System.Web.UI.Page
    {
         AlquilerAñoE reporteE = new AlquilerAñoE();
        AlquilerAñoN reporteN = new AlquilerAñoN();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnHuespedes_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfacilidades.Text != "*")
                {
                    IList _reporte = new List<AlquilerAñoE>();
                    DateTime fecha = DateTime.Parse(txtfacilidades.Text);
                    _reporte = (IList)reporteN.Reporte_por_anno(fecha);
                    dgvAlquilerAnno.DataSource = _reporte;
                    dgvAlquilerAnno.DataBind();
                }
                else
                {
                    
                    dgvAlquilerAnno.DataSource = reporteN.ResumenAlquilerAnno();
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