using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Routing.Constraints;

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
        public float Peso_Ideal { get; set; }
        public float Peso_Maximo_Aceptable { get; set; }
        public float Energia { get; set; }
        public float Proteinas { get; set; }
        public float Carbohidratos { get; set; }
        public float Lipidos { get; set; }
        public float Total { get; set; }
        public float Porc_Amdr { get; set; }
        public float Porc_Adecuacion { get; set; }
        public float Circunferencia_Cin { get; set; }
        public string Clasificacion_Cc { get; set; }
        public float Calc_Requerimientos { get; set; }
    }
}