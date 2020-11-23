using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nutricion_examen.Models
{
    public class Reporte
    {
        public int Id_Ficha { get; set; }
        public string Nombre { get; set; }
        public float IMC { get; set; }
        public string Diagnostico { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public string Nombre_Nutri { get; set; }
    }
}