using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidades;
namespace CapaNegocios
{
    public class ProveedoresN
    {
        //variables del proveedor
        #region Proveedor
        private int idProveedor;
        private string nombre;
        private string PrimerApellido;
        private string SegundoApellido;
        private string correo;
        private string Direccion;
        private int idNacionalidad;
        private string Estado;
        private string Contraseña;
        #endregion
        //***************************************************
        Conexion con = new Conexion();
        Conexion Conexion = new Conexion();
        private SqlCommand cmdProveedor = new SqlCommand();
        private SqlDataReader dataReader;
        Proveedores prov = new Proveedores();
        #region Properties
        public int _idProveedor
        {
            get
            {
                return idProveedor;
            }
            set
            {
                idProveedor = value;
            }
        }
        //**************************
        public string _nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        //*****************************
        public string _PrimerApellido
        {
            get
            {
                return PrimerApellido;
            }
            set
            {
                PrimerApellido = value;
            }
        }
        //*****************************
        public string _SegundoApellido
        {
            get
            {
                return SegundoApellido;
            }
            set
            {
                SegundoApellido = value;
            }
        }
        //***********************************
        public string _correo
        {
            get
            {
                return correo;
            }
            set
            {
                correo = value;
            }
        }
        //***********************************
        public string _Direccion
        {
            get
            {
                return Direccion;
            }
            set 
            {
                Direccion = value;
            }
        }
        //************************************
        public int _idNacionalidad
        {
            get
            {
                return idNacionalidad;
            }
            set
            {
                idNacionalidad = value;
            }
        }
        //*************************************
        public string _estado
        {
            get
            {
                return Estado;
            }
            set
            {
                Estado = value;
            }
        }
        //**************************************
        public string _contraseña
        {
            get
            {
                return Contraseña;
            }
            set
            {
                Contraseña=value;
            }
        }
        //***************************************
        #endregion
        #region "Mostrar Nacionalidades Clientes"
        public DataTable ListadoNacionalidad()
        {
            DataTable Tabla = new DataTable();
            cmdProveedor.Connection = con.AbrirConexion();
            cmdProveedor.CommandText = "SelectNacionalidad";
            cmdProveedor.CommandType = CommandType.StoredProcedure;
            dataReader = cmdProveedor.ExecuteReader();
            Tabla.Load(dataReader);
            dataReader.Close();
            con.CerrarConexion();
            return Tabla;
        }
        #endregion
        //**************************************************
        public String D_mantenimiento_Clientes(ProveedoresE client)
        {
            String accion = "";
            cmdProveedor.Connection = Conexion.AbrirConexion();
            //cmdProveedor = new SqlCommand("MantenimientoProveedores", Conexion.conn);
            cmdProveedor.CommandText = "MantenimientoProveedores";
            cmdProveedor.CommandType = CommandType.StoredProcedure;
            cmdProveedor.Parameters.Add(new SqlParameter("@cedula", client.idProveedor));
            cmdProveedor.Parameters.Add(new SqlParameter("@nombre", client.nombre));
            cmdProveedor.Parameters.Add(new SqlParameter("@primer_apellido", client.PrimerApellido));
            cmdProveedor.Parameters.Add(new SqlParameter("@segundo_apellido", client.SegundoApellido));
            cmdProveedor.Parameters.Add(new SqlParameter("@correo", client.correo));
            cmdProveedor.Parameters.Add(new SqlParameter("@direccion", client.Direccion));
            cmdProveedor.Parameters.Add(new SqlParameter("@idNacionalidad", client.idNacionalidad));
            cmdProveedor.Parameters.Add(new SqlParameter("@estado", client.Estado));
            cmdProveedor.Parameters.Add(new SqlParameter("@contrasena", client.Contraseña));
            cmdProveedor.Parameters.Add(new SqlParameter("@estampaTiempo", client.Estampa));
            cmdProveedor.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = client.accion;
            cmdProveedor.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            //if (Conexion.conn.State == ConnectionState.Open) Conexion.CerrarConexion();
            //Conexion.AbrirConexion();
            cmdProveedor.ExecuteNonQuery();
            accion = cmdProveedor.Parameters["@accion"].Value.ToString();
            Conexion.CerrarConexion();
            return accion;
        }
    }
}
