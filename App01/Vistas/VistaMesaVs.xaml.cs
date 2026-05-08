using App01.VistaModelo;

namespace App01.Vistas;

public partial class VistaMesaVs : ContentPage
{
    public VistaMesaVs()
    {
        InitializeComponent();
    }

    // Se ejecuta cuando presionas "Filtrar"
    private void OnFiltrarClicked(object sender, EventArgs e)
    {
        var vm = BindingContext as VistaModeloMesas;
        vm?.Filtrar();
    }
}