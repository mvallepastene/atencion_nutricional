using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nutricion_examen.Models
{
    public class EncuestaR24H
    {
        public int Id_R24h { get; set; }
        public string Dia_Semana { get; set; }
        public string Hora { get; set; }
        public string Minuta { get; set; }
        public string Ingredientes { get; set; }
        public string Medidas_Caseras { get; set; }
        public int Cantidad_Gr_Ml_Total { get; set; }
        public string Observaciones { get; set; }
        public int Id_Ficha { get; set; }
    }
}