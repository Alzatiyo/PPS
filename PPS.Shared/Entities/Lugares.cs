using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    internal class Lugares
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        public string Nombre { get; set; } = string.Empty;
        public string? Observacion { get; set; } = null;
    }
}
