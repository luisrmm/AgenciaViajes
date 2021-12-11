using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ResumenAlquilerE
    {
        public string FechaReserva { get; set; }
        public string Anno { get; set; }
        public int CantidadReserva { get; set; }
        public int DiasPromedio { get; set; }
        public int CostoPromedio { get; set; }
        public int CanridadPersonas { get; set; }
        public decimal Montototal { get; set; }
    }
}
