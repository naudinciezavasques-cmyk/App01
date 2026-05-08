using Aplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Dominio.entidades;

namespace Aplicacion.Mappings
{
    public static class MappingExtensions
    {
        // Convertir Entidad a DTO
        public static MesaDTO toDTO(this Mesa mesa)
        {
            return new MesaDTO
            {
                IdMesa = mesa.IdMesa,
                Capacidad = mesa.CapacidadMesa,
                NumeroMesa = mesa.NumeroMesa
            };
        }
        public static List<MesaDTO> toDtoList(this IEnumerable<Mesa> mesas)
        { 
            // select es un metodo de LINQ 
            return mesas.Select(mesa => mesa.toDTO()).ToList();
      
        }
    }
}