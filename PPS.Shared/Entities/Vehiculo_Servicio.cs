using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class Vehiculo_Servicio
    {
        public int id { get; set; }

        [JsonIgnore]
        public Servicio? Servicio { get; set; }
        [JsonIgnore]
        public int IdServicio { get; set; }
        [JsonIgnore]
        public Vehiculo Vehiculo { get; set; }
        [JsonIgnore]
        public int IdVehiculo { get; set; }
    }
}
