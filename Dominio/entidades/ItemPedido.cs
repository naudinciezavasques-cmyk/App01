using System;

namespace Dominio.entidades
{
    public class ItemPedido
    {
        public int IdItemPedido { get; private set; }
        public Producto Producto { get; private set; }
        public decimal Cantidad { get; private set; }
        public decimal PrecioUnitario { get; private set; }
        public string Nota { get; private set; }

        public decimal Subtotal => Cantidad * PrecioUnitario;

        public ItemPedido(int idItemPedido, Producto producto, decimal cantidad, decimal precioUnitario, string nota = "")
        {
            if (idItemPedido <= 0)
                throw new ArgumentException("El ID debe ser mayor a 0.");
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a 0.");
            if (precioUnitario <= 0)
                throw new ArgumentException("El precio debe ser mayor a 0.");

            IdItemPedido = idItemPedido;
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Nota = nota;
        }
    }
}