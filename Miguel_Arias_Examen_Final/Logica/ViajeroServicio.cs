using Miguel_Arias_Examen_Final.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miguel_Arias_Examen_Final.Logica
{
    public class ViajeroServicio
    {
        private readonly ControlMigracionContext _context;

        public ViajeroServicio()
        {
            _context = new ControlMigracionContext();
        }

        public IEnumerable<Viajero> ObtenerViajeros()
        {
            return _context.Viajeros.ToList();
        }

        public void RegistrarViajero(Viajero viajero)
        {
            _context.Viajeros.Add(viajero);
            _context.SaveChanges();
        }



    }
}