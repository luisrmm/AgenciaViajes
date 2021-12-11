using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class InicioSesionE
    {
        public int idCliente { get; set; }

        public string Rol { get; set; }
        public string Estado { get; set; }
        public string Direccion { get; set; }
        public int IdNacionalidad { get; set; }
        public string Contraseña { get; set; }
    }
}
