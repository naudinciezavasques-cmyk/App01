using System;

namespace Dominio.entidades
{
    public class Ambiente
    {
        public int IdAmbiente { get; set; }
        public string NombreAmbiente { get; set; }
        public int CapacidadTotal { get; set; }

        public Ambiente(int idAmbiente, string nombreAmbiente, int capacidadTotal)
        {
            if (idAmbiente <= 0)
            {
                throw new Exception("El ID debe ser mayor a 0.");
            }

            if (string.IsNullOrWhiteSpace(nombreAmbiente))
            {
                throw new Exception("El nombre no puede estar vacío.");
            }

            if (capacidadTotal <= 0)
            {
                throw new Exception("La capacidad debe ser mayor a 0.");
            }

            IdAmbiente = idAmbiente;
            NombreAmbiente = nombreAmbiente;
            CapacidadTotal = capacidadTotal;
        }
    }
}