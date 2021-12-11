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
    public partial class frmHuespedes : System.Web.UI.Page
    {
        ClientesN cliente = new ClientesN();
        protected void Page_Load(object sender, EventArgs e)
        {
            listado();
        }

        public void listado()
        {
            ClientesN client = new ClientesN();
            dbCliente.DataSource = client.ListadoNacionalidad();
            dbCliente.DataTextField = "Nacionalidad";
            dbCliente.DataValueField = "IdNacionalidad";
            DataBind();
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text != "")
            {
                mantenimiento("1");
                //mantenimientoRegistro("1");
                limpiarCampos();
            }
        }

        void mantenimiento(String accion)
        {
            ClientesE client = new ClientesE();
            client.idCliente = Convert.ToInt32(txtIdCliente.Text);
            client.nombre = txtNombre.Text;
            client.PrimerApellido = TxtPApellido.Text;
            client.SegundoApellido = txtSApellido.Text;
            client.correo = txtCorreo.Text;
            client.Direccion = txtDireccion.Text;
            client.idNacionalidad = Convert.ToInt32(dbCliente.SelectedValue);
            client.Estado = txtEstado.Text;
            client.Contraseña = txtPassword.Text;
            client.accion = accion;
            String msj = cliente.D_mantenimiento_Clientes(client);
        }
        public void limpiarCampos()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            TxtPApellido.Text = "";
            txtSApellido.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtPassword.Text = "";
            txtEstado.Text = "";
        }
    }
}