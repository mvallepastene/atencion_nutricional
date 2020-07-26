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
        public int Id_Nutricionista { get; set; }
        public int Id_Paciente { get; set; }
        public string Observaciones { get; set; }
        public float Peso_Ideal { get; set; }
        public float Peso_Max { get; set; }
        public float Peso_Ajustado { get; set; }
        public float Circ_Cint { get; set; }
        public string Clasi_CC { get; set; }
        public float Req_Total { get; set; }
        public float Req_Fac_Act { get; set; }
        public float Req_Formula { get; set; }
        public float Req_Prot { get; set; }
        public float Req_Cho { get; set; }
        public float Req_Lip { get; set; }
        public float Amdr_Prot { get; set; }
        public float Amdr_Cho { get; set; }
        public float Amdr_Lip { get; set; }
        public float Peso_Requerido { get; set; }
        public DateTime Prox_Control { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public string Nombre_Nutri { get; set; }

    }
}