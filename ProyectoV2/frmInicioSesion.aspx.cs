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
    public partial class frmInicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            InicioSesionE inicio = new InicioSesionE();
            InicioSesionN inicioN = new InicioSesionN();
            inicio.idCliente = Convert.ToInt32(txtUsername.Text);
            inicio.Contraseña = txtpass.Text;
            int result = inicioN.InicioSesion(inicio);
        }

        public void limpiarCampos()
        {
            txtUsername.Text = "";
            txtpass.Text = "";
        }
    }
}