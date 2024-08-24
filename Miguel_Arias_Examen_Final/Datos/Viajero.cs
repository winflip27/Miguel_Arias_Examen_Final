using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miguel_Arias_Examen_Final.Datos
{
    public class Viajero
    {
        public int ID_Viajero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Numero_Pasaporte { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int ID_Usuario { get; set; }

        // Relación con Usuario
        public Usuario.datos Usuario { get; set; }
    }
}