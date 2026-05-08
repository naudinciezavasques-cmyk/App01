namespace App01.Vistas;

using App01.VistaModelo;

public partial class VistaDemoVxaml : ContentPage
{
	public VistaDemoVxaml()
	{
		InitializeComponent();
		BindingContext = new DemoMesasVM();
	}
}