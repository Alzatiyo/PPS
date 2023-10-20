using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class Liquidacion
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Valor es Obligatorio")]
        public int Valor { get; set; }
        public int Estado { get; set; }
        [JsonIgnore]
        public ICollection<Servicio> servicios { get; set; }

    }
}
