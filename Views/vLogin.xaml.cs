namespace aburbanoExamen.Views;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
       
	}
    private readonly string[] user = { "estudiante2025", "uisrael", "sistemas" };
    private readonly string[] pass = { "moviles", "2025", "2025_1" };

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrase�a = txtContrase�a.Text;

        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrase�a))
        {
            DisplayAlert("Error", "Por favor ingrese usuario y contrase�a", "Aceptar");
        }

        int ingreso = Array.IndexOf(user, usuario);
        if (ingreso != -1 && pass[ingreso] == contrase�a)
        {
            Navigation.PushAsync(new Views.vRegistro(usuario));
        }
        else
        {
            DisplayAlert("Error", "Usuario o contrase�a incorrectos.", "Aceptar");
        }

    }


    private void btnAcerca_Clicked(object sender, EventArgs e)
    {

    }