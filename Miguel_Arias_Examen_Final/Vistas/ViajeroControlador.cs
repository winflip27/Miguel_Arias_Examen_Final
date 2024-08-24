using Miguel_Arias_Examen_Final.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Miguel_Arias_Examen_Final.Vistas
{
    public class ViajeroControlador : Controlador
    {
        private readonly ViajeroServicio _viajeroServicio;

        public ViajeroControlador()
        {
            _viajeroServicio = new ViajeroServicio();
        }

        public ActionResult Index()
        {
            var viajeros = _viajeroServicio.ObtenerViajeros();
            return View(viajeros);
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Viajero viajero)
        {
            if (ModelState.IsValid)
            {
                _viajeroServicio.RegistrarViajero(viajero);
                return RedirectToAction("Index");
            }

            return View(viajero);
        }

       
    }

}