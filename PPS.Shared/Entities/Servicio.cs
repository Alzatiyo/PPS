using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class Servicio
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroServicio { get; set; }
        public string? Observacion { get; set; } = null;

        public ICollection<EstadoServicio_Servicio> estadoServicio_Servicios { get; set; }
        public ICollection<Liquidacion_Servicio> liquidacion_Servicios { get; set; }
        public ICollection<Recorrido_Servicio> recorrido_Servicios { get; set; }
        public ICollection<Vehiculo_Servicio> vehiculo_Servicios { get; set; }

        //recorrido
        //vehiculo
        //cliente
        //conductor
    }
}
