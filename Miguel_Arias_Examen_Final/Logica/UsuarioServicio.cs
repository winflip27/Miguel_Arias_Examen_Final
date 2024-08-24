using Miguel_Arias_Examen_Final.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miguel_Arias_Examen_Final.Logica
{
    public class UsuarioServicio
    {
        private readonly ControlMigracionContext _context;

        public UsuarioServicio()
        {
            _context = new ControlMigracionContext();
        }

        
        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            return _context.Usuarios.ToList();
        }

       
        public void RegistrarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        
        public void ActualizarUsuario(Usuario usuario)
        {
            var usuarioExistente = _context.Usuarios.Find(usuario.ID_Usuario);
            if (usuarioExistente != null)
            {
                usuarioExistente.Nombre = usuario.Nombre;
                usuarioExistente.Apellido = usuario.Apellido;
                usuarioExistente.Email = usuario.Email;
                usuarioExistente.Contraseña = usuario.Contraseña;
                usuarioExistente.Rol = usuario.Rol;

                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Usuario no encontrado.");
            }
        }

        
        public void EliminarUsuario(int idUsuario)
        {
            var usuario = _context.Usuarios.Find(idUsuario);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Usuario no encontrado.");
            }
        }
    }
}