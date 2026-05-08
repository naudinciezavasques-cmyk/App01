using System;
using System.Collections.Generic;

namespace Dominio.entidades
{
    public class Pedido
    {
        public int IdPedido { get; private set; }
        public DateTime FechaHora { get; private set; }
        public Usuario Mesero { get; private set; }
        public Mesa Mesa { get; private set; }
        public EstadoPedido EstadoPedido { get; private set; }
        public List<ItemPedido> ItemsPedido { get; private set; }

        public Pedido(int idPedido, Usuario mesero, Mesa mesa, EstadoPedido estadoPedido)
        {
            if (idPedido <= 0)
                throw new ArgumentException("El ID debe ser mayor a 0.");
            if (mesero == null)
                throw new ArgumentNullException(nameof(mesero));
            if (mesa == null)
                throw new ArgumentNullException(nameof(mesa));

            IdPedido = idPedido;
            FechaHora = DateTime.Now;
            Mesero = mesero;
            Mesa = mesa;
            EstadoPedido = estadoPedido;
            ItemsPedido = new List<ItemPedido>();
        }

        public void CambiarEstado(EstadoPedido nuevoEstado)
        {
            EstadoPedido = nuevoEstado;
        }

        public void AgregarItem(ItemPedido item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            ItemsPedido.Add(item);
        }
    }
}