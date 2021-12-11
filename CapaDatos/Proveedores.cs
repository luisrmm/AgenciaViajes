using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace CapaDatos
{
    public class Proveedores
    {

        Conexion con = new Conexion();
        private SqlCommand cmdProveedor = new SqlCommand();
        //private SqlDataReader dataReader;

        //***************************************************
        #region "Insertar"
        public void InsertarProveedor(int idProveedor, string nombre, string PrimerApellido,
            string SegundoApellido, string correo, string Direccion, int idNacionalidad, string Estado)
        {
            cmdProveedor.Connection = con.AbrirConexion();
            cmdProveedor.CommandText = "[dbo].[MantenimientoProveedores";
            cmdProveedor.CommandType = CommandType.StoredProcedure;
            cmdProveedor.Parameters.Add(new SqlParameter("@IdProveedor", idProveedor));
            cmdProveedor.Parameters.Add(new SqlParameter("@Nombre", nombre));
            cmdProveedor.Parameters.Add(new SqlParameter("@PrimerApellido", PrimerApellido));
            cmdProveedor.Parameters.Add(new SqlParameter("@SegundoApellido", SegundoApellido));
            cmdProveedor.Parameters.Add(new SqlParameter("@Correo", correo));
            cmdProveedor.Parameters.Add(new SqlParameter("@Direccion", Direccion));
            cmdProveedor.Parameters.Add(new SqlParameter("@idNacionalidad", idNacionalidad));
            cmdProveedor.Parameters.Add(new SqlParameter("@Estado ", Estado));
            cmdProveedor.ExecuteNonQuery();
            cmdProveedor.Parameters.Clear();
            con.CerrarConexion();
        }
        //*****************************************************************************************
        public void RegistroSesionProv(int idProveedor,string contrasena)
        {
            cmdProveedor.Connection = con.AbrirConexion();
            cmdProveedor.CommandText = "InicioSesion";
            cmdProveedor.CommandType = CommandType.StoredProcedure;
            cmdProveedor.Parameters.Add(new SqlParameter("@Identificacion", idProveedor));
            cmdProveedor.Parameters.Add(new SqlParameter("@Contrasena", contrasena));
            cmdProveedor.ExecuteNonQuery();
            cmdProveedor.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        public string Tamano { get; set; }
        public string Ubicacion { get; set; }
        public int CantHabitantes { get; set; }
        public int CantCamas { get; set; }
        public int CantMaxPersonas { get; set; }
        public double MontoAlquiler { get; set; }
        public string Facilidades { get; set; }
        public string Tipo { get; set; }
        public bool Estado { get; set; }

        public Proveedores()
        {
        }

        public Proveedores(string tamano, string ubicacion, int cantHabitantes, int cantCamas, int cantMaxPersonas, double montoAlquiler, string facilidades, string tipo, bool estado)
        {
            Tamano = tamano;
            Ubicacion = ubicacion;
            CantHabitantes = cantHabitantes;
            CantCamas = cantCamas;
            CantMaxPersonas = cantMaxPersonas;
            MontoAlquiler = montoAlquiler;
            Facilidades = facilidades;
            Tipo = tipo;
            Estado = estado;
        }




    }
}
