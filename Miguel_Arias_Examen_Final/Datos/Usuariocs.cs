using Miguel_Arias_Examen_Final.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miguel_Arias_Examen_Final.Data
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        // Relación uno a muchos con Viajeros
        public virtual ICollection<Viajero> Viajeros { get; set; }
    }
}