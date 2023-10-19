using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class Transito_Vehiculo
    {
        public int id { get; set; }

        public Transito Transito { get; set; }
        public int TranditoId { get; set; }

        public Vehiculo Vehiculo { get; set; }
        public int VehiculoId { get; set; }
    }
}
