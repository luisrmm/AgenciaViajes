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
    public class Reportecliente
    {
        Conexion Conexion = new Conexion();
        private SqlCommand cmdCliente = new SqlCommand();
        private SqlDataReader dataReader;
        #region "Mostrar Nacionalidades Clientes"
        public DataTable ListadoSitio()
        {
            DataTable Tabla = new DataTable();
            cmdCliente.Connection = Conexion.AbrirConexion();
            cmdCliente.CommandText = "SelectNacionalidad";
            cmdCliente.CommandType = CommandType.StoredProcedure;
            dataReader = cmdCliente.ExecuteReader();
            Tabla.Load(dataReader);
            dataReader.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable Listado()
        {
            DataTable Tabla = new DataTable();
            cmdCliente.Connection = Conexion.AbrirConexion();
            cmdCliente.CommandText = "SeleccionProveedores";
            cmdCliente.CommandType = CommandType.StoredProcedure;
            dataReader = cmdCliente.ExecuteReader();
            Tabla.Load(dataReader);
            dataReader.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        #endregion
        //**************************************************
        public String D_mantenimiento_Reportecliente(ReporteClienteE client)
        {
            String accion = "";
            cmdCliente.Connection = Conexion.AbrirConexion();
            //cmdCliente = new SqlCommand("MantenimientoOpinionCliente", Conexion.conn);
            cmdCliente.CommandText = "MantenimientoOpinionCliente";
            cmdCliente.CommandType = CommandType.StoredProcedure;
            cmdCliente.Parameters.Add(new SqlParameter("@IdCliente", client.Idcliente));
            cmdCliente.Parameters.Add(new SqlParameter("@idReserva", client.IdReserva));
            cmdCliente.Parameters.Add(new SqlParameter("@idSitio", client.IdSitio));
            cmdCliente.Parameters.Add(new SqlParameter("@Comentario", client.comentario));
            cmdCliente.Parameters.Add(new SqlParameter("@Calificacion", client.Calificacion));
            cmdCliente.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = client.accion;
            cmdCliente.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            
            cmdCliente.ExecuteNonQuery();
            accion = cmdCliente.Parameters["@accion"].Value.ToString();
            Conexion.CerrarConexion();
            return accion;
        }

        public String D_mantenimiento_ActualizacionSitio(ReporteClienteE client)
        {
            String accion = "";
            cmdCliente.Connection = Conexion.AbrirConexion();
            //cmdCliente = new SqlCommand("DesactivarSitio", Conexion.conn);
            cmdCliente.CommandText = "DesactivarSitio";
            cmdCliente.CommandType = CommandType.StoredProcedure;
            cmdCliente.Parameters.Add(new SqlParameter("@IdSitio", client.IdSitio));
            cmdCliente.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = client.accion;
            cmdCliente.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
          
            cmdCliente.ExecuteNonQuery();
            accion = cmdCliente.Parameters["@accion"].Value.ToString();
            Conexion.CerrarConexion();
            return accion;
        }
    }
}
