using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    internal class Servicio
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroServicio { get; set; }
        public string? Observacion { get; set; } = null;

        //recorrido
        //vehiculo
        //cliente
        //conductor
    }
}
