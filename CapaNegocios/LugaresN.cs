using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
namespace CapaNegocios
{
    public class LugaresN
    {
        Conexion Conexion = new Conexion();
        private SqlCommand cmdLugares = new SqlCommand();
        private SqlDataReader dataReader;
        public DataTable ListadoTipoLugar()
        {
            DataTable Tabla = new DataTable();
            cmdLugares.Connection = Conexion.AbrirConexion();
            cmdLugares.CommandText = "SelectTipoLugar";
            cmdLugares.CommandType = CommandType.StoredProcedure;
            dataReader = cmdLugares.ExecuteReader();
            Tabla.Load(dataReader);
            dataReader.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        //******************************************************
        public DataTable ListadoProveedor()
        {
            DataTable Tabla = new DataTable();
            cmdLugares.Connection = Conexion.AbrirConexion();
            cmdLugares.CommandText = "SeleccionProveedores";
            cmdLugares.CommandType = CommandType.StoredProcedure;
            dataReader = cmdLugares.ExecuteReader();
            Tabla.Load(dataReader);
            dataReader.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public String D_mantenimiento_Lugares(LugaresE place)
        {
            /*
             * cmdUsuario.Connection = Conexion.AbrirConexion();
            cmdUsuario.CommandText = "InicioSesioncliente";
            cmdUsuario.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUsuario.Parameters.Add(new SqlParameter("@cedula", inicio.idCliente));
            cmdUsuario.Parameters.Add(new SqlParameter("@Contrasena", inicio.Contraseña));
            // int result = Convert.ToInt32(cmdUsuario.ExecuteScalar().ToString());

            SqlDataReader reader = cmdUsuario.ExecuteReader();
            */

            String accion = "";
            cmdLugares.Connection = Conexion.AbrirConexion();
            // cmdLugares = new SqlCommand("MantenimientoLugares", Conexion.connAdmin);
            cmdLugares.CommandText = "MantenimientoLugares";
            cmdLugares.CommandType = CommandType.StoredProcedure;
            cmdLugares.Parameters.Add(new SqlParameter("@NombreLugar", place.nombreLugar));
            cmdLugares.Parameters.Add(new SqlParameter("@Foto", place.foto));
            cmdLugares.Parameters.Add(new SqlParameter("@Ubicacion", place.Ubicacion));
            cmdLugares.Parameters.Add(new SqlParameter("@CantidadHabitaciones", place.CantHabitantes));
            cmdLugares.Parameters.Add(new SqlParameter("@CantidadCamas", place.CantCamas));
            cmdLugares.Parameters.Add(new SqlParameter("@MontoXNoche", place.MontoXNoche));
            cmdLugares.Parameters.Add(new SqlParameter("@IDTipoLugar", place.idTipoLugar));
            cmdLugares.Parameters.Add(new SqlParameter("@DetalleLugar", place.DetalleLugar));
            cmdLugares.Parameters.Add(new SqlParameter("@IdProveedor", place.idProveedor));
            cmdLugares.Parameters.Add(new SqlParameter("@estampaTiempo", place.Estampa));
            cmdLugares.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = place.accion;
            cmdLugares.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
 
            cmdLugares.ExecuteNonQuery();
            accion = cmdLugares.Parameters["@accion"].Value.ToString();
            Conexion.CerrarConexion();
            return accion;
        }
    }
}
