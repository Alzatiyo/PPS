using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class Liquidacion
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Egreso es Obligatorio")]
        public int Egreso { get; set; }
        [Required(ErrorMessage = "El Ingreso es Obligatorio")]
        public int Ingreso { get; set; }
        public int Facturar { get; set; }

        public ICollection<Liquidacion_Servicio> liquidacion_Servicios { get; set; }

        //Servicio
    }
}
