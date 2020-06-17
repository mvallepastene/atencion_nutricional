using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nutricion_examen.Models
{
    public class Paciente
    {
        public int Id_Paciente { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Numero_Tel { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }
        public string Comuna { get; set; }
        public string Email { get; set; }
        public string Prevision { get; set; }
        public string Ocupacion { get; set; }
        public int Id_Agenda { get; set; }
    }
}