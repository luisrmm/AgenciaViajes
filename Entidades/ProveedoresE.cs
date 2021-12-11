using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ProveedoresE
    {
        public int idProveedor { get; set; }
        public string nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string correo { get; set; }
        public string Direccion { get; set; }
        public int idNacionalidad { get; set; }
        public string Estado { get; set; }
        public string Contraseña { get; set; }
        public int Estampa { get; set; }
        public string accion { get; set; }
    }
}
