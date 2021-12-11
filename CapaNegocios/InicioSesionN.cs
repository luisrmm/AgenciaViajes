using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web;
using CapaEntidades;
using CapaDatos;
namespace CapaNegocios
{
    public class InicioSesionN
    {
        Conexion Conexion = new Conexion();
        private SqlCommand cmdUsuario = new SqlCommand();
        private SqlCommand cmdProv = new SqlCommand();
        public int InicioSesion(InicioSesionE inicio)
        {
            cmdUsuario.Connection = Conexion.AbrirConexion();
            cmdUsuario.CommandText = "InicioSesioncliente";
            cmdUsuario.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUsuario.Parameters.Add(new SqlParameter("@cedula", inicio.idCliente));
            cmdUsuario.Parameters.Add(new SqlParameter("@Contrasena", inicio.Contraseña));
            // int result = Convert.ToInt32(cmdUsuario.ExecuteScalar().ToString());

            SqlDataReader reader = cmdUsuario.ExecuteReader();

            //List<ResumenAlquilerE> resumen_reporte = new List<ResumenAlquilerE>();
            InicioSesionE inicioUser = null;

            int data = 0;

            while (reader.Read())
            {
                inicioUser = new InicioSesionE();
                inicioUser.idCliente = int.Parse(reader["idCliente"].ToString());
                inicioUser.Rol =reader["Rol"].ToString();
                System.Diagnostics.Debug.WriteLine(inicioUser.idCliente);
                System.Diagnostics.Debug.WriteLine(inicioUser.Rol);
                data = 1;
            }

            if(data == 0)
            {
                System.Diagnostics.Debug.WriteLine("DATA 0 " );
                cmdProv.Connection = Conexion.AbrirConexion();
                cmdProv.CommandText = "InicioSesionProveedor";
                cmdProv.CommandType = System.Data.CommandType.StoredProcedure;
                cmdProv.Parameters.Add(new SqlParameter("@cedula", inicio.idCliente));
                cmdProv.Parameters.Add(new SqlParameter("@Contrasena", inicio.Contraseña));
                int result = Convert.ToInt32(cmdProv.ExecuteScalar().ToString());
                if (result > 0)
                {
                    System.Web.HttpContext.Current.Session["User"] = inicio.idCliente;
                    System.Web.HttpContext.Current.Response.Redirect("frmInicioProveedores.aspx");
                    Conexion.CerrarConexion();
                }
                return -1;
            } else if (data == 1)
            {
                System.Diagnostics.Debug.WriteLine("DATA 1");
                System.Web.HttpContext.Current.Session["User"] = inicioUser.idCliente;
                System.Web.HttpContext.Current.Session["Rol"] = inicioUser.Rol;
                System.Web.HttpContext.Current.Response.Redirect("frmInicioHuespedes.aspx");
                Conexion.CerrarConexion();
            }
            return -1;
        }
        //***********************************************************************************
    }
}
