using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class Recorrido_Servicio
    {
        public int id { get; set; }

        public Recorrido recorrido { get; set; }
        public int RecorridoId { get; set; }


        public Servicio servicio { get; set; }
        public int ServicioId { get; set; }


        }
    }
