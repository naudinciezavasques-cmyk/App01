using Aplicacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Dominio.entidades;
using Aplicacion.DTOs;
using Aplicacion.Mappings;

namespace Aplicacion.CasosDeUso
{
    public class ObtenerMesas

        // Inyección de dependencias del repositorio de mesas
    {
        private readonly IRepository<Mesa> _mesaRepository;
        // Constructor para inyectar el repositorio de mesas
        public ObtenerMesas(IRepository<Mesa> mesaRepository)
        {
            _mesaRepository = mesaRepository;
        }
        // Método para obtener todas las mesas
        public async Task<List<MesaDTO>> EjecutarAsync()
        {
            // Llamada al repositorio para obtener todas las mesas
            var mesas = await _mesaRepository.GetAllAsync();
            // Mapear las entidades de dominio a objetos de transferencia de datos (DTO) si es necesario
            return mesas.toDtoList();
        }
    }
}
