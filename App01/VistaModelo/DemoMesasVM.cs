using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using App01.Vistas;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Aplicacion.DTOs;
using System.Security.Cryptography.X509Certificates;

namespace App01.VistaModelo
{
    public partial class DemoMesasVM : ObservableObject
    {
        [ObservableProperty]
        public partial ObservableCollection<string> ListaMesas { get; set; }

        [RelayCommand]
        private void CargarMesas()
        {
            ListaMesas = new ObservableCollection<string>
            {
                "Mesa #1 - libre - capacidad 4 personas",
                "Mesa #2 - ocupada - capacidad 2 personas",
                "Mesa #3 - reservada - capacidad 6 personas",
                "Mesa #4 - libre - capacidad 4 personas",
                "Mesa #5 - ocupada - capacidad 2 personas"
            };
        }
        [ObservableProperty]
        private ObservableCollection<MesaDTO> listaMesasDTO;
        [RelayCommand]
        private void CargarMesasDTO()
        {
            ListaMesasDTO = new ObservableCollection<MesaDTO>{
                new MesaDTO{IdMesa = 1, NumeroMesa = 1, Capacidad = 4, EstadoId = 1, EstadoMesa = "libre", NombreColor = "DarkGreen" },
                new MesaDTO{IdMesa = 2, NumeroMesa = 2, Capacidad = 4, EstadoId = 2, EstadoMesa = "ocupado", NombreColor = "Red" },
                new MesaDTO{IdMesa = 3, NumeroMesa = 3, Capacidad = 4, EstadoId = 3, EstadoMesa = "reservado", NombreColor = "Violet"
                }

            };

        }
    }
}
