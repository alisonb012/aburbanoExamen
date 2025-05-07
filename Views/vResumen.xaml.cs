using static System.Runtime.InteropServices.JavaScript.JSType;

namespace aburbanoExamen.Views;

public partial class vResumen : ContentPage
{
    public vResumen(string Nombre, string Apellido, string VA, DateTime Fecha, string Ciudad, string MontoInicial, string CuotaMensual)
	{
		InitializeComponent();

        Nombre = lblNombre.Text;
        Apellido = lblApellido.Text,
        VA = lblVA,
        Fecha = lblFecha,
        Ciudad = lblCiudad,
        MontoInicial = txtMontoInicial.Text,
        CuotaMensual = txtCuotamensual.Text;
    }
}

