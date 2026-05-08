using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.DTOs
{
    public class MesaDTO
    {
        public int IdMesa {  get; set; }
        public int NumeroMesa { get; set; }
        public int Capacidad { get; set; }
        public int EstadoId { get; set; }
        public string EstadoMesa { get; set; } = string.Empty;
        public string NombreColor { get; set; } = string.Empty;
        public int NombreMesa { get; internal set; }
        public int InformacionAdicional { get; set; }
    }
}
