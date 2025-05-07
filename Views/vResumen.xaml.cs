using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace aburbanoExamen.Views;

public partial class vResumen : ContentPage
{
    public vResumen(string Nombre, string Apellido, string VA, DateTime Fecha, string Ciudad, string MontoInicial, string CuotaMensual)
	{
		InitializeComponent();

        Nombre = lblNombre.Text;
        Apellido = lblApellido.Text;
        VA = lblVA.Text;
        Fecha = lblFecha.Text;
        Ciudad = lblCiudad.Text;
        MontoInicial = lblMontoInicial.Text;
        CuotaMensual = lblCuotamensual.Text;
    }

    private async void btnCerrarSesion_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.vLogin());
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.vLogin());
    }
}

