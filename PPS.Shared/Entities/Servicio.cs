﻿using System;
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
        public string? Observacion { get; set; } = null;
        [JsonIgnore]
        public int IdRecorrido { get; set; }

        [JsonIgnore]
        public Recorrido recorrido { get; set; }
        [JsonIgnore]
        public ICollection<Vehiculo_Servicio> vehiculo_Servicios { get; set; }

        [JsonIgnore]
        public ICollection<EstadoServicio> EstadoServicios { get; set; }
        [JsonIgnore]
        public ICollection<Liquidacion> Liquidacions { get; set; }
    }
}
