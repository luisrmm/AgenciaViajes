using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace CapaNegocios
{
    public class SitiosN
    {
        Conexion Conexion = new Conexion();
        private SqlCommand cmdSitios = new SqlCommand();
        private SqlDataReader dataReader;

        public DataTable ListadoProveedores()
        {
            DataTable Tabla = new DataTable();
            cmdSitios.Connection = Conexion.AbrirConexion();
            cmdSitios.CommandText = "SeleccionProveedores";
            cmdSitios.CommandType = CommandType.StoredProcedure;
            dataReader = cmdSitios.ExecuteReader();
            Tabla.Load(dataReader);
            dataReader.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        
        //**************************************************
        public String D_mantenimiento_Clientes(SitiosE sitios)
        {
            String accion = "";
            cmdSitios.Connection = Conexion.AbrirConexion();
            //cmdSitios = new SqlCommand("MantenimientoSitios", Conexion.conn);
            cmdSitios.CommandText = "MantenimientoSitios";
            cmdSitios.CommandType = CommandType.StoredProcedure;
            cmdSitios.Parameters.Add(new SqlParameter("@idProveedor", sitios.IdProveedor));
            cmdSitios.Parameters.Add(new SqlParameter("@NombreSitio", sitios.NombreSitio));
            cmdSitios.Parameters.Add(new SqlParameter("@Estado", sitios.Estado));
            cmdSitios.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = sitios.accion;
            cmdSitios.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            cmdSitios.ExecuteNonQuery();
            accion = cmdSitios.Parameters["@accion"].Value.ToString();
            Conexion.CerrarConexion();
            return accion;
        }



    }
}
