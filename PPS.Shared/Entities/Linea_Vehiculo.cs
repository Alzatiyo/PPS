using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class Linea_Vehiculo
    {
        public int id { get; set; }

        public Linea linea { get; set; }
        public int LineaId { get; set; }

        public Vehiculo vehiculo { get; set; }
        public int VehiculoId { get; set;}
    }
}
