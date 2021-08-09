using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.proyecto
{
    public class SeguridadBL
    {
        Contexto _contexto;
        public BindingList<Usuarios> ListaUsuarios { get; set; }

        public SeguridadBL()
        {
            _contexto = new Contexto();
            ListaUsuarios = new BindingList<Usuarios>();
        }

        public Usuarios Autorizar(string nombreUsuario, string contrasena)
        {
            var usuarios = _contexto.Usuario.ToList();

            foreach (var usuarioDB in usuarios)
            {
                if (nombreUsuario == usuarioDB.Nombre && contrasena == usuarioDB.Contrasena)
                {
                    return usuarioDB;
                }
            }

            return null;
        }
        public BindingList<Usuarios> ObtenerUsuarios()
        {
            _contexto.Usuario.Load();
            ListaUsuarios = _contexto.Usuario.Local.ToBindingList();

            return ListaUsuarios;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarUsuario(Usuarios usuario)
        {
            var resultado = Validar(usuario);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuarios();
            _contexto.Usuario.Add(nuevoUsuario);
        }

        public bool EliminarUsuario(int id)
        {
            foreach (var usuario in ListaUsuarios.ToList())
            {
                if (usuario.Id == id)
                {
                    ListaUsuarios.Remove(usuario);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Usuarios usuario)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (usuario == null)
            {
                resultado.Mensaje = "Agregue un usuario valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (usuario == null)
            {
                resultado.Mensaje = "Agregue un usuario valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(usuario.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del usuario";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
    }
}
