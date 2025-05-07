using static System.Runtime.InteropServices.JavaScript.JSType;

namespace aburbanoExamen.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro(string usuario)
	{
        InitializeComponent();
        lblUsuarioCon.Text = "Usuario conectado: " + usuario ;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double montoInicial = double.Parse(txtMontoInicial.Text);
        double cuotaMensual = ((300 - montoInicial) * 1.05) / 3;
        txtCuotamensual.Text = $"Cuota mensual: {cuotaMensual:F2}";


    }

    private async void btnVerResumen_Clicked(object sender, EventArgs e)
    {

        string Nombre = txtNombre.Text,
        Apellido = txtApellido.Text,
        VA = pcIva.SelectedIndex.ToString(),
        Fecha = dpfecha.Date.ToString("yyyy-MM-dd"),
        Ciudad = pcCiudad.SelectedIndex.ToString(),
        MontoInicial = txtMontoInicial.Text,
        CuotaMensual = txtCuotamensual.Text;
        
        await Navigation.PushAsync(Views.vResumen(Nombre, Apellido, Va, Fecha, Ciudad, MontoInicial, CuotaMensual));
    }
