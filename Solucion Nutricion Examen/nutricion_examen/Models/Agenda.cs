using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nutricion_examen.Models
{
    public class Agenda
    {
        public int Id_Agenda { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Nuemero_Tel { get; set; }
        public string Email { get; set; }
        public DateTime Fecha_Cita { get; set; }
        public string Hora_Cita { get; set; }
        public int Id_Estado { get; set; }
    }
}