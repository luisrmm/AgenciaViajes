using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Configuration;


namespace CapaDatos
{
    public class Conexion
    {

        // static private string CadenaConexion = "Data Source=DESKTOP-9CD4QTV;Initial Catalog=AgenciaViajes;Integrated security=true";                                          // MD5 Hashes 
        static private string CadenaConexionPublico = @"Data Source=DESKTOP-9CD4QTV;Initial Catalog=AgenciaViajes;Integrated security=true; user id = Publico; password = 6f57f9982ea3ba3761fd18cfe895976a";
        static private string CadenaConexionAdmin = @"Data Source=DESKTOP-9CD4QTV;Initial Catalog=AgenciaViajes;Integrated security=true; user id = Admin; password = e3afed0047b08059d0fada10f400c1e5";
        static private string CadenaConexionProveedor = @"Data Source=DESKTOP-9CD4QTV;Initial Catalog=AgenciaViajes;Integrated security=true; user id = Proveedor; password = 03edc4004ba1ec8ac31be6e8ab5291c4";
        static private string CadenaConexionCliente = @"Data Source=DESKTOP-9CD4QTV;Initial Catalog=AgenciaViajes;Integrated security=true; user id = Cliente; password = 7efef3fb2ec47bd2bb0d79f58a0312a6";
        static private string CadenaConexionEmpleado = @"Data Source=DESKTOP-9CD4QTV;Initial Catalog=AgenciaViajes;Integrated security=true; user id = Empleado; password = 0df60cfbb01a17bd7675affccd3ac371";

        public SqlConnection connPublico = new SqlConnection(CadenaConexionPublico);
        public SqlConnection connAdmin = new SqlConnection(CadenaConexionAdmin);
        public SqlConnection connProveedor = new SqlConnection(CadenaConexionProveedor);
        public SqlConnection connCliente = new SqlConnection(CadenaConexionCliente);
        public SqlConnection connEmpleado = new SqlConnection(CadenaConexionEmpleado);

        public SqlConnection AbrirConexion()
        {

            HttpContext context = HttpContext.Current;
            string rol = (string)(context.Session["Rol"]);

            System.Diagnostics.Debug.WriteLine(" 33333333 Abierta - ROL :  " + rol);

            if (rol == "admin")
            {
                System.Diagnostics.Debug.WriteLine(" Estoy en admin ");
                if (connAdmin.State == ConnectionState.Closed)
                    connAdmin.Open();
                return connAdmin;
            }

            if (rol == "proveedor")
            {
                System.Diagnostics.Debug.WriteLine(" Estoy en proveedor ");
                if (connProveedor.State == ConnectionState.Closed)
                    connProveedor.Open();
                return connProveedor;
            }

            if (rol == "cliente")
            {
                System.Diagnostics.Debug.WriteLine(" Estoy en cliente ");
                if (connCliente.State == ConnectionState.Closed)
                    connCliente.Open();
                return connCliente;
            }

            if (rol == "empleado")
            {
                System.Diagnostics.Debug.WriteLine(" Estoy en empleado ");
                if (connEmpleado.State == ConnectionState.Closed)
                    connEmpleado.Open();
                return connEmpleado;
            }

            // publico
            if (connPublico.State == ConnectionState.Closed)
                connPublico.Open();
            return connPublico;
        }
        public SqlConnection CerrarConexion()
        {
            HttpContext context = HttpContext.Current;
            string rol = (string)(context.Session["Rol"]);

            System.Diagnostics.Debug.WriteLine(" 0000000000 Cerrar - ROL :  " + rol);

            if (rol == "admin")
            {
                if (connAdmin.State == ConnectionState.Open)
                    connAdmin.Close();
                return connAdmin;
            }

            if (rol == "proveedor")
            {
                if (connProveedor.State == ConnectionState.Open)
                    connProveedor.Close();
                return connProveedor;
            }

            if (rol == "cliente")
            {
                if (connCliente.State == ConnectionState.Open)
                    connCliente.Close();
                return connCliente;
            }

            if (rol == "empleado")
            {
                if (connEmpleado.State == ConnectionState.Open)
                    connEmpleado.Close();
                return connEmpleado;
            }

            // publico
            if (connPublico.State == ConnectionState.Open)
                connPublico.Close();
            return connPublico;
        }
        //************************************************************
    }
}
