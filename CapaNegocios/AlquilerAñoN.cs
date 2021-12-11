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
   public class AlquilerAñoN
    {
        Conexion Conexion = new Conexion();
        private SqlCommand cmdCliente = new SqlCommand();
        private SqlDataReader dataReader;

        #region "Mostrar Alquile por anno"
        public DataTable ResumenAlquilerAnno()
        {
            DataTable Tabla = new DataTable();
            cmdCliente.Connection = Conexion.AbrirConexion();
            cmdCliente.CommandText = "SelectAlquileresXYear";
            cmdCliente.CommandType = CommandType.StoredProcedure;
            dataReader = cmdCliente.ExecuteReader();
            Tabla.Load(dataReader);
            dataReader.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        #endregion
        #region
        public ICollection<AlquilerAñoE> Reporte_por_anno(DateTime fecha)
        {

            try
            {
                cmdCliente.Connection = Conexion.AbrirConexion();
                // cmdCliente = new SqlCommand("SelectAlquileresXFecha", Conexion.conn);
                cmdCliente.CommandText = "SelectAlquileresXFecha";
                cmdCliente.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = fecha;
                cmdCliente.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmdCliente.ExecuteReader();

                List<AlquilerAñoE> resumen_reporte = new List<AlquilerAñoE>();
                AlquilerAñoE reporte = null;

                while (reader.Read())
                {
                    reporte = new AlquilerAñoE();
                    reporte.Fecha = reader["Mes"].ToString();
                    reporte.CantidadPersonas = int.Parse(reader["Cantidad total personas que se alojaron"].ToString());
                    reporte.CantidadSitiosAlquilados = int.Parse(reader["Cantidad de sitios alquilados"].ToString());
                    reporte.Promediositio = int.Parse(reader["Promedio de dias por alquiler"].ToString());
                    reporte.GanaciaProd = decimal.Parse(reader["Ganacia promedio por sitio empresa"].ToString());
                    reporte.MontoTotal = decimal.Parse(reader["Monto Total por aquileres"].ToString());
                    resumen_reporte.Add(reporte);
                }

                return resumen_reporte;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
