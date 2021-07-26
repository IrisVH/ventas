using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.proyecto
{
    public class Contexto: DbContext
    {
        public Contexto(): base("VideoJuegos")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
           
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<producto> Productos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Facturas> Factura { get; set; }

    }   
}
