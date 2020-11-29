using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private string _fecNac;

        public string Fecha_Nacimiento
        {
            get { return _fecNac; }
            set
            {
                //Verificamos si el tipo de dato que llega es DateTime.
                if (_fecNac is DateTime)
                {
                    //Si es verdadero, el dato lo transformo a string.
                    _fecNac.ToString();
                }
                // se retorna con el dato en el tipo de dato convertido... en este caso string
                _fecNac = value; }
        }

        public string Numero_Tel { get; set; }
        public string Email { get; set; }
        public string Especialidad { get; set; }

    }
}