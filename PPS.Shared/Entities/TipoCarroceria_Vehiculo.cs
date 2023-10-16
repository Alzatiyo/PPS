using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class TipoCarroceria_Vehiculo
    {
        public int id { get; set; }

        public TipoCarroceria tipoCarroceria { get; set; }
        public int TipoCarroceriaId { get; set; }

        public Vehiculo vehiculo { get; set; }
        public int VehiculoId { get; set; }
    }
}
