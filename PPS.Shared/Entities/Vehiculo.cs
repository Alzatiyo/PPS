using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    internal class Vehiculo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La placa es Obligatoria")]
        public string placa { get; set; } = string.Empty;
        [Required(ErrorMessage = "El modelo es Obligatorio")]
        public string modelo { get; set; } = string.Empty;
        [Required(ErrorMessage = "El Cilindraje es Obligatorio")]
        public string Cilindraje { get; set; } = string.Empty;
        [Required(ErrorMessage = "La Capacidad es Obligatoria")]
        public int Capacidad { get; set; }
        [Required(ErrorMessage = "El color es Obligatorio")]
        public string color { get; set; } = string.Empty;
        [Required(ErrorMessage = "El Numero de Motor es Obligatorio")]
        public string NumeroMotor { get; set; } = string.Empty;
        [Required(ErrorMessage = "El Numero de Serie es Obligatorio")]
        public string NumeroSerie { get; set; } = string.Empty;
        [Required(ErrorMessage = "El Numero de Chasis es Obligatorio")]
        public string NumeroChasis { get; set; } = string.Empty;

        //Marca
        //Linea
        //TipoCarroceria
        //Transito
        //Propietario
    }
}
