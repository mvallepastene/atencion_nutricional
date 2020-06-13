using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nutricion_examen.Models
{
    public class Ficha_Medica_Paciente
    {
        public int Id_Ficha { get; set; }
        public string Ant_Familiares { get; set; }
        public string Alergias { get; set; }
        public string Enfermedades { get; set; }
        public float Peso { get; set; }
        public float Talla { get; set; }
        public float Imc { get; set; }
        public string Diagnostico { get; set; }
        public DateTime Proximo_Control { get; set; }
        public DateTime Fecha_Creacion_Ficha { get; set; }
        public int Id_Nutricionista { get; set; }
        public int Id_Paciente { get; set; }
    }
}