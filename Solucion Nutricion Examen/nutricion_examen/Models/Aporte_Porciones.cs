using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace nutricion_examen.Models
{
    public class Aporte_Porciones
    {
        public int Id_Aporte { get; set; }
        public string Grupo { get; set; }
        public float Energia { get; set; }
        public float Cho { get; set; }
        public float Proteinas { get; set; }
        public float Lipidos { get; set; }
        public int Id_Ficha { get; set; }
    }
}