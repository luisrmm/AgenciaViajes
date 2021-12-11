using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ReporteClienteE
    {
        public int IdReporte{ get; set; }
        public int IdReserva{ get; set; }
        public int Idcliente{ get; set;}
        public int IdSitio{ get; set; }
        public string comentario{get;set;}
        public int Calificacion { get; set; }
        public int Estampa { get; set; }
        public string accion { get; set; }
    }
}
