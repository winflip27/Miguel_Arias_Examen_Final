using Miguel_Arias_Examen_Final.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Miguel_Arias_Examen_Final.Vistas
{
    public class UsuarioControlador : Controller
    {
        private readonly UsuarioServicio _usuarioServicio;

        public UsuarioControlador()
        {
            _usuarioServicio = new UsuarioServicio();
        }

        
        public ActionResult Editar(int id)
        {
            var usuario = _usuarioServicio.ObtenerUsuarios().FirstOrDefault(u => u.ID_Usuario == id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        
        [HttpPost]
        public ActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioServicio.ActualizarUsuario(usuario);
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        
        public ActionResult Eliminar(int id)
        {
            _usuarioServicio.EliminarUsuario(id);
            return RedirectToAction("Index");
        }
    }
}