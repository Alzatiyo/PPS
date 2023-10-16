using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class Vehiculo_Servicio
    {
        public int id { get; set; }

        public Vehiculo vehiculo { get; set; }
        public int VehiculoId { get; set; }

        public Servicio servicio { get; set; }
        public int ServicioId { get; set; }
    }
}
