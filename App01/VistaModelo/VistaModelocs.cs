using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Dominio.entidades;

namespace App01.VistaModelo
{
    // Clase que representa una mesa para mostrar en pantalla
    public class MesaVM : INotifyPropertyChanged
    {
        public int Numero { get; set; }
        public int Capacidad { get; set; }
        public string Ambiente { get; set; }
        public EstadoMesa Estado { get; set; }

        // El texto que se muestra en la tarjeta
        public string Texto => $"Mesa {Numero} - Cap: {Capacidad}";

        // El estado en texto
        public string EstadoTexto => Estado switch
        {
            EstadoMesa.Libre => "Libre",
            EstadoMesa.Ocupada => "Ocupada",
            EstadoMesa.Reservada => "Reservada",
            _ => "Desconocido"
        };

        // El color según estado
        public Color ColorFondo => Estado switch
        {
            EstadoMesa.Libre => Color.FromArgb("#2ECC71"), // Verde
            EstadoMesa.Ocupada => Color.FromArgb("#E74C3C"), // Rojo
            EstadoMesa.Reservada => Color.FromArgb("#F39C12"), // Naranja
            _ => Colors.Gray
        };

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string nombre = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
    }

    // El ViewModel principal
    public class VistaModeloMesas : INotifyPropertyChanged
    {
        // Lista completa (no cambia)
        private List<MesaVM> _todasLasMesas;

        // Lista filtrada (la que ve el usuario)
        private ObservableCollection<MesaVM> _mesasFiltradas;
        public ObservableCollection<MesaVM> MesasFiltradas
        {
            get => _mesasFiltradas;
            set { _mesasFiltradas = value; OnPropertyChanged(); }
        }

        // Texto del buscador
        private string _textoBusqueda = "";
        public string TextoBusqueda
        {
            get => _textoBusqueda;
            set { _textoBusqueda = value; OnPropertyChanged(); }
        }

        public VistaModeloMesas()
        {
            // Mesas de ejemplo con estados variados
            _todasLasMesas = new List<MesaVM>
            {
                new MesaVM { Numero=1,  Capacidad=2, Ambiente="Salón A", Estado=EstadoMesa.Libre },
                new MesaVM { Numero=2,  Capacidad=4, Ambiente="Salón A", Estado=EstadoMesa.Ocupada },
                new MesaVM { Numero=3,  Capacidad=4, Ambiente="Salón A", Estado=EstadoMesa.Libre },
                new MesaVM { Numero=4,  Capacidad=6, Ambiente="Salón B", Estado=EstadoMesa.Ocupada },
                new MesaVM { Numero=5,  Capacidad=2, Ambiente="Salón B", Estado=EstadoMesa.Reservada },
                new MesaVM { Numero=6,  Capacidad=4, Ambiente="Salón B", Estado=EstadoMesa.Libre },
                new MesaVM { Numero=7,  Capacidad=8, Ambiente="Terraza", Estado=EstadoMesa.Ocupada },
                new MesaVM { Numero=8,  Capacidad=4, Ambiente="Terraza", Estado=EstadoMesa.Libre },
                new MesaVM { Numero=9,  Capacidad=6, Ambiente="Terraza", Estado=EstadoMesa.Ocupada },
                new MesaVM { Numero=10, Capacidad=2, Ambiente="Salón A", Estado=EstadoMesa.Libre },
            };

            MesasFiltradas = new ObservableCollection<MesaVM>(_todasLasMesas);
        }

        // Se llama cuando presionas el botón Filtrar
        public void Filtrar()
        {
            var texto = TextoBusqueda?.ToLower() ?? "";

            var resultado = _todasLasMesas.Where(m =>
                texto == "" ||
                m.Numero.ToString().Contains(texto) ||
                m.Ambiente.ToLower().Contains(texto) ||
                m.EstadoTexto.ToLower().Contains(texto)
            ).ToList();

            MesasFiltradas = new ObservableCollection<MesaVM>(resultado);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string nombre = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
    }
}