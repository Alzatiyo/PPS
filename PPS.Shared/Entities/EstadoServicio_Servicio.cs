using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS.Shared.Entities
{
    public class EstadoServicio_Servicio
    {
        public int Id { get; set; }

        public EstadoServicio estadoServicio { get; set; }
        public int  EstadoServicioId { get; set; }


        public Servicio servicio { get; set; }
        public int  ServicioId { get; set; }

    }
}
