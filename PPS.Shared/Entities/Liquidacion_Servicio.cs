using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class Liquidacion_Servicio
    {
        public int Id { get; set; }

        public Servicio servicio { get; set; }
        public int ServicioId { get; set; }


        public Liquidacion liquidacion { get; set; }
        public int LiquidacionId { get; set; }


    }
}
