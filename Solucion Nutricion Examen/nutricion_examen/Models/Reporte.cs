using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
       
        private string nombre_nutri;

        public string Nombre_Nutri
        {
            get { return nombre_nutri; }
            set {
                if (nombre_nutri == string.Empty)
                {
                    nombre_nutri = null;
                } else
                    nombre_nutri = value; 
            }
        }

    }
}