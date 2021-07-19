using BL.proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.proyecto
{
    public class ProductosBL
    {
        Contexto _contexto;
        public BindingList<producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto(); 
            ListaProductos = new BindingList<producto>();

        }
        public BindingList<producto> obtenerproductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();

            return ListaProductos;
        }
        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarProducto(producto producto)
        {
            var resultado = Validar(producto);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }
        public void AgregarProducto()
        {
            var nuevoProducto = new producto();
            ListaProductos.Add(nuevoProducto);
        }
        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;
                }

            }
            return false;
        }
        private Resultado Validar(producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;
            if (string.IsNullOrEmpty(producto.descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;

            }
            if (producto.existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;

            }

            if (producto.CategoriaId == 0)
            {
                resultado.Mensaje = "Seleccione una categoria";
                resultado.Exitoso = false;

            }

            if (producto.TipoId == 0)
            {
                resultado.Mensaje = "Seleccione un tipo";
                resultado.Exitoso = false;

            }
            if (producto.precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;

            }

            return resultado;
        }
    }


}
public class producto
{
    public int Id { get; set; }
    public string descripcion { get; set; }
    public double precio { get; set; }
    public int existencia { get; set; }
    public int TipoId { get; set; }
    public Tipo Tipo { get; set; }
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }
    public byte[] foto { get; set; }
    public bool activo { get; set; }
}

public class Resultado
{
    public bool Exitoso { get; set; }
    public string Mensaje { get; set; }
}
