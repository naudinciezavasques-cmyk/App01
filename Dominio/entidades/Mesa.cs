using System;

namespace Dominio.entidades
{
    public class Mesa
    {
        public int IdMesa { get; private set; }
        public int CapacidadMesa { get; private set; }
        public int NumeroMesa { get; private set; }
        public EstadoMesa Estado { get; private set; }  // ← renombrado a "Estado"
        public Ambiente Ambiente { get; private set; }

        public Mesa(int idMesa, int capacidadMesa, int numeroMesa, EstadoMesa estadoMesa, Ambiente ambiente)
        {
            if (idMesa <= 0)
                throw new ArgumentException("El ID debe ser mayor a 0.");

            if (capacidadMesa <= 0)
                throw new ArgumentException("La capacidad debe ser mayor a 0.");

            if (numeroMesa <= 0)
                throw new ArgumentException("El número debe ser mayor a 0.");

            if (ambiente == null)
                throw new ArgumentNullException(nameof(ambiente));

            IdMesa = idMesa;
            CapacidadMesa = capacidadMesa;
            NumeroMesa = numeroMesa;
            Estado = estadoMesa;  // ← actualizado
            Ambiente = ambiente;
        }

        public void CambiarEstado(EstadoMesa nuevoEstado)
        {
            Estado = nuevoEstado;  // ← actualizado
        }
    }
}