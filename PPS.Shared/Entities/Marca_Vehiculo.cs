using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class Marca_Vehiculo
    {
        public int id { get; set; }

        public Marca marca { get; set; }
        public int MarcaId { get; set; }

        public Vehiculo vehiculo { get; set; }
        public int VehiculoId { get; set;}
    }
}
