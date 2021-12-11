using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class LugaresE
    {
        public int idLugar { get; set; }
        public string nombreLugar { get; set; }
        public string foto { get; set; }
        public string Ubicacion { get; set; }
        public int CantHabitantes { get; set; }
        public int CantCamas { get; set; }
        public double MontoXNoche { get; set; }
        public int idTipoLugar { get; set; }
        public string DetalleLugar { get; set; }
        public int idProveedor { get; set; }
        public int Estampa {get; set;}
        public string accion { get; set; }
    }
}
