using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class Servicio
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroServicio { get; set; }
        public string Observacion { get; set; } = null;
        public string Estado { get; set; } = null;
        public string Valor { get; set; } = null;
        [JsonIgnore]
        public Recorrido Recorrido { get; set; }
        [JsonIgnore]
        public ICollection<Vehiculo_Servicio> vehiculo_Servicios { get; set; }

    }
}
