using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nutricion_examen.Models
{
    public class Acceso
    {
        public int Id_Acceso { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public char Tipo_Usuario { get; set; }
    }
}