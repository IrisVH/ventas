using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.proyecto
{
    class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>

    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuarios();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuario.Add(usuarioAdmin);

            var usuariocaja = new Usuarios();
            usuariocaja.Nombre = "caja";
            usuariocaja.Contrasena = "456";

            contexto.Usuario.Add(usuariocaja);

            var usuariorrhh = new Usuarios();
            usuariorrhh.Nombre = "rrhh";
            usuariorrhh.Contrasena = "123";

            contexto.Usuario.Add(usuariorrhh);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Equipo de construccion";
            contexto.Categoria.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Herramientas para baño";
            contexto.Categoria.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Electricidad";
            contexto.Categoria.Add(categoria3);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Construccion";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Limpieza";
            contexto.Tipos.Add(tipo2);

            var tipo3 = new Tipo();
            tipo3.Descripcion = "Cables";
            contexto.Tipos.Add(tipo3);

            var cliente1 = new Clientes();
            cliente1.Nombre = "Juan Reyes";
            contexto.Clientes.Add(cliente1);

            var cliente2 = new Clientes();
            cliente2.Nombre = "Lucas Ramos";
            contexto.Clientes.Add(cliente2);


            base.Seed(contexto);

        }
    }
}
