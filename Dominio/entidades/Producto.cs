using System;

namespace Dominio.entidades
{
    public class Producto
    {
        public int IdProducto { get; private set; }
        public string Nombre { get; private set; }
        public decimal Precio { get; private set; }
        public CategoriaProducto Categoria { get; private set; }
        public bool EstadoAgotado { get; private set; }
        public string Foto { get; private set; }

        public Producto(int idProducto, string nombre, decimal precio, CategoriaProducto categoria, string foto = "")
        {
            if (idProducto <= 0)
                throw new ArgumentException("El ID debe ser mayor a 0.");
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a 0.");
            if (categoria == null)
                throw new ArgumentNullException(nameof(categoria));

            IdProducto = idProducto;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
            EstadoAgotado = false;
            Foto = foto;
        }

        public void MarcarAgotado() => EstadoAgotado = true;
        public void MarcarDisponible() => EstadoAgotado = false;
    }

    public class CategoriaProducto
    {
        public int IdCategoria { get; private set; }
        public string NombreCategoria { get; private set; }

        public CategoriaProducto(int idCategoria, string nombreCategoria)
        {
            if (idCategoria <= 0)
                throw new ArgumentException("El ID debe ser mayor a 0.");
            if (string.IsNullOrWhiteSpace(nombreCategoria))
                throw new ArgumentException("El nombre no puede estar vacío.");

            IdCategoria = idCategoria;
            NombreCategoria = nombreCategoria;
        }
    }
}