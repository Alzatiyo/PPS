using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class EstadoServicio
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Estado { get; set; }
        public string? Observacion { get; set; } = null;

        //servicio
    }
}
