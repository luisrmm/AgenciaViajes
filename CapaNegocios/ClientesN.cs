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
    public class ClientesN
    {
        Conexion Conexion = new Conexion();
        private SqlCommand cmdCliente = new SqlCommand();
        private SqlDataReader dataReader;
        #region "Mostrar Nacionalidades Clientes"
        public DataTable ListadoNacionalidad()
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
        #endregion
        //**************************************************
        public String D_mantenimiento_Clientes(ClientesE client)
        {
            String accion = "";
            cmdCliente.Connection = Conexion.AbrirConexion();
            //cmdCliente = new SqlCommand("Mantenimientoclientes", Conexion.conn);
            cmdCliente.CommandText = "Mantenimientoclientes";
            cmdCliente.CommandType = CommandType.StoredProcedure;
            cmdCliente.Parameters.Add(new SqlParameter("@cedula", client.idCliente));
            cmdCliente.Parameters.Add(new SqlParameter("@nombre", client.nombre));
            cmdCliente.Parameters.Add(new SqlParameter("@primer_apellido", client.PrimerApellido));
            cmdCliente.Parameters.Add(new SqlParameter("@segundo_apellido", client.SegundoApellido));
            cmdCliente.Parameters.Add(new SqlParameter("@correo", client.correo));
            cmdCliente.Parameters.Add(new SqlParameter("@direccion", client.Direccion));
            cmdCliente.Parameters.Add(new SqlParameter("@idNacionalidad", client.idNacionalidad));
            cmdCliente.Parameters.Add(new SqlParameter("@estado", client.Estado));
            cmdCliente.Parameters.Add(new SqlParameter("@Contrasena", client.Contraseña));
            //cmdCliente.Parameters.Add(new SqlParameter("@Estampa", client.Estampa));
            cmdCliente.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = client.accion;
            cmdCliente.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            
            cmdCliente.ExecuteNonQuery();
            accion = cmdCliente.Parameters["@accion"].Value.ToString();
            Conexion.CerrarConexion();
            return accion;
        }
        #region
        public ICollection<ClientesE> consulta_cliente(int cliente)
        {

            try
            {
                cmdCliente.Connection = Conexion.AbrirConexion();
                //cmdCliente = new SqlCommand("Consulta_cliente", Conexion.conn);
                cmdCliente.CommandText = "Consulta_cliente";

                cmdCliente.Parameters.Add("@IdCliente", SqlDbType.Int).Value = cliente;
                cmdCliente.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmdCliente.ExecuteReader();

                List<ClientesE> datos_cliente = new List<ClientesE>();
                ClientesE _cliente = null;

                while (reader.Read())
                {
                    _cliente = new ClientesE();
                    _cliente.idCliente = int.Parse(reader["IdCliente"].ToString());
                    _cliente.nombre = reader["Nombre"].ToString();
                    _cliente.PrimerApellido = reader["PrimerApellido"].ToString();
                    _cliente.SegundoApellido = reader["SegundoApellido"].ToString();
                    _cliente.correo = reader["Correo"].ToString();
                    _cliente.Direccion = reader["Direccion"].ToString();
                    _cliente.Estado = reader["Estado"].ToString();
                    _cliente.Contraseña = reader["contrasena"].ToString();
                    _cliente.Estampa = reader["Estampa"].ToString();
                    datos_cliente.Add(_cliente);
                }

                return datos_cliente;
            }
            catch(Exception ex)
            {
                throw ex;
            }  
        }
        #endregion
    }
}
