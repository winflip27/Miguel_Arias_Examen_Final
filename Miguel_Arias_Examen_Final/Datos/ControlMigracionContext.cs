using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Miguel_Arias_Examen_Final.Datos
{


    public class ControlMigracionContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Viajero> Viajeros { get; set; }
        public DbSet<EntradaSalida> EntradasSalidas { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<HistorialViaje> HistorialViajes { get; set; }
        public DbSet<Visa> Visas { get; set; }

        public ControlMigracionContext() : base("name=ControlMigracion")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}