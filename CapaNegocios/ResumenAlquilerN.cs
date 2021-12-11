using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ResumenAlquilerN
    {
        Conexion Conexion = new Conexion();
        private SqlCommand cmdCliente = new SqlCommand();
        private SqlDataReader dataReader;
        #region "Mostrar Resumen de alquileres"
        public DataTable ResumenAlquiler()
        {
            DataTable Tabla = new DataTable();
            cmdCliente.Connection = Conexion.AbrirConexion();
            cmdCliente.CommandText = "SelectResumenXmes";
            cmdCliente.CommandType = CommandType.StoredProcedure;
            dataReader = cmdCliente.ExecuteReader();
            Tabla.Load(dataReader);
            dataReader.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        #endregion
        #region
        public ICollection<ResumenAlquilerE> Reporte_resumen(DateTime fecha)
        {

            try
            {
                cmdCliente.Connection = Conexion.AbrirConexion();
                //cmdCliente = new SqlCommand("SelectResumenParametro", Conexion.conn);
                cmdCliente.CommandText = "SelectResumenParametro";
                cmdCliente.Parameters.Add("@FechaReserva", SqlDbType.DateTime).Value = fecha;
                cmdCliente.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmdCliente.ExecuteReader();

                List<ResumenAlquilerE> resumen_reporte = new List<ResumenAlquilerE>();
                ResumenAlquilerE reporte = null;

                while (reader.Read())
                {
                    reporte = new ResumenAlquilerE();
                    reporte.FechaReserva = reader["Mes"].ToString();
                    reporte.Anno = reader["Año"].ToString();
                    reporte.CantidadReserva = int.Parse(reader["Cantidad de reservas"].ToString());
                    reporte.DiasPromedio = int.Parse(reader["Dias promedio de la reserva"].ToString());
                    reporte.CostoPromedio = int.Parse(reader["Costo promedio de personas"].ToString());
                    reporte.CanridadPersonas = int.Parse(reader["Cantidad promedio de personas"].ToString());
                    reporte.Montototal = decimal.Parse(reader["Monto total cancelado por la reserva"].ToString());
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
