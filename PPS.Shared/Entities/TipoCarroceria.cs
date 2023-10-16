﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class TipoCarroceria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        public string Nombre { get; set; } = string.Empty;
        public string? Observacion { get; set; } = null;

        public ICollection<TipoCarroceria_Vehiculo> tipoCarroceria_Vehiculos { get; set; }
    }
}
