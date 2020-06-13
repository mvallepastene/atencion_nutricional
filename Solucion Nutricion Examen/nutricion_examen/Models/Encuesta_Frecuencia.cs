using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nutricion_examen.Models
{
    public class Encuesta_Frecuencia
    {
        public int Id_Frecuencia { get; set; }
        public string Alimentos { get; set; }
        public string Frecuencia { get; set; }
        public int Cantidad_Gr_Cc { get; set; }
        public string Observaciones { get; set; }
        public int Id_Ficha { get; set; }
    }
}