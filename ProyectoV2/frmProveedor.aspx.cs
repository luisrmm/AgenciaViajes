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
    public partial class frmProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listado();
        }
        public void listado()
        {
            ProveedoresN proveedor = new ProveedoresN();
            dbProveedor.DataSource = proveedor.ListadoNacionalidad();
            dbProveedor.DataTextField = "Nacionalidad";
            dbProveedor.DataValueField = "IdNacionalidad";
            DataBind();
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtIdProv.Text != "")
            {
                mantenimiento("1");
                limpiarCampos();
            }
        }

        public void mantenimiento(String accion)
        {
            ProveedoresE proveedor = new ProveedoresE();
            ProveedoresN provN = new ProveedoresN();
            proveedor.idProveedor = Convert.ToInt32(txtIdProv.Text);
            proveedor.nombre = txtNombre.Text;
            proveedor.PrimerApellido = TxtPApellido.Text;
            proveedor.SegundoApellido = txtSApellido.Text;
            proveedor.correo = txtCorreo.Text;
            proveedor.Direccion = txtDireccion.Text;
            proveedor.idNacionalidad = Convert.ToInt32(dbProveedor.SelectedValue);
            proveedor.Estado = txtEstado.Text;
            proveedor.Contraseña = txtPassword.Text;
            proveedor.accion = accion;
            String msj = provN.D_mantenimiento_Clientes(proveedor);
        }
        //*************************************************************
        public void limpiarCampos()
        {
            txtIdProv.Text = "";
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