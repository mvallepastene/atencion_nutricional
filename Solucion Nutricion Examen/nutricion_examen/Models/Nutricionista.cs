using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;

namespace nutricion_examen.Models
{
    public class Nutricionista
    {
        public int Id_Nutricionista { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Numero_Tel { get; set; }
        public string Email { get; set; }
        public string Especialidad { get; set; }

    }
}