using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.proyecto
{
    public class CategoriaBL
    {
        Contexto _contexto;

        public BindingList<Categoria> ListaCategoria { get; set; }

        public CategoriaBL()
        {
            _contexto = new proyecto.Contexto();
            ListaCategoria = new BindingList<Categoria>();
        }

        public BindingList<Categoria> ObtenerCategoria()
        {
            _contexto.Categoria.Load();
            ListaCategoria = _contexto.Categoria.Local.ToBindingList();

            return ListaCategoria;

        }
    }

    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
