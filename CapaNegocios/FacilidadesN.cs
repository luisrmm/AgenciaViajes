using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
namespace CapaNegocios
{
    public class FacilidadesN
    {
        Conexion Conexion = new Conexion();
        private SqlCommand cmdLugares = new SqlCommand();
        private SqlDataReader dataReader;
        public DataTable ListadoFcilidades()
        {
            DataTable Tabla = new DataTable();
            cmdLugares.Connection = Conexion.AbrirConexion();
            cmdLugares.CommandText = "Selectfacilidades";
            cmdLugares.CommandType = CommandType.StoredProcedure;
            dataReader = cmdLugares.ExecuteReader();
            Tabla.Load(dataReader);
            dataReader.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        //******************************************************

        public String D_mantenimiento_Facilidades(LugaresE place)
        {
            String accion = "";
            cmdLugares.Connection = Conexion.AbrirConexion();
            //cmdLugares = new SqlCommand("MantenimientoLugares", Conexion.conn);
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
            cmdLugares.Parameters.Add(new SqlParameter("@estampaTiempo", place.idProveedor));
            cmdLugares.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = place.accion;
            cmdLugares.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            cmdLugares.ExecuteNonQuery();
            accion = cmdLugares.Parameters["@accion"].Value.ToString();
            Conexion.CerrarConexion();
            return accion;
        }

        public String D_mantenimiento_Facilidades1(FcilidadesE place)
        {
            String accion = "";
            cmdLugares.Connection = Conexion.AbrirConexion();
            //cmdLugares = new SqlCommand("MantenimientoFacilidades", Conexion.conn);
            cmdLugares.CommandText = "MantenimientoFacilidades";
            cmdLugares.CommandType = CommandType.StoredProcedure;

            cmdLugares.Parameters.Add(new SqlParameter("@Facilidad", place.Facilidades));
            cmdLugares.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = place.accion;
            cmdLugares.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            cmdLugares.ExecuteNonQuery();
            accion = cmdLugares.Parameters["@accion"].Value.ToString();
            Conexion.CerrarConexion();
            return accion;
        }
    }
}
