﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    internal class Recorrido
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El valor es Obligatorio")]
        public int valor { get; set; }
        public int Estado { get; set; }

        //origen
        //Destino

    }
}