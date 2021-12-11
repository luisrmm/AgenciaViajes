using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ClientesE
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string correo { get; set; }
        public string Direccion { get; set; }
        public int idNacionalidad { get; set; }
        public string Estado { get; set; }
        public string Contraseña { get; set; }
        public string Estampa { get; set; }
        public string accion { get; set; }
        public string Rol { get; set; }
    }
}
